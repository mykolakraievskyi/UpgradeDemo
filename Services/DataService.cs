using System.IO;
using System.Text.Json;
using System.Threading;

namespace UpgradeDemo.Services
{
    public class DataService
    {
        public void PersistSnapshot(object obj, Stream stream)
        {
            JsonSerializer.Serialize(stream, obj, obj.GetType());
        }

        public void AbortBackgroundSync()
        {
            var worker = new Thread(() => { });
            worker.Start();
            worker.Abort();
        }
    }
}
