#region

using System;

#endregion

namespace 实验03_银行系统改进 {
    internal class Program {
        private static void Main(string[] args) {
            var bank = new Bank();

            bank.OpenAccount("2222", "2222", 20);
            bank.OpenAccount("3333", "3333", 50);
            bank.OpenCreditCardAccount("4444", "4444", 20000);

            var atm = new ATM(bank);

            for (var i = 0; i < 3; i++) {
                atm.Transaction();
            }

            var app = new App();
            for (var i = 0; i < 2; i++) {
                app.Register();
                app.Login();
            }

            Console.ReadLine();
        }
    }
}