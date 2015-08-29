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
    [System.ServiceModel.MessageContract(WrapperName = "getExtendedMetadataResponse", WrapperNamespace = "http://www.sonos.com/Services/1.1", IsWrapped = true)]
    public partial class getExtendedMetadataResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://www.sonos.com/Services/1.1", Order = 0)]
        public extendedMetadata getExtendedMetadataResult;

        public getExtendedMetadataResponse()
        {
        }

        public getExtendedMetadataResponse(extendedMetadata getExtendedMetadataResult)
        {
            this.getExtendedMetadataResult = getExtendedMetadataResult;
        }
    }
}
