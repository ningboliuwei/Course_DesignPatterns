#region

using System.Security.Cryptography;
using System.Text;

#endregion

namespace 实验09_加密策略模式 {
    internal class SHACipher : ICipher {
        public string GetEncryptedText(string text) {
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