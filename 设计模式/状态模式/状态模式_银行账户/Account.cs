using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    internal class Account
    {
        private AccountState _state;
        private double _balance = 0; 

        public string Owner { get; }

        public double Balance { get;}



        public Account(string owner, double initialAmount)
        {
            Owner = owner;
            Balance = initialAmount;

            _state = new NormalState(this); //设置初始状态
        }


        public void SetBalance(double amount)
        {
            _balance = amount;
        }

        public void SetState(AccountState state)
        {
            _state = state;
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);

            Console.WriteLine("现在账户状态为{0}", _state.ToString());
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);

            Console.WriteLine("现在账户状态为{0}", _state.ToString());
        }

        public void ComputeInterest()
        {
            _state.ComputeInterest();
        }
    }
}