using ProtoBuf;
using System;
using System.Collections.Generic;

namespace Plex2Sonos.Plex
{
    [ProtoContract]
    public class Artist : MediaContainer
    {
        [ProtoMember(31)]
        public List<String> Genres { get; set; }
        [ProtoMember(32)]
        public string Country { get; set; }
        [ProtoMember(33, AsReference = true)]
        public List<Album> Albums { get; set; }

        public Artist()
        {

        }
        
        public Artist(MediaContainer parent, dynamic dynMediaContainer)
        {
            this.Parent = parent;
            this.PopulateBaseMediaContainerProperties(dynMediaContainer);
        }
    }
}
