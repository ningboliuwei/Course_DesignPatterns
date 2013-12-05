using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_银行账户
{
     abstract class AccountState
     {
         protected Account m_account;
         //存款
         public abstract void Deposit(double amount);
         
         //取款
         public abstract void Withdraw(double amount);

         
         //计算利息
         public abstract void ComputeInterest();
         
         //检查账户状态
         public abstract void StateCheck();

     }
}
