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
    public partial class relatedPlay
    {

        private string idField;

        private itemType itemTypeField;

        private string titleField;

        private bool canPlayField;

        private bool canPlayFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public itemType itemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public bool canPlay
        {
            get
            {
                return this.canPlayField;
            }
            set
            {
                this.canPlayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canPlaySpecified
        {
            get
            {
                return this.canPlayFieldSpecified;
            }
            set
            {
                this.canPlayFieldSpecified = value;
            }
        }
    }
}
