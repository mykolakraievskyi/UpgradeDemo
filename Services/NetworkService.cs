using System;
using System.Net;
using System.Security.Authentication;

namespace UpgradeDemo.Services
{
    public class NetworkService
    {
        public string FetchRemoteConfig(string url)
        {
            var client = new WebClient();
            return client.DownloadString(url);
        }

        public string EncodeSearchQuery(string query)
        {
            return Uri.EscapeUriString(query);
        }

        public SslProtocols GetAllowedProtocols()
        {
            return SslProtocols.Tls | SslProtocols.Tls11;
        }
    }
}
