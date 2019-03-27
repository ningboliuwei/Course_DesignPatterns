using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验05_数据库抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要连接的数据库类型（Oracle/MySql）：");
            var dbType = Console.ReadLine();
            Console.WriteLine("请输入数据库连接字符串（如：10.22.149.105;user=a;pwd=1）");
            var connectionString = Console.ReadLine();
            Console.WriteLine("请输入要执行的 SQL 语句（如：SELECT * FROM Users）");
            var commandText = Console.ReadLine();

            var connection = DbFactory.CreateConnection(dbType);
            connection.ConnectionString = connectionString;

            var command = DbFactory.CreateCommand(dbType);
            command.CommandText = commandText;
            command.Connection = connection;

            Console.WriteLine();
            connection.Open();
            command.Execute();
            connection.Close();

            Console.ReadKey();
        }

    }
}
