#region

using System;

#endregion

namespace 状态模式_俱乐部 {
    internal abstract class ClubState {
        protected double _lowerLimit;

        protected double _upperLimit;

        //账户
        public ClubAccount Account { get; set; }

        //金额
        public double Balance { get; set; }

        public abstract void ClubService();

        public void Cost(double amount) {
            Balance -= amount;
            Console.WriteLine("这次消费了{0}元，你的帐户还有{1}元", amount, Balance);
            StateChangeCheck();
        }

        public void Deposit(double amount) {
            Balance += amount;
            Console.WriteLine("这次存入了{0}元，你的帐户还有{1}元", amount, Balance);
            StateChangeCheck();
        }

        protected abstract void StateChangeCheck();
    }
}