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
    public partial class albumArtUrl
    {

        private bool requiresAuthenticationField;

        private bool requiresAuthenticationFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public bool requiresAuthentication
        {
            get
            {
                return this.requiresAuthenticationField;
            }
            set
            {
                this.requiresAuthenticationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool requiresAuthenticationSpecified
        {
            get
            {
                return this.requiresAuthenticationFieldSpecified;
            }
            set
            {
                this.requiresAuthenticationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText(DataType = "anyURI")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
