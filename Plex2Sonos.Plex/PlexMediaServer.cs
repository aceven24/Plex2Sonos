using DynamicRestProxy.PortableHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Configuration;

namespace Plex2Sonos.Plex
{
    public class PlexMediaServer
    {
        private Dictionary<string, Track> trackIndex;
        private Dictionary<string, Album> albumIndex;
        private Dictionary<string, Artist> artistIndex;
        private static PlexMediaServer instance;
        private DynamicRestClientDefaults restClientDefaults;
        public List<MusicSection> MusicSections { get; private set; }
        public string PlexServerAndPort { get; private set; }
        private PlexMediaServer()
        {

        }

        public static PlexMediaServer Instance()
        {
            if (instance == null)
            {
                lock (typeof(PlexMediaServer))
                {
                    if (instance == null)
                    {
                        Initialize();
                    }
                }
            }
            return instance;
        }
        private static void Initialize()
        {
            var singleton = new PlexMediaServer();
            singleton.DefineRESTDefaults();
            singleton.PlexServerAndPort = ConfigurationManager.AppSettings["PlexServerAndPort"];
            instance = singleton;
           
            
        }

        private void PopulateIndicies()
        {
            lock (this)
            {
                trackIndex = MusicSections.SelectMany(p => p.Artists).SelectMany(p => p.Albums).SelectMany(p => p.Tracks).Select(p => new KeyValuePair<string, Track>(p.Key, p)).ToDictionary(kv => kv.Key, kv => kv.Value);
                albumIndex = MusicSections.SelectMany(p => p.Artists).SelectMany(p => p.Albums).Select(p => new KeyValuePair<string, Album>(p.Key, p)).ToDictionary(kv => kv.Key, kv => kv.Value);
                artistIndex = MusicSections.SelectMany(p => p.Artists).Select(p => new KeyValuePair<string, Artist>(p.Key, p)).ToDictionary(kv => kv.Key, kv => kv.Value);
            }
        }

        private async Task<List<MusicSection>> DiscoverMusicSections()
        {
            using (dynamic client = this.CreateDynamicClient("library/sections"))
            {
                dynamic result = await client.get();
                var sections = result._children as IEnumerable<dynamic>;
                return sections.Where(p => p.type == "artist").Select(q => new MusicSection(q)).ToList();
            }
        }
        public async Task<DateTime> DetermineMusicLibraryLastUpdateDate()
        {
            var sections = await DiscoverMusicSections();
            if (MusicSections == null)
            {
                sections = MusicSections;
            }
            return MusicSections.Max(p => p.LastUpdated);
        }
        public void LoadMusicSectionDetails(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            {
                using (var gStream = new GZipStream(stream, CompressionMode.Decompress))
                {
                    MusicSections = ProtoBuf.Serializer.Deserialize<List<MusicSection>>(gStream);
                    PopulateIndicies();
                    gStream.Close();
                }
            }
        }
        public async Task GetMusicSectionDetails()
        {
            var sections = await DiscoverMusicSections();
            if (MusicSections == null)
            {
                MusicSections = sections;
            
            }
            else
            {
                //TODO: Delete Old Ones.. 
                //TODO: Add New Ones..
                //Yeah this needs to go into one linq statement, but have a three year old bothering me right now..
                foreach(var section in sections)
                {
                    if (MusicSections.Exists(p=>p.Key == section.Key ))
                    {
                        var ms = MusicSections.Single(p => p.Key == section.Key);
                        if (ms.LastUpdated < section.LastUpdated)
                        {
                            //Puke, need to just figure out what changed, not reload whole collection
                            ms.LastProcessed = null;
                        }
                    }
                }
            }

            var sectionsNeverUpdated = MusicSections.Where(p => p.LastProcessed == null);
            foreach (var section in sectionsNeverUpdated)
            {
                var artists = await GetMusicSectionArtists(section);
                section.LastProcessed = DateTime.Now;
                section.Artists = artists;
            }
            PopulateIndicies();
        }

        public void SaveMusicSectionDetails(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                using (var gStream = new GZipStream(stream, CompressionLevel.Optimal))
                {
                    ProtoBuf.Serializer.Serialize(gStream, MusicSections);
                    gStream.Close();
                }
            }
        }

        private async Task<List<Album>> GetArtistAlbums(Artist artist)
        {
            var list = new List<Album>();
            using (dynamic client = this.CreateDynamicClient(artist.Key))
            {
                dynamic result = await client.get();
                var albums = result._children as IEnumerable<dynamic>;
                var tasks = albums.Select(async album =>
                {
                    var a = new Album(artist, album);
                    a.Tracks = await BuildTracks(a);
                    if (a.Tracks.Count > 0)
                    {
                        lock (list) //ick, yes need to do concurrent
                        {
                            list.Add(a);
                        }
                    }
                });
                await Task.WhenAll(tasks);
                return list;

            }
        }

        private async Task<List<Track>> BuildTracks(Album album)
        {
            var list = new List<Track>();
            using (dynamic client = this.CreateDynamicClient(album.Key))
            {
                dynamic result = await client.get();
                var tracks = result._children as IEnumerable<dynamic>;
                foreach (dynamic track in tracks)
                {
                    var t = new Track(album, track);
                    if (t.Duration > 0)
                        list.Add(t);
                }
            }
            return list;
        }

        public Track LookupTrack(string key)
        {
            return trackIndex[key];
        }

        public Album LookupAlbum(string key)
        {
            return albumIndex[key];
        }

        public Artist LookupArtist(string key)
        {
            return artistIndex[key];
        }

        private async Task<List<Artist>> GetMusicSectionArtists(MusicSection musicSection)
        {
            var list = new List<Artist>();
            using (dynamic client = this.CreateDynamicClient(string.Format("library/sections/{0}/all", musicSection.SectionID)))
            {
                dynamic result = await client.get();
                var artists = result._children as IEnumerable<dynamic>;
                foreach (dynamic artist in artists)
                {
                    var a = new Artist(musicSection, artist);
                    a.Albums = await GetArtistAlbums(a);
                    if (a.Albums.Count > 0)
                    {
                        list.Add(a);
                    }
                }
            }
            return list;
        }

        private void DefineRESTDefaults()
        {
            restClientDefaults = new DynamicRestClientDefaults();
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_PLATFORM, "Windows");
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_PLATFORM_VERSION, System.Environment.Version.ToString());
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_PROVIDES, "player");
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_CLIENT_IDENTIFIER, "38fc8a22-6fc5-46f2-8c6b-818e2758cfa2");
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_PRODUCT, "Plex2Sonos");
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_VERSION, "0.0.0.1");
            restClientDefaults.DefaultHeaders.Add(PlexHeaders.X_PLEX_DEVICE, System.Environment.MachineName);
            restClientDefaults.DefaultHeaders.Add("Accept", "application/json");
        }

        public dynamic CreateDynamicClient(string action)
        {
            return new DynamicRestClient(String.Format("http://{1}/{0}", action,PlexServerAndPort), restClientDefaults);
        }
    }
}
