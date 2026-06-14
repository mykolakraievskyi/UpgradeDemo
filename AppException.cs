using System;
using System.Runtime.Serialization;

namespace UpgradeDemo
{
    public class AppException : Exception
    {
        public AppException(string message) : base(message) { }

       
    }
}
