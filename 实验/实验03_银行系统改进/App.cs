using System;
using System.Collections.Generic;

namespace 实验03_银行系统改进
{
    internal class App
    {
        public List<User> users = new List<User>();

        public void Register()
        {
            Show("-----注册新用户-----");
            Show("请输入真名：");
            var realName = GetInput();
            Show("请输入 PIN 码：");
            var pin = GetInput();

            var user = new User(realName, pin);
            users.Add(user);
        }

        public void Login()
        {
            Show("-----用户登录-----");
            Show("请输入真名：");
            var realName = GetInput();
            Show("请输入 PIN 码：");
            var pin = GetInput();

            foreach (var user in users)
                if (user.RealName == realName && user.PIN == pin)
                {
                    Show("登录成功");
                    return;
                }

            Console.WriteLine("登录失败");
        }

        private void Show(string message)
        {
            Console.WriteLine(message);
        }

        private string GetInput()
        {
            return Console.ReadLine();
        }
    }
}