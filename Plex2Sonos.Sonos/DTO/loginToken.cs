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
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sonos.com/Services/1.1")]
    public partial class loginToken
    {

        private string tokenField;

        private string keyField;

        private string householdIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string householdId
        {
            get
            {
                return this.householdIdField;
            }
            set
            {
                this.householdIdField = value;
            }
        }
    }
}
