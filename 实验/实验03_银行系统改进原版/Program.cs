using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进原版
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            //普通账户额度都为 0
            bank.OpenAccount("Jack", "123", Bank.AccountType.NormalAccount, 0);
            bank["Jack"].SaveMoney(1000);

            bank.OpenAccount("Tom", "321", Bank.AccountType.CreditCardAccount, 10000);

            bank.OpenAccount("Jane", "246", Bank.AccountType.CreditCardAccount, 5000);
            bank["Jane"].SaveMoney(2000);

            ATM atm = new ATM(bank);

            ATM.ExitType result;
            do
            {
                result = atm.Transaction();
            } while (result != ATM.ExitType.ExitByUser);

            Console.ReadLine();
        }
    }
}
