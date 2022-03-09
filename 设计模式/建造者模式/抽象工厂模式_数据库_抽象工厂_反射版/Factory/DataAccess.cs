#region

using System.Configuration;
using System.Reflection;

#endregion

namespace 抽象工厂模式_数据库_抽象工厂_反射版 {
    internal class DataAccess {
        private static readonly string AssemblyName = "抽象工厂模式_数据库_抽象工厂_反射版";

        //private static readonly string db = "Access";
        //private static readonly string db = "Sqlserver";
        private static readonly string db = ConfigurationManager.AppSettings["db"]; //注意要在引用中添加System.configuration.dll

        public static IDepartment CreateDepartment() {
            var className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        //private string classname = "AccessUser";
        //IUser user = new classname();
        //IUser user2 = new SqlserverUser();

        public static IUser CreateUser() {
            IUser user;
            var className = AssemblyName + "." + db + "User";
            user = (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
            return user;
        }
    }
}