#region

using System;

#endregion

namespace 实验05_数据库抽象工厂 {
    internal class MySqlCommand : DbCommand {
        public override void Execute() {
            Console.WriteLine($"在 MySql 数据库（连接字符串：{Connection.ConnectionString}）中执行 {CommandText} 命令");
        }
    }
}