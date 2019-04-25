using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验09_加密策略模式
{
    class CipherContext
    {
        public ICipher Cipher { get; set; }

        public string Encrypt(string text)
        {
            if (Cipher != null)
                return Cipher.GetEncryptedText(text);
            return "";
        }
    }
}