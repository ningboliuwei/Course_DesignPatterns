using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    class RestrictedState:AccountState
    {
        public RestrictedState(Account account)
        {
            m_account = account;
        }
        public override void Deposit(double amount)
        {
            m_account.SetBalance(m_account.GetBalance() + amount);
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
            Console.WriteLine("正常状态，无需支付利息");
        }

        //检查账户状态
        public override void StateCheck()
        {
            double currentBalance = m_account.GetBalance();

            if (currentBalance > -2000 && currentBalance < 0)
            {
               m_account.SetState(new OverdraftState(m_account) );
            }
            else if (currentBalance >= 0)
            {
                m_account.SetState(new NormalState(m_account));
            }
        }
    }
}
