using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "getMetadata", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getMetadataRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://www.sonos.com/Services/1.1")]
        public credentials credentials;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 0)]
        public string id;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 1)]
        public int index;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 2)]
        public int count;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 3)]
        public bool recursive;

        public getMetadataRequest()
        {
        }

        public getMetadataRequest(credentials credentials, string id, int index, int count, bool recursive)
        {
            this.credentials = credentials;
            this.id = id;
            this.index = index;
            this.count = count;
            this.recursive = recursive;
        }
    }
}
