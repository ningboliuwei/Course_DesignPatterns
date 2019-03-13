using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进原版
{
    public class Bank
    {
        //账户类型
        public enum AccountType
        {
            NormalAccount,
            CreditCardAccount
        }

        private List<Account> _accounts = new List<Account>();

        /// <summary>
        ///     索引器，通过用户名得到相应账号
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Account this[string username]
        {
            get
            {
                foreach (Account a in _accounts)
                {
                    if (a.getId() == username)
                    {
                        return a;
                    }
                }
                return null;
            }
        }


        public Account OpenAccount(string id, string pwd, AccountType accountType, double limit)
        {
            Account account = null;

            switch (accountType)
            {
                case AccountType.NormalAccount:
                    account = new Account(id, pwd);
                    break;
                case AccountType.CreditCardAccount:
                    account = new CreditCardAccount(id, pwd, limit);
                    break;
            }

            if (account != null)
            {
                _accounts.Add(account);
            }
            return account;
        }

        public bool CloseAccount(Account account)
        {
            int idx = _accounts.IndexOf(account);
            if (idx < 0) return false;
            _accounts.Remove(account);
            return true;
        }

        public Account FindAccount(string id, string pwd)
        {
            foreach (Account account in _accounts)
            {
                if (account.IsMatch(id, pwd))
                {
                    return account;
                }
            }

            return null;
        }
    }
}
