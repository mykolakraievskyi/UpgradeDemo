using System.Security.Cryptography;

namespace UpgradeDemo.Services
{
    public class CryptoService
    {
        public byte[] GenerateToken(int length)
        {
            var buffer = new byte[length];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }

        public ICryptoTransform EncryptLegacyPayload(byte[] key, byte[] iv)
        {
            var des = DES.Create();
            return des.CreateEncryptor(key, iv);
        }

        public ICryptoTransform EncryptSensitiveRecord(byte[] key, byte[] iv)
        {
            var tdes = TripleDES.Create();
            return tdes.CreateEncryptor(key, iv);
        }

        public ICryptoTransform CreateCipher(byte[] key, byte[] iv)
        {
            var r = new RijndaelManaged();
            return r.CreateEncryptor(key, iv);
        }
    }
}
