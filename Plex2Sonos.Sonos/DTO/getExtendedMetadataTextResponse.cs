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
    [System.ServiceModel.MessageContract(WrapperName = "getExtendedMetadataTextResponse", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getExtendedMetadataTextResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 0)]
        public string getExtendedMetadataTextResult;

        public getExtendedMetadataTextResponse()
        {
        }

        public getExtendedMetadataTextResponse(string getExtendedMetadataTextResult)
        {
            this.getExtendedMetadataTextResult = getExtendedMetadataTextResult;
        }
    }

}
