using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContract(WrapperName = "getMediaURI", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getMediaURIRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://www.sonos.com/Services/1.1")]
        public credentials credentials;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 0)]
        public string id;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 1)]
        public mediaUriAction action;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 2)]
        public int secondsSinceExplicit;

        public getMediaURIRequest()
        {
        }

        public getMediaURIRequest(credentials credentials, string id, mediaUriAction action, int secondsSinceExplicit)
        {
            this.credentials = credentials;
            this.id = id;
            this.action = action;
            this.secondsSinceExplicit = secondsSinceExplicit;
        }
    }
}
