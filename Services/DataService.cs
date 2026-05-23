using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace UpgradeDemo.Services
{
    public class DataService
    {
        public void PersistSnapshot(object obj, Stream stream)
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
        }

        public void AbortBackgroundSync()
        {
            var worker = new Thread(() => { });
            worker.Start();
            worker.Abort();
        }
    }
}
