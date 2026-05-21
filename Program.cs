using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading;

// SYSLIB0051 — obsolete exception serialization constructor pattern
public class MyException : Exception
{
    protected MyException(SerializationInfo info, StreamingContext ctx) : base(info, ctx) { }
}

class Program
{
    static void Main(string[] args)
    {
        using var stream = new MemoryStream();
        object obj = new object();

        // SYSLIB0011 — BinaryFormatter
        var bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        bf.Serialize(stream, obj);

        // SYSLIB0006 — Thread.Abort
        var t = new Thread(() => { });
        t.Abort();

        // SYSLIB0014 — WebClient
        var wc = new WebClient();
        wc.DownloadString("https://example.com");

        // SYSLIB0023 — RNGCryptoServiceProvider
        using var rng = new RNGCryptoServiceProvider();

        // SYSLIB0021 + SYSLIB0041 — DES.Create / TripleDES.Create
        var des = DES.Create();
        var triple = TripleDES.Create();

        // SYSLIB0022 — RijndaelManaged
        var r = new RijndaelManaged();

        // SYSLIB0013 — Uri.EscapeUriString
        var s = Uri.EscapeUriString("hello world");

        // SYSLIB0039 — TLS 1.0 / 1.1 SslProtocols enum values
        var protocols = SslProtocols.Tls | SslProtocols.Tls11;

        Console.WriteLine("UpgradeDemo running.");

        des.Dispose();
        triple.Dispose();
        r.Dispose();
    }
}
