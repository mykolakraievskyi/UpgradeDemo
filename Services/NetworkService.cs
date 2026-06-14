using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;

namespace UpgradeDemo.Services
{
    public class NetworkService
    {
        public string FetchRemoteConfig(string url)
            using var client = new HttpClient();
            return client.GetStringAsync(url).GetAwaiter().GetResult();
            return client.DownloadString(url);
        }

        public string EncodeSearchQuery(string query)
            // comment

            return Uri.EscapeDataString(query);

            return Uri.EscapeUriString(query);
            // Use TLS 1.2 and TLS 1.3, which are considered secure.
            return SslProtocols.Tls12 | SslProtocols.Tls13;

        public SslProtocols GetAllowedProtocols()
        {
            return SslProtocols.Tls | SslProtocols.Tls11;
        }
    }
}
