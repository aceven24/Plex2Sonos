using Plex2Sonos.Sonos.DTO;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Plex2Sonos.Sonos
{
    [ServiceContract(Namespace = "http://www.sonos.com/Services/1.1")]
    public interface ISonosSoap
    {
        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getMetadata")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getMetadata", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getMetadataResponse GetMetadata(getMetadataRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getExtendedMetadata")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getExtendedMetadata", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getExtendedMetadataResponse GetExtendedMetadata(getExtendedMetadataRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getExtendedMetadataText")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getExtendedMetadataText", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getExtendedMetadataTextResponse GetExtendedMetadataText(getExtendedMetadataTextRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#search")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#search", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        searchResponse Search(searchRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getMediaMetadata")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getMediaMetadata", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getMediaMetadataResponse GetMediaMetadata(getMediaMetadataRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getMediaURI")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getMediaURI", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getMediaURIResponse GetMediaUri(getMediaURIRequest request);

        [OperationContract(Action = "http://www.sonos.com/Services/1.1#getLastUpdate")]
        [FaultContract(typeof(int), Action = "http://www.sonos.com/Services/1.1#getLastUpdate", Name = "SonosError")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(AbstractMedia))]
        getLastUpdateResponse GetLastUpdate(getLastUpdateRequest request);
    }
}
