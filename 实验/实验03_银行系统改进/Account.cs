using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进
{
    class Account:IValidatable
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        public Account(string id, string password, double balance)
        {
            if (balance < 0) throw new Exception("balance less than zero when creating account");

            Id = id;
            Password = password;
            Balance = balance;
        }

        public bool SaveMoney(double amount)
        {
            if (amount < 0) return false;
            Balance += amount;

            return true;
        }

        public virtual bool WithdrawMoney(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;

                return true;
            }

            return false;
        }

        public bool Validate(string id, string password)
        {
            return id == Id && password == Password;
        }
    }
}