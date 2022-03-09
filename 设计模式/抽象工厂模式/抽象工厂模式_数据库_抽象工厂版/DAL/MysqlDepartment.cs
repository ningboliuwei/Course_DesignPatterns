#region

using System;

#endregion

namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal class MysqlDepartment : IDepartment {
        public Department GetDepartment(int id) {
            var dept = new Department();
            Console.WriteLine("在MySQL中根据ID得到Department表一条记录");
            return dept;
        }

        public void Insert(Department department) {
            Console.WriteLine("在MySQL中给Department表增加一条记录");
        }
    }
}