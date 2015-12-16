using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
    abstract class AccountState
    {
        protected Account Account;
        //存款
        public abstract void Deposit(double amount);

        //取款
        public abstract void Withdraw(double amount);

        //检查账户状态
        public abstract void StateCheck();
    }
}