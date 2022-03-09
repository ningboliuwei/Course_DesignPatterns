#region

using System;

#endregion

namespace 状态模式_银行账户 {
    internal class Program {
        private static void Main(string[] args) {
            var account = new Account("张三丰", 0);
            Console.WriteLine($"开户成功。姓名：{account.Owner} 初始金额：{account.Balance}");
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            Console.WriteLine("---------------------------------------");

            account.Withdraw(2100);
            Console.WriteLine("---------------------------------------");

            account.Deposit(1000);
            Console.WriteLine("---------------------------------------");

            account.Withdraw(100);
            Console.WriteLine("---------------------------------------");

            account.Withdraw(200);
            Console.WriteLine("---------------------------------------");

            account.Withdraw(1800);
            Console.WriteLine("---------------------------------------");

            account.Withdraw(100);
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            Console.WriteLine("---------------------------------------");

            account.Deposit(1800);
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            Console.WriteLine("---------------------------------------");

            account.Deposit(696);
            Console.WriteLine("---------------------------------------");

            Console.ReadLine();
        }
    }
}