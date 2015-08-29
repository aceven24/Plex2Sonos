using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Plex2Sonos.Plex
{
    [ProtoContract]
    public class Track : MediaContainer
    {
        [ProtoMember(51)]
        public int Duration { get; set; }
        [ProtoMember(52)]
        public short Bitrate { get; set; }
        [ProtoMember(53)]
        public byte AudioChannels { get; set; }
        [ProtoMember(54)]
        public string AudioCodec { get; set; }
        [ProtoMember(55)]
        public int ID { get; set; }
        [ProtoMember(56)]
        public string Container { get; set; }
        [ProtoMember(57)]
        public string StreamingKey { get; set; }
        [ProtoMember(58)]
        public long Size { get; set; }

        public Track()
        {

        }
        public Track(MediaContainer parent, dynamic dynMediaContainer)
        {
            this.Parent = parent;
            this.PopulateBaseMediaContainerProperties(dynMediaContainer);
            this.PopulateMediaContainerProperties(dynMediaContainer);
        }
        protected override void PopulateMediaContainerProperties(dynamic dynMediaContainer)
        {
            try
            {
                var mediaInfo = (dynMediaContainer._children as IEnumerable<dynamic>).First();
                this.Duration = (int)mediaInfo.duration;
                this.ID = (int)mediaInfo.id;
                var partInfo = (mediaInfo._children as IEnumerable<dynamic>).First();
                this.StreamingKey = partInfo.key;
                this.Size = partInfo.size;
                this.Bitrate = (short)mediaInfo.bitrate;
                this.Container = mediaInfo.container;
                this.AudioChannels = (byte)mediaInfo.audioChannels;
                this.AudioCodec = mediaInfo.audioCodec;
            }
            catch(Exception ex)
            {
                Console.WriteLine(String.Format("Error Processing {0} from {1}-{2}", this.Name, this.Parent.Name, this.Parent.Parent.Name));
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
