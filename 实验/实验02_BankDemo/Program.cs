using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验02_BankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.OpenAccount("2222", "2222", 20);
            bank.OpenAccount("3333", "3333", 50);

            ATM atm = new ATM(bank);
            
            for (int i = 0; i < 5; i++)
            {
                atm.Transaction();
            }
        }
    }
}
