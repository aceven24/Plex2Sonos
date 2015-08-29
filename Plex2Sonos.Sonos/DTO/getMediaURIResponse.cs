using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContract(WrapperName = "getMediaURIResponse", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getMediaURIResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 0)]
        [System.Xml.Serialization.XmlElement(DataType = "anyURI")]
        public string getMediaURIResult;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 1)]
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public httpHeader[] httpHeaders;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 2)]
        public int uriTimeout;

        public getMediaURIResponse()
        {
        }

        public getMediaURIResponse(string getMediaURIResult, httpHeader[] httpHeaders, int uriTimeout)
        {
            this.getMediaURIResult = getMediaURIResult;
            this.httpHeaders = httpHeaders;
            this.uriTimeout = uriTimeout;
        }
    }
}
