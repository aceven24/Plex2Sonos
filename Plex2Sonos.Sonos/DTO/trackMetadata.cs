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
    public partial class trackMetadata
    {

        private string artistIdField;

        private string artistField;

        private string composerIdField;

        private string composerField;

        private string albumIdField;

        private string albumField;

        private string albumArtistIdField;

        private string albumArtistField;

        private string genreIdField;

        private string genreField;

        private int durationField;

        private bool durationFieldSpecified;

        private int ratingField;

        private bool ratingFieldSpecified;

        private albumArtUrl albumArtURIField;

        private int trackNumberField;

        private bool trackNumberFieldSpecified;

        private bool canPlayField;

        private bool canPlayFieldSpecified;

        private bool canSkipField;

        private bool canSkipFieldSpecified;

        private bool canAddToFavoritesField;

        private bool canAddToFavoritesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
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
        [System.Xml.Serialization.XmlElement(Order = 1)]
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
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string composerId
        {
            get
            {
                return this.composerIdField;
            }
            set
            {
                this.composerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string composer
        {
            get
            {
                return this.composerField;
            }
            set
            {
                this.composerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string albumId
        {
            get
            {
                return this.albumIdField;
            }
            set
            {
                this.albumIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string album
        {
            get
            {
                return this.albumField;
            }
            set
            {
                this.albumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string albumArtistId
        {
            get
            {
                return this.albumArtistIdField;
            }
            set
            {
                this.albumArtistIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string albumArtist
        {
            get
            {
                return this.albumArtistField;
            }
            set
            {
                this.albumArtistField = value;
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
        public int duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool durationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 11)]
        public int rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool ratingSpecified
        {
            get
            {
                return this.ratingFieldSpecified;
            }
            set
            {
                this.ratingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 12)]
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
        [System.Xml.Serialization.XmlElement(Order = 13)]
        public int trackNumber
        {
            get
            {
                return this.trackNumberField;
            }
            set
            {
                this.trackNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool trackNumberSpecified
        {
            get
            {
                return this.trackNumberFieldSpecified;
            }
            set
            {
                this.trackNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 14)]
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
        [System.Xml.Serialization.XmlElement(Order = 15)]
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
        [System.Xml.Serialization.XmlElement(Order = 16)]
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
    }
}
