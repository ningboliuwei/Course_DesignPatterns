using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 实验05_数据库抽象工厂
{
    class DbFactory
    {
        private static readonly string _assemblyName = "实验05_数据库抽象工厂";

        public static DbCommand CreateCommand(string dbType)
        {
            string className = _assemblyName + "." + dbType + "Command";
            return (DbCommand) Assembly.Load(_assemblyName).CreateInstance(className);
        }

        public static DbConnection CreateConnection(string dbType)
        {
            string className = _assemblyName + "." + dbType + "Connection";
            return (DbConnection) Assembly.Load(_assemblyName).CreateInstance(className);
        }
    }
}