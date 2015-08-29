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
    public partial class extendedMetadata
    {

        private AbstractMedia itemField;

        private relatedBrowse[] relatedBrowseField;

        private relatedText[] relatedTextField;

        private relatedPlay relatedPlayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("mediaCollection", typeof(mediaCollection), Order = 0)]
        [System.Xml.Serialization.XmlElement("mediaMetadata", typeof(mediaMetadata), Order = 0)]
        public AbstractMedia Item
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
        [System.Xml.Serialization.XmlElement("relatedBrowse", Order = 1)]
        public relatedBrowse[] relatedBrowse
        {
            get
            {
                return this.relatedBrowseField;
            }
            set
            {
                this.relatedBrowseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("relatedText", Order = 2)]
        public relatedText[] relatedText
        {
            get
            {
                return this.relatedTextField;
            }
            set
            {
                this.relatedTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public relatedPlay relatedPlay
        {
            get
            {
                return this.relatedPlayField;
            }
            set
            {
                this.relatedPlayField = value;
            }
        }
    }
}
