using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    internal class Account
    {
        private AccountState m_state;

        private string m_owner;

        private double m_balance;

        public Account(string owner, double initialAmount)
        {
            m_owner = owner;
            m_balance = initialAmount;

            m_state = new NormalState(this); //设置初始状态
        }

        public string GetOwner()
        {
            return m_owner;
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

            Console.WriteLine("现在账户状态为{0}", m_state.ToString());
        }

        public void Withdraw(double amount)
        {
            m_state.Withdraw(amount);

            Console.WriteLine("现在账户状态为{0}", m_state.ToString());
        }

        public void ComputeInterest()
        {
            m_state.ComputeInterest();
        }
    }
}