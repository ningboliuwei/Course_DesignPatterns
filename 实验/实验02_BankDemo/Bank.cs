#region

using System.Collections.Generic;

#endregion

namespace 实验02_BankDemo {
    internal class Bank {
        private readonly List<Account> accounts = new List<Account>();

        public bool CloseAccount(Account account) {
            var idx = accounts.IndexOf(account);

            if (idx < 0) {
                return false;
            }

            accounts.Remove(account);
            return true;
        }

        public Account FindAccount(string id, string pwd) {
            foreach (var account in accounts) {
                if (account.IsMatch(id, pwd)) {
                    return account;
                }
            }

            return null;
        }

        public Account OpenAccount(string id, string pwd,
            double money) {
            var account = new Account(id, pwd, money);
            accounts.Add(account);
            return account;
        }
    }
}