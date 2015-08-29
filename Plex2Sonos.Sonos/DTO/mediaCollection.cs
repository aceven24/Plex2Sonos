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
    public partial class mediaCollection : AbstractMedia
    {

        private string artistField;

        private string artistIdField;

        private bool canScrollField;

        private bool canScrollFieldSpecified;

        private bool canPlayField;

        private bool canPlayFieldSpecified;

        private bool canEnumerateField;

        private bool canEnumerateFieldSpecified;

        private bool canAddToFavoritesField;

        private bool canAddToFavoritesFieldSpecified;

        private bool containsFavoriteField;

        private bool containsFavoriteFieldSpecified;

        private bool canCacheField;

        private bool canCacheFieldSpecified;

        private bool canSkipField;

        private bool canSkipFieldSpecified;

        private albumArtUrl albumArtURIField;

        private bool authRequiredField;

        private bool authRequiredFieldSpecified;

        private bool homogeneousField;

        private bool homogeneousFieldSpecified;

        private bool canAddToFavoriteField;

        private bool canAddToFavoriteFieldSpecified;

        private bool readOnlyField;

        private bool userContentField;

        private bool renameableField;

        public mediaCollection()
        {
            this.readOnlyField = true;
            this.userContentField = false;
            this.renameableField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string artist
        {
            get
            {
                return this.artistField;
            }
            set
            {
                this.artistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string artistId
        {
            get
            {
                return this.artistIdField;
            }
            set
            {
                this.artistIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public bool canScroll
        {
            get
            {
                return this.canScrollField;
            }
            set
            {
                this.canScrollField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canScrollSpecified
        {
            get
            {
                return this.canScrollFieldSpecified;
            }
            set
            {
                this.canScrollFieldSpecified = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public bool canEnumerate
        {
            get
            {
                return this.canEnumerateField;
            }
            set
            {
                this.canEnumerateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canEnumerateSpecified
        {
            get
            {
                return this.canEnumerateFieldSpecified;
            }
            set
            {
                this.canEnumerateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public bool canAddToFavorites
        {
            get
            {
                return this.canAddToFavoritesField;
            }
            set
            {
                this.canAddToFavoritesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canAddToFavoritesSpecified
        {
            get
            {
                return this.canAddToFavoritesFieldSpecified;
            }
            set
            {
                this.canAddToFavoritesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public bool containsFavorite
        {
            get
            {
                return this.containsFavoriteField;
            }
            set
            {
                this.containsFavoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool containsFavoriteSpecified
        {
            get
            {
                return this.containsFavoriteFieldSpecified;
            }
            set
            {
                this.containsFavoriteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        public bool canCache
        {
            get
            {
                return this.canCacheField;
            }
            set
            {
                this.canCacheField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canCacheSpecified
        {
            get
            {
                return this.canCacheFieldSpecified;
            }
            set
            {
                this.canCacheFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        public bool canSkip
        {
            get
            {
                return this.canSkipField;
            }
            set
            {
                this.canSkipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canSkipSpecified
        {
            get
            {
                return this.canSkipFieldSpecified;
            }
            set
            {
                this.canSkipFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 9)]
        public albumArtUrl albumArtURI
        {
            get
            {
                return this.albumArtURIField;
            }
            set
            {
                this.albumArtURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 10)]
        public bool authRequired
        {
            get
            {
                return this.authRequiredField;
            }
            set
            {
                this.authRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool authRequiredSpecified
        {
            get
            {
                return this.authRequiredFieldSpecified;
            }
            set
            {
                this.authRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 11)]
        public bool homogeneous
        {
            get
            {
                return this.homogeneousField;
            }
            set
            {
                this.homogeneousField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool homogeneousSpecified
        {
            get
            {
                return this.homogeneousFieldSpecified;
            }
            set
            {
                this.homogeneousFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 12)]
        public bool canAddToFavorite
        {
            get
            {
                return this.canAddToFavoriteField;
            }
            set
            {
                this.canAddToFavoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool canAddToFavoriteSpecified
        {
            get
            {
                return this.canAddToFavoriteFieldSpecified;
            }
            set
            {
                this.canAddToFavoriteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(true)]
        public bool readOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool userContent
        {
            get
            {
                return this.userContentField;
            }
            set
            {
                this.userContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool renameable
        {
            get
            {
                return this.renameableField;
            }
            set
            {
                this.renameableField = value;
            }
        }
    }
}
