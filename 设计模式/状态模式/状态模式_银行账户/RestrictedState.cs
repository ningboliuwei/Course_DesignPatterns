#region

using System;

#endregion

namespace 状态模式_银行账户 {
    internal class RestrictedState : AccountState {
        public RestrictedState(Account account) {
            Account = account;
        }

        public override void Deposit(double amount) {
            Account.Balance += amount;
            Console.WriteLine($"向名为{Account.Owner}的账户中存款{amount}元，存款后账户余额为{Account.Balance}元。");
            StateCheck();
        }

        //检查账户状态
        public override void StateCheck() {
            if (Account.Balance > -2000 && Account.Balance < 0) {
                Account.State = new OverdraftState(Account);
            }
            else if (Account.Balance >= 0) {
                Account.State = new NormalState(Account);
            }
        }

        //取款
        public override void Withdraw(double amount) {
            Console.WriteLine("已达到最大透支金额，不允许取款。");
            StateCheck();
        }
    }
}