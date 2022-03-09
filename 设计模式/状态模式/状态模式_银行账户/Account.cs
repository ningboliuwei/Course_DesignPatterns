#region

using System;

#endregion

namespace 状态模式_银行账户 {
    internal class Account {
        public Account(string owner, double initialAmount) {
            Owner = owner;
            Balance = initialAmount;
            State = new NormalState(this); //设置初始状态
        }

        public double Balance { get; set; }

        public string Owner { get; set; }
        public AccountState State { get; set; }

        public void Deposit(double amount) {
            Console.WriteLine($"现要存款{amount}元。");
            State.Deposit(amount);
            Console.WriteLine($"账户状态变为{State}");
        }

        public void SetBalance(double amount) {
            Balance = amount;
        }

        public void Withdraw(double amount) {
            Console.WriteLine($"现要取款{amount}元。");
            State.Withdraw(amount);
            Console.WriteLine($"账户状态变为{State}");
        }
    }
}