using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验05_数据库抽象工厂
{
    class MySqlConnection:DbConnection
    {
        public override void Open()
        {
            Console.WriteLine($"打开 MySQL 数据库连接（连接字符串：{this.ConnectionString}）");
        }

        public override void Close()
        {
            Console.WriteLine($"关闭 MySQL 数据库连接（连接字符串：{this.ConnectionString}）");
        }
    }
}
