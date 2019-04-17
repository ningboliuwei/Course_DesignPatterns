using System.Reflection;

namespace 实验05_数据库抽象工厂
{
    internal class DbFactory
    {
        private static readonly string _assemblyName = "实验05_数据库抽象工厂";

        public static DbCommand CreateCommand(string dbType)
        {
            var className = _assemblyName + "." + dbType + "Command";
            return (DbCommand) Assembly.Load(_assemblyName).CreateInstance(className);
        }

        public static DbConnection CreateConnection(string dbType)
        {
            var className = _assemblyName + "." + dbType + "Connection";
            return (DbConnection) Assembly.Load(_assemblyName).CreateInstance(className);
        }
    }
}