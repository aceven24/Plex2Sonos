using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sonos.com/Services/1.1")]
    public partial class login
    {

        private string usernameField;

        private string passwordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
}
