using Plex2Sonos.Plex;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Plex2Sonos.Server
{
    public class ImageProxyServer : IImageService
    {
        public Stream GetImage(string image)
        {
            var request = HttpWebRequest.Create(String.Format("http://{1}{0}",image,PlexMediaServer.Instance().PlexServerAndPort));
            var task = request.GetResponseAsync();
            task.Wait();
            return task.Result.GetResponseStream();
         
        }
    }
}
