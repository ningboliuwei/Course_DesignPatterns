using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Account account = new Account("张三丰", 0);
            Console.WriteLine("开户成功。姓名：" + account.GetOwner() + " 初始金额：" + account.GetBalance());
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Withdraw(2200);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Withdraw(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Withdraw(200);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Withdraw(1800);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");


            account.Withdraw(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Deposit(1800);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            account.Deposit(100);
            account.ComputeInterest();
            Console.WriteLine("---------------------------------------");

            Console.ReadLine();
        }
    }
}