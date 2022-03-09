#region

using System;

#endregion

namespace 抽象工厂模式_数据库_抽象工厂_反射版 {
    internal class Program {
        private static void Main(string[] args) {
            var user = new User();
            var dept = new Department();

            var iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            var idept = DataAccess.CreateDepartment();
            idept.Insert(dept);
            idept.GetDepartment(1);

            Console.ReadLine();
        }
    }
}