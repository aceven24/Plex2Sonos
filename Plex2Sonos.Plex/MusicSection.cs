using ProtoBuf;
using System;
using System.Collections.Generic;

namespace Plex2Sonos.Plex
{
    [ProtoContract]
    public class MusicSection : MediaContainer
    {
        [ProtoMember(21, AsReference = true)]
        public List<Artist> Artists { get; set; }
        [ProtoMember(22)]
        public int SectionID { get; set; }

        public MusicSection()
        {

        }

        public MusicSection(dynamic dynMediaContainer)
        {
            this.PopulateMediaContainerProperties(dynMediaContainer);
        }
        protected override void PopulateMediaContainerProperties(dynamic dynMediaContainer)
        {
            this.SectionID = int.Parse(dynMediaContainer.key);
            LastUpdated = DateTimeOffset.FromUnixTimeSeconds(long.Parse(dynMediaContainer.updatedAt)).DateTime;
        }
    }
}
