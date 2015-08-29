using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Plex2Sonos.Sonos.DTO
{
    /// <remarks/>
    [GeneratedCode("svcutil", "4.6.81.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.sonos.com/Services/1.1")]
    public partial class credentials
    {

        private string deviceIdField;

        private string deviceProviderField;

        private object itemField;

        /// <remarks/>
        [XmlElement(Order = 0)]
        public string deviceId
        {
            get
            {
                return this.deviceIdField;
            }
            set
            {
                this.deviceIdField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Order = 1)]
        public string deviceProvider
        {
            get
            {
                return this.deviceProviderField;
            }
            set
            {
                this.deviceProviderField = value;
            }
        }

        /// <remarks/>
        [XmlElement("login", typeof(login), Order = 2)]
        [XmlElement("loginToken", typeof(loginToken), Order = 2)]
        [XmlElement("sessionId", typeof(string), Order = 2)]
        public object Item
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
    }

}
