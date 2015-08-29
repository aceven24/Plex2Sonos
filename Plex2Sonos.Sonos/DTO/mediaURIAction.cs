using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("svcutil", "4.6.81.0")]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.sonos.com/Services/1.1")]
    public enum mediaUriAction
    {

        /// <remarks/>
        IMPLICIT,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("EXPLICIT:PLAY")]
        EXPLICITPLAY,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("EXPLICIT:SEEK")]
        EXPLICITSEEK,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("EXPLICIT:SKIP_FORWARD")]
        EXPLICITSKIP_FORWARD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("EXPLICIT:SKIP_BACK")]
        EXPLICITSKIP_BACK,
    }
}
