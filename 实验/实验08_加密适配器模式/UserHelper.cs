using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验08_加密适配器模式
{
    class UserHelper
    {
        private string _password;

        public void SetPassword()
        {
            Console.Write("请输入密码：");
            _password = Console.ReadLine();
        }

        public void SaveEncryptedPassword()
        {
            ICipher cipher = new CipherAdapter();
            Console.WriteLine("已写入加密后的密码：" + cipher.Encrypt(_password));
        }
    }
}