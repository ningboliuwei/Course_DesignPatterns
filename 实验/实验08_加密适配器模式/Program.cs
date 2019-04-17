using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验08_加密适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var userHelper = new UserHelper();
            userHelper.SetPassword();
            userHelper.SaveEncryptedPassword();

            Console.ReadKey();
        }
    }
}
