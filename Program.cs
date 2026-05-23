using System;
using System.IO;
using UpgradeDemo.Services;

namespace UpgradeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var crypto = new CryptoService();
            var network = new NetworkService();
            var data = new DataService();

            crypto.GenerateToken(32);
            network.FetchRemoteConfig("https://example.com/config");
            network.GetAllowedProtocols();

            using var stream = new MemoryStream();
            data.PersistSnapshot(new object(), stream);
            data.AbortBackgroundSync();

            Console.WriteLine("UpgradeDemo running.");
        }
    }
}
