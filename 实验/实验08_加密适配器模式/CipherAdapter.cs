using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验08_加密适配器模式
{
    class CipherAdapter : ICipher
    {
        private NewCipher _ciper = new NewCipher();

        public string Encrypt(string text)
        {
            return _ciper.GetMD5(text);
        }
    }
}