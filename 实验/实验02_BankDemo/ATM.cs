using System;

namespace 实验02_BankDemo
{
    internal class ATM
    {
        private readonly Bank bank;

        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public void Transaction()
        {
            Show("please insert your card");
            var id = GetInput();
            Show("please enter your password");
            var pwd = GetInput();
            var account = bank.FindAccount(id, pwd);

            if (account == null)
            {
                Show("card invalid or password not correct");
                return;
            }

            Show("1: display; 2: save; 3: withdraw");
            var op = GetInput();

            if (op == "1")
            {
                Show("balance: " + account.getMoney());
            }
            else if (op == "2")
            {
                Show("save money");
                var smoney = GetInput();
                var money = double.Parse(smoney);
                var ok = account.SaveMoney(money);

                if (ok)
                {
                    Show("ok");
                }
                else
                {
                    Show("error");
                }

                Show("balance: " + account.getMoney());
            }
            else if (op == "3")
            {
                Show("withdraw money");
                var smoney = GetInput();
                var money = double.Parse(smoney);
                var ok = account.WithdrawMoney(money);
                if (ok) Show("ok");
                else Show("error");
                Show("balance: " + account.getMoney());
            }
        }

        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public string GetInput()
        {
            return Console.ReadLine(); // 输入字符
        }
    }
}