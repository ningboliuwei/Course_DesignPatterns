using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("张三丰", 0);

            account.Deposit(100);
            account.Withdraw(100);
            account.Withdraw(200);
            account.Withdraw(1800);
            account.Withdraw(100);
            account.Deposit(100);
            account.Deposit(1800);
            account.Deposit(100);
            account.Deposit(100);

            Console.ReadLine();
        }
    }
}
