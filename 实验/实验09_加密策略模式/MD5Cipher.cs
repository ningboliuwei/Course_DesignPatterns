#region

using System;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace 实验09_加密策略模式 {
    internal class MD5Cipher : ICipher {
        public string GetEncryptedText(string text) {
            var md5 = new MD5CryptoServiceProvider();
            var s = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(text)), 4, 8);
            s = s.Replace("-", "");

            return s;
        }
    }
}