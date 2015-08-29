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
    public partial class mediaMetadata : AbstractMedia
    {

        private string mimeTypeField;

        private trackMetadata itemField;

        private property[] dynamicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string mimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public trackMetadata Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public property[] dynamic
        {
            get
            {
                return this.dynamicField;
            }
            set
            {
                this.dynamicField = value;
            }
        }
    }
}
