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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.sonos.com/Services/1.1")]
    public partial class lastUpdate
    {

        private string catalogField;

        private string favoritesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string catalog
        {
            get
            {
                return this.catalogField;
            }
            set
            {
                this.catalogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string favorites
        {
            get
            {
                return this.favoritesField;
            }
            set
            {
                this.favoritesField = value;
            }
        }
    }

}
