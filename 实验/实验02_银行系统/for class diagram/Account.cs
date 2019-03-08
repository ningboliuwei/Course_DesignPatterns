using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验02_银行系统
{
    class Account
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        public Account(string id, string password, double money)
        {
            if (money < 0) throw new Exception("balance less than zero when creating account");

            Id = id;
            Password = password;
            Balance = money;
        }

        public bool SaveMoney(double amount)
        {
            if (amount < 0) return false; //卫语句
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