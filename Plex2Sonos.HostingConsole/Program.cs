using Plex2Sonos.Server;
using Plex2Sonos.Sonos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Plex2Sonos.HostingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.DefaultConnectionLimit = 100;
            var ps = Plex.PlexMediaServer.Instance();
            if (File.Exists("Plex2Sonos.dat"))
            {
                ps.LoadMusicSectionDetails("Plex2Sonos.dat");
            }
            Console.WriteLine("Loading Plex Data");
            ps.GetMusicSectionDetails().Wait(); //Ick
            Console.WriteLine("Finished Loading Plex Data");
            var p2sPort = ConfigurationManager.AppSettings["Plex2SonosPort"];
            var localIP = GetLocalIPAddress();

            var sonosSoapHost = new ServiceHost(typeof(MusicProxyServer), new Uri(String.Format("http://{0}:{1}/Plex2Sonos",localIP,p2sPort)));
            sonosSoapHost.AddServiceEndpoint(typeof(ISonosSoap), new BasicHttpBinding(), "");
            sonosSoapHost.Open();

            var sonosImageHost = new ServiceHost(typeof(ImageProxyServer), new Uri(String.Format("http://{0}:{1}/ImageService", localIP, p2sPort)));
            var ep = sonosImageHost.AddServiceEndpoint(typeof(IImageService), new WebHttpBinding(WebHttpSecurityMode.None), "");
            ep.EndpointBehaviors.Add(new WebHttpBehavior());

            sonosImageHost.Open();
            Console.WriteLine("Plex2Sonos is live now at {0}", String.Format("http://{0}:{1}/Plex2Sonos", localIP, p2sPort));
            Console.WriteLine("ImageService is live now at {0}", String.Format("http://{0}:{1}/ImageService", localIP, p2sPort));
            Console.WriteLine("Press the \"Any Key\" To Close");
            Console.ReadKey();

            sonosSoapHost.Close();
            ps.SaveMusicSectionDetails("Plex2Sonos.dat");
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}
