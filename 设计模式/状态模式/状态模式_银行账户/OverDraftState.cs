using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    internal class OverdraftState : AccountState
    {
        public OverdraftState(Account account)
        {
            m_account = account;
        }

        public override void Deposit(double amount)
        {
            m_account.SetBalance(m_account.GetBalance() + amount);
            Console.WriteLine("向名为{0}的账户中存款{1}元，存款后账户余额为{2}元。", m_account.GetOwner(), amount, m_account.GetBalance());
            StateCheck();
        }

        //取款
        public override void Withdraw(double amount)
        {
            double newBalance = m_account.GetBalance() - amount;

            if (newBalance >= -2000)
            {
                m_account.SetBalance(newBalance);
                Console.WriteLine("从名为{0}的账户中取款{1}元，取款后账户余额为{2}元。", m_account.GetOwner(), amount, m_account.GetBalance());
            }
            else
            {
                Console.WriteLine("最大透支金额不能超过2000元。");
            }

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
            double currentBalance = m_account.GetBalance();

            if (currentBalance >= 0)
            {
                m_account.SetState(new NormalState(m_account));
            }
            else if (currentBalance <= -2000)
            {
                m_account.SetState(new RestrictedState(m_account));
            }
        }
    }
}