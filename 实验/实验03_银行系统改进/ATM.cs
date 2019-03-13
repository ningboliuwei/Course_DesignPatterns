using System;

namespace 实验03_银行系统改进
{
    class ATM
    {
        private readonly Bank bank;

        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public void Transaction()
        {
            Show("请输入卡号");

            var id = GetInput();

            Show("请输入密码");

            var password = GetInput();
            var account = bank.FindAccount(id);

            if (account == null || !account.Validate(id, password))
            {
                Show("无效的卡号或密码");
                return;
            }

            Show("1. 查询金额; 2. 存款; 3. 取款");
            var op = GetInput();

            if (op == "1")
            {
                Show("当前金额: " + account.Balance);
            }
            else if (op == "2")
            {
                Show("输入要存入的金额");

                var amountString = GetInput();
                var amount = double.Parse(amountString);
                var ok = account.SaveMoney(amount);

                if (ok) Show("存款成功");
                else Show("存款错误");

                Show("当前金额: " + account.Balance);
            }
            else if (op == "3")
            {
                Show("输入要取出的金额");

                var amountString = GetInput();
                var amount = double.Parse(amountString);
                var ok = account.WithdrawMoney(amount);

                if (ok) Show("取款成功");
                else Show("取款错误");

                Show("当前金额: " + account.Balance);
            }
        }

        private void Show(string message)
        {
            Console.WriteLine(message);
        }

        private string GetInput()
        {
            return Console.ReadLine();
        }
    }
}