#region

using System;

#endregion

namespace 实验05_数据库抽象工厂 {
    internal class MySqlConnection : DbConnection {
        public override void Close() {
            Console.WriteLine($"关闭 MySQL 数据库连接（连接字符串：{ConnectionString}）");
        }

        public override void Open() {
            Console.WriteLine($"打开 MySQL 数据库连接（连接字符串：{ConnectionString}）");
        }
    }
}