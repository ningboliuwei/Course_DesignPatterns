using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    class Account
    {
        private AccountState m_state;

        private string m_owner;

        private double m_balance;

        public Account(string owner, double initialAmount)
        {
            m_owner = owner;
            m_balance = initialAmount;

            m_state = new NormalState(this);//设置初始状态
            Console.WriteLine("开户成功。姓名：" + owner + " 初始金额：" + initialAmount);
            Console.WriteLine("---------------------------------------");
        }

        public double GetBalance()
        {
            return m_balance;
        }

        public void SetBalance(double balance)
        {
            m_balance = balance;
        }

        public void SetState(AccountState state)
        {
            m_state = state;
        }

        public void Deposit(double amount)
        {
            m_state.Deposit(amount);
            Console.WriteLine("向名为{0}的账户中存款{1}元，存款后账户余额为{2}元。",m_owner, amount, m_balance);
            Console.WriteLine("现在账户状态为{0}\n", m_state.ToString());
        }

        public void Withdraw(double amount)
        {
            m_state.Withdraw(amount);
            Console.WriteLine("从名为{0}的账户中取款{1}元，取款后账户余额为{2}元。", m_owner, amount, m_balance);
            Console.WriteLine("现在账户状态为{0}\n", m_state.ToString());
        }

        public void ComputeInterest()
        {
            m_state.ComputeInterest();
        }


    }
}
