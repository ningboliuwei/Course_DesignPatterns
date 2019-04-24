using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验09_加密策略模式
{
    class CipherContext
    {
        private ICipher _cipher;

        public CipherContext(ICipher cipher)
        {
            _cipher = cipher;
        }

        public string Encrypt(string text)
        {
            return _cipher.GetEncryptedText(text);
        }
    }
}
