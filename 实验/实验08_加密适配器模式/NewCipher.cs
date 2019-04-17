using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 实验08_加密适配器模式
{
    public class NewCipher
    {
        public string GetMD5(string text)
        {
            var md5 = new MD5CryptoServiceProvider();
            var s = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(text)), 4, 8);
            s = s.Replace("-", "");
            return s;
        }
    }
}
