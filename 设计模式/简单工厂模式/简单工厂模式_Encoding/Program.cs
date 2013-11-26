using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding asciiEncoding = Encoding.GetEncoding("ASCII");
            Encoding ec = ASCIIEncoding.GetEncoding("sxx");


        }
    }
}
