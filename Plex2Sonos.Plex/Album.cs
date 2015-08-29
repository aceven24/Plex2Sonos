using System.Collections.Generic;
using ProtoBuf;

namespace Plex2Sonos.Plex
{
    [ProtoContract]
    public class Album : MediaContainer
    {
        [ProtoMember(41)]
        public int? Year { get; set; }
        [ProtoMember(42, AsReference = true)]
        public List<Track> Tracks { get; set; }
        public Album()
        {
        }
        public Album(MediaContainer parent, dynamic dynMediaContainer)
        {
            this.Parent = parent;
            this.PopulateMediaContainerProperties(dynMediaContainer);
            this.PopulateBaseMediaContainerProperties(dynMediaContainer);
        }
        protected override void PopulateMediaContainerProperties(dynamic dynMediaContainer)
        {
            this.Year = AttemptDynamicPropertyExtract<int?>(() => { return dynMediaContainer.year; }, () => { return null; });
        }
    }
}