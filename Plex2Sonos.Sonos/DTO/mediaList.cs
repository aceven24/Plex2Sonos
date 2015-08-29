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
    public partial class mediaList
    {

        private int indexField;

        private int countField;

        private int totalField;

        private AbstractMedia[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public int index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public int count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public int total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("mediaCollection", typeof(mediaCollection), Order = 3)]
        [System.Xml.Serialization.XmlElement("mediaMetadata", typeof(mediaMetadata), Order = 3)]
        public AbstractMedia[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
