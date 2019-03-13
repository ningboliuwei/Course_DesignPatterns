using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进
{
    class Bank
    {
        List<Account> accounts = new List<Account>();

        public Account OpenAccount(string id, string password, double balance)
        {
            Account account = new Account(id, password, balance);
            accounts.Add(account);

            return account;
        }

        public Account OpenCreditCardAccount(string id, string password, double limit)
        {
            CreditCardAccount creditCardAccount = new CreditCardAccount(id, password, limit);
            accounts.Add(creditCardAccount);

            return creditCardAccount;
        }

        public Account FindAccount(string id)
        {
            foreach (Account account in accounts)
            {
                if (account.Id == id)
                {
                    return account;
                }
            }

            return null;
        }
    }
}