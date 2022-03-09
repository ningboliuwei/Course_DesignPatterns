#region

using System;

#endregion

namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal class Program {
        private static void Main(string[] args) {
            var user = new User();
            var dept = new Department();

            //创建在SQL Server环境下使用的数据对象
            IFactory factory = new SqlserverFactory();
            //创建在MySQL环境下使用的数据对象
            //IFactory factory = new MysqlFactory();

            var u = factory.CreateUser();
            u.Insert(user);
            u.GetUser(1);

            // IDepartment idept = factory.CreateDepartment();
            // idept.Insert(dept);
            // idept.GetDepartment(1);

            Console.ReadLine();
        }
    }
}