#region

using System;

#endregion

namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal class MysqlUser : IUser {
        public User GetUser(int id) {
            var user = new User();
            Console.WriteLine("在MySQL中根据ID得到User表一条记录");
            return user;
        }

        public void Insert(User user) {
            Console.WriteLine("在MySQL中给User表增加一条记录");
        }
    }
}