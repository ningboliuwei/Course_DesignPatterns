using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    internal class RestrictedState : AccountState
    {
        public RestrictedState(Account account)
        {
            _account = account;
        }

        public override void Deposit(double amount)
        {
            _account.SetBalance(_account.GetBalance() + amount);
            Console.WriteLine("向名为{0}的账户中存款{1}元，存款后账户余额为{2}元。", _account.GetOwner(), amount, _account.GetBalance());
            StateCheck();
        }

        //取款
        public override void Withdraw(double amount)
        {
            Console.WriteLine("已达到最大透支金额，不允许取款。");
            StateCheck();
        }


        //计算利息
        public override void ComputeInterest()
        {
            Console.WriteLine("开始计算利息");
        }

        //检查账户状态
        public override void StateCheck()
        {
            double currentBalance = _account.GetBalance();

            if (currentBalance > -2000 && currentBalance < 0)
            {
                _account.SetState(new OverdraftState(_account));
            }
            else if (currentBalance >= 0)
            {
                _account.SetState(new NormalState(_account));
            }
        }
    }
}