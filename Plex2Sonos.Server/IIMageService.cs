using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Server
{
    [ServiceContract]
    public interface IImageService
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "GetImage?image={image}")]
        Stream GetImage(string image);
    }
}
