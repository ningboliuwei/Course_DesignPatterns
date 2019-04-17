using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验08_加密适配器模式
{
    interface ICipher
    {
        string Encrypt(string text);
    }
}
