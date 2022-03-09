#region

using System.Security.Cryptography;
using System.Text;

#endregion

namespace 实验08_加密适配器模式 {
    internal class Cipher : ICipher {
        public string Encrypt(string text) {
            var buffer = Encoding.UTF8.GetBytes(text);
            var data = SHA1.Create().ComputeHash(buffer);

            var sb = new StringBuilder();
            foreach (var t in data) {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}