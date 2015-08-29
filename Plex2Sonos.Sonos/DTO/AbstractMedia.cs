using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(mediaMetadata))]
    [System.Xml.Serialization.XmlInclude(typeof(mediaCollection))]
    [System.CodeDom.Compiler.GeneratedCode("svcutil", "4.6.81.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.sonos.com/Services/1.1")]
    public abstract partial class AbstractMedia
    {

        private string idField;

        private itemType itemTypeField;

        private string displayTypeField;

        private string titleField;

        private string summaryField;

        private bool isFavoriteField;

        private bool isFavoriteFieldSpecified;

        private string languageField;

        private string countryField;

        private string genreIdField;

        private string genreField;

        private string twitterIdField;

        private bool liveNowField;

        private bool liveNowFieldSpecified;

        private bool onDemandField;

        private bool onDemandFieldSpecified;

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
        public string displayType
        {
            get
            {
                return this.displayTypeField;
            }
            set
            {
                this.displayTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
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
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public bool isFavorite
        {
            get
            {
                return this.isFavoriteField;
            }
            set
            {
                this.isFavoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool isFavoriteSpecified
        {
            get
            {
                return this.isFavoriteFieldSpecified;
            }
            set
            {
                this.isFavoriteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        public string genreId
        {
            get
            {
                return this.genreIdField;
            }
            set
            {
                this.genreIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 9)]
        public string genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 10)]
        public string twitterId
        {
            get
            {
                return this.twitterIdField;
            }
            set
            {
                this.twitterIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 11)]
        public bool liveNow
        {
            get
            {
                return this.liveNowField;
            }
            set
            {
                this.liveNowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool liveNowSpecified
        {
            get
            {
                return this.liveNowFieldSpecified;
            }
            set
            {
                this.liveNowFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 12)]
        public bool onDemand
        {
            get
            {
                return this.onDemandField;
            }
            set
            {
                this.onDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool onDemandSpecified
        {
            get
            {
                return this.onDemandFieldSpecified;
            }
            set
            {
                this.onDemandFieldSpecified = value;
            }
        }
    }
}
