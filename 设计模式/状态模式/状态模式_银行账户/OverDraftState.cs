using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    class OverdraftState : AccountState
    {
        public OverdraftState(Account account)
        {
            Account = account;
        }

        public override void Deposit(double amount)
        {
            Account.Balance += amount;
            Console.WriteLine($"向名为{Account.Owner}的账户中存款{amount}元，存款后账户余额为{Account.Balance}元。");
            StateCheck();
        }

        //取款
        public override void Withdraw(double amount)
        {
            double newBalance = Account.Balance - amount * 1.01;

            if (newBalance >= -2000)
            {
                Account.Balance = newBalance;
                Console.WriteLine($"从名为{Account.Owner}的账户中取款{amount}元，并扣除 1% 的利息，取款后账户余额为{Account.Balance}元。");
            }
            else
            {
                Console.WriteLine("最大透支金额不能超过2000元。");
            }

            StateCheck();
        }


        //检查账户状态
        public override void StateCheck()
        {
            if (Account.Balance >= 0)
            {
                Account.State = new NormalState(Account);
            }
            else if (Account.Balance <= -2000)
            {
                Account.State = new RestrictedState(Account);
            }
        }
    }
}