using Plex2Sonos.Sonos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plex2Sonos.Sonos.DTO;
using Plex2Sonos.Plex;
using System.ServiceModel;
using System.Web;
using System.ServiceModel.Web;

namespace Plex2Sonos.Server
{
    public class MusicProxyServer : ISonosSoap
    {
        private PlexMediaServer Server
        {
            get
            {
                return PlexMediaServer.Instance();
            }
        }

        public static string BoundedIPAndPort { get; set; }
        public getExtendedMetadataResponse GetExtendedMetadata(getExtendedMetadataRequest request)
        {

            var itemType = request.id.Split('/')[0];
            var itemIndex = request.id.Substring(4);
            var response = new getExtendedMetadataResponse();
            switch (itemType)
            {
                case "S":
                    return null;
                case "Art":
                    var artist = Server.LookupArtist(itemIndex);
                    response.getExtendedMetadataResult = new extendedMetadata() { Item = BuildArtist(artist) };
                    if (!String.IsNullOrEmpty(artist.Summary))
                    {
                        response.getExtendedMetadataResult.relatedText = new relatedText[] { new relatedText() { id = request.id, type = "ARTIST_BIO" } };
                    }
                    return response;
                case "Alb":
                    var album = Server.LookupAlbum(itemIndex);
                    response.getExtendedMetadataResult = new extendedMetadata() { Item = BuildAlbum(album) };
                    var list = new List<relatedText>();
                    if (!String.IsNullOrEmpty(album.Summary))
                    {
                        list.Add(new relatedText() { id = request.id, type = "ALBUM_NOTES" });
                    }
                    if (!String.IsNullOrEmpty(album.Parent.Summary))
                    {
                        list.Add(new relatedText() { id = request.id, type = "ARTIST_BIO" });
                    }
                    response.getExtendedMetadataResult.relatedText = list.ToArray();
                    return response; ;
                case "Trk":
                    response.getExtendedMetadataResult = new extendedMetadata() { Item = RetrieveSingleTrackInfo(itemIndex) };
                    return response;
            }
            return null;
        }

        public getExtendedMetadataTextResponse GetExtendedMetadataText(getExtendedMetadataTextRequest request)
        {

            var itemType = request.id.Split('/')[0];
            var itemIndex = request.id.Substring(4);
            var response = new getExtendedMetadataTextResponse();
            switch (itemType)
            {
                case "S":
                    return null;
                case "Art":
                    var artist = Server.LookupArtist(itemIndex);
                    response.getExtendedMetadataTextResult = artist.Summary;
                    return response;
                case "Alb":
                    var album = Server.LookupAlbum(itemIndex);
                    switch(request.type)
                    {
                        case "ALBUM_NOTES":
                            response.getExtendedMetadataTextResult = album.Summary;
                            return response;
                        case "ARTIST_BIO":
                            response.getExtendedMetadataTextResult = album.Parent.Summary;
                            return response;
                    }
                    break;                   
                case "Trk":
                    return null;

            }
            return null;
        }
        public getLastUpdateResponse GetLastUpdate(getLastUpdateRequest request)
        {
            return new getLastUpdateResponse() { getLastUpdateResult = new lastUpdate() { catalog = this.Server.MusicSections.Max(p => p.LastUpdated).Ticks.ToString(), favorites = this.Server.MusicSections.Max(p => p.LastUpdated).Ticks.ToString() } };
        }

        public getMediaMetadataResponse GetMediaMetadata(getMediaMetadataRequest request)
        {
            var itemIndex = request.id.Substring(4);
            var response = new getMediaMetadataResponse();
            response.getMediaMetadataResult = RetrieveSingleTrackInfo(itemIndex);
            return response;
        }

        public getMediaURIResponse GetMediaUri(getMediaURIRequest request)
        {
            var itemIndex = request.id.Substring(4);
            return new getMediaURIResponse() { getMediaURIResult = String.Format("http://{1}{0}", Server.LookupTrack(itemIndex).StreamingKey,Server.PlexServerAndPort), httpHeaders = GeneratePlexHeaders() };
        }

        public getMetadataResponse GetMetadata(getMetadataRequest request)
        {
            if (request.id.Equals("root"))
            {
                var mediaList = new mediaList();
                var items = RetrieveMediaCollections();
                mediaList.Items = items.Skip(request.index).Take(request.count).ToArray();
                var response = new getMetadataResponse(mediaList);
                response.getMetadataResult.total = items.Length;
                response.getMetadataResult.count = mediaList.Items.Length;
                response.getMetadataResult.index = request.index;
                return response;
            }
            else
            {
                var itemType = request.id.Split('/')[0];

                switch (itemType)
                {
                    case "S":
                        return ExtractSections(request);
                    case "Art":
                        return ExtractAlbums(request);
                    case "Alb":
                        return ExtractTracks(request);
                }

                throw new NotImplementedException();
            }
        }

        public searchResponse Search(searchRequest request)
        {
            throw new NotImplementedException();
        }

        private getMetadataResponse ExtractAlbums(getMetadataRequest request)
        {
            var itemIndex = request.id.Substring(4);
            var mediaList = new mediaList();
            var items = RetrieveAlbums(itemIndex);
            mediaList.Items = items.Skip(request.index).Take(request.count).ToArray();
            var response = new getMetadataResponse(mediaList);
            response.getMetadataResult.total = items.Length;
            response.getMetadataResult.count = mediaList.Items.Length;
            response.getMetadataResult.index = request.index;
            return response;
        }

        private getMetadataResponse ExtractTracks(getMetadataRequest request)
        {
            var itemIndex = request.id.Substring(4);
            var mediaList = new mediaList();
            var items = RetrieveTracks(itemIndex);
            mediaList.Items = items.Skip(request.index).Take(request.count).ToArray();
            var response = new getMetadataResponse(mediaList);
            response.getMetadataResult.total = items.Length;
            response.getMetadataResult.count = mediaList.Items.Length;
            response.getMetadataResult.index = request.index;
            return response;
        }
        private mediaMetadata RetrieveSingleTrackInfo(string trackID)
        {
            var track = Server.LookupTrack(trackID);
            return BuildMediaMetadata(track);
        }

        private static trackMetadata BuildTrackMetadata(Track track)
        {
            return new trackMetadata()
            {
                album = track.Parent.Name,
                albumId = String.Format("Alb/{0}", track.Parent.Key),
                artist = track.Parent.Parent.Name,
                albumArtist = track.Parent.Parent.Name,
                albumArtistId = track.Parent.Parent.Key,
                albumArtURI = (!String.IsNullOrEmpty(track.Parent.ThumbLocation) ? new albumArtUrl() { Value = String.Format("http://192.168.1.227:8888/ImageService/GetImage?image={0}", track.Parent.ThumbLocation) } : null),
                canPlay = true,
                canPlaySpecified = true,
                duration = track.Duration / 1000,
                durationSpecified = true,
                trackNumber = track.Index,
                trackNumberSpecified = true,
                canAddToFavorites = true,
                canAddToFavoritesSpecified = true,
                canSkip = true,
                canSkipSpecified = true
            };
        }

        private getMetadataResponse ExtractSections(getMetadataRequest request)
        {
            var itemIndex = int.Parse(request.id.Split('/')[1]);
            var mediaList = new mediaList();
            var items = RetreiveArtists(itemIndex);
            mediaList.Items = items.Skip(request.index).Take(request.count).ToArray();
            var response = new getMetadataResponse(mediaList);
            response.getMetadataResult.total = items.Length;
            response.getMetadataResult.count = mediaList.Items.Length;
            response.getMetadataResult.index = request.index;
            return response;
        }

        private AbstractMedia[] RetrieveMediaCollections()
        {
            return Server.MusicSections.Select(p => new mediaCollection() { id = String.Format("S/{0}", p.SectionID.ToString()), itemType = itemType.container, title = "Browse Library" }).ToArray();
        }

        private AbstractMedia[] RetreiveArtists(int sectionID)
        {
            return Server.MusicSections.Single(p => p.SectionID == sectionID).Artists.Select(p => BuildArtist(p)).ToArray();
        }

        private static mediaCollection BuildArtist(Artist p)
        {
            return new mediaCollection() { id = String.Format("Art/{0}", p.Key), country = p.Country, itemType = itemType.artist, canPlay = true, canPlaySpecified = true, canEnumerate = true, canEnumerateSpecified = true, title = p.Name, albumArtURI = (!String.IsNullOrEmpty(p.ThumbLocation) ? new albumArtUrl() { Value = String.Format("http://192.168.1.227:8888/ImageService/GetImage?image={0}", p.ThumbLocation) } : null) };
        }

        private AbstractMedia[] RetrieveAlbums(string artistID)
        {
            return Server.LookupArtist(artistID).Albums.Select(p => BuildAlbum(p)).ToArray();
        }

        private static mediaCollection BuildAlbum(Album p)
        {
            return new mediaCollection() { id = String.Format("Alb/{0}", p.Key), itemType = itemType.album, canEnumerate = true, canEnumerateSpecified = true, canPlay = true, canPlaySpecified = true, title = p.Name, summary = p.Summary, artist = p.Parent.Name, albumArtURI = (!String.IsNullOrEmpty(p.ThumbLocation) ? new albumArtUrl() { Value = String.Format("http://192.168.1.227:8888/ImageService/GetImage?image={0}", p.ThumbLocation) } : null) };
        }

        private AbstractMedia[] RetrieveTracks(string albumID)
        {
            return Server.LookupAlbum(albumID).Tracks.OrderBy(p => p.Index).Select(track =>

                  BuildMediaMetadata(track)).ToArray();
        }

        private static mediaMetadata BuildMediaMetadata(Track track)
        {
            return new mediaMetadata()
            {
                Item = BuildTrackMetadata(track),
                itemType = itemType.track,
                id = String.Format("Trk/{0}", track.Key),
                title = track.Name,
                mimeType = String.Format("audio/{0}", track.Container.ToLower())
            };
        }

        private httpHeader[] GeneratePlexHeaders()
        {
            var list = new List<httpHeader>();
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_PLATFORM, value = "Sonos" });
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_PLATFORM_VERSION, value = WebOperationContext.Current.IncomingRequest.Headers["USER-AGENT"].Split('(')[0].Trim() });
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_PROVIDES, value = "player" });
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_PRODUCT, value = "Plex2Sonos" });
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_VERSION, value = "0.0.0.1" });
            list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_DEVICE, value = String.Format("{0} via ({1}", System.Environment.MachineName, WebOperationContext.Current.IncomingRequest.Headers["USER-AGENT"].Split('(')[1]) });

            using (var credHeader = OperationContext.Current.RequestContext.RequestMessage.Headers.GetReaderAtHeader(0).ReadSubtree())
            {
                credHeader.ReadStartElement();
                list.Add(new httpHeader() { header = PlexHeaders.X_PLEX_CLIENT_IDENTIFIER, value = credHeader.ReadInnerXml() });
                credHeader.Close();
            }

            return list.ToArray();
        }
    }
}
