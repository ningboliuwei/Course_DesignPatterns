using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验09_加密策略模式
{
    interface ICipher
    {
        string GetEncryptedText(string text);
    }
}
