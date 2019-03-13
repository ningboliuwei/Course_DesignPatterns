using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

           bank.OpenAccount("2222", "2222", 20);
           bank.OpenAccount("3333", "3333", 50);
           bank.OpenCreditCardAccount("4444", "4444", 20000);

            ATM atm = new ATM(bank);

            for (int i = 0; i < 3; i++)
            {
                atm.Transaction();
            }

            App app=new App();
            for (int i = 0; i < 2; i++)
            {
                app.Register();
                app.Login();
            }

            Console.ReadLine();
        }
    }
}
