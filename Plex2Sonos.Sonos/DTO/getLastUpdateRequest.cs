using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Sonos.DTO
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "getLastUpdate", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getLastUpdateRequest
    {

        [MessageHeader(Namespace = "http://www.sonos.com/Services/1.1")]
        public credentials credentials;

        public getLastUpdateRequest()
        {
        }

        public getLastUpdateRequest(credentials credentials)
        {
            this.credentials = credentials;
        }
    }

}
