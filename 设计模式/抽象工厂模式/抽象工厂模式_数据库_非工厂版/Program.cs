#region

using System;

#endregion

namespace 抽象工厂模式_数据库_非工厂版 {
    internal class Program {
        private static void Main(string[] args) {
            var user1 = new User();
            user1.ID = 1;
            user1.Name = "Tom";

            var user2 = new User();
            user2.ID = 2;
            user2.Name = "Jane";

            var su = new SqlserverUser();
            su.Insert(user1);
            su.Insert(user2);

            var resultUser1 = su.GetUser(1);
            var resultUser2 = su.GetUser(2);

            Console.ReadLine();
        }
    }
}