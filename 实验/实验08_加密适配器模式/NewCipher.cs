#region

using System;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace 实验08_加密适配器模式 {
    public class NewCipher {
        public string GetMD5(string text) {
            var md5 = new MD5CryptoServiceProvider();
            var s = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(text)), 4, 8);
            s = s.Replace("-", "");
            return s;
        }
    }
}