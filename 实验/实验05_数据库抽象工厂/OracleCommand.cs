using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验05_数据库抽象工厂
{
    class OracleCommand:DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine($"在 Oracle 数据库（连接字符串：{this.Connection.ConnectionString}）中执行 {this.CommandText} 命令");
        }
    }
}
