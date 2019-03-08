using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验02_银行系统
{
    class Account
    {
        public string Id { get; }
        public string Password { get; }
        public double Balance { get; private set; }

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

        public bool WithdrawMoney(double amount)
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