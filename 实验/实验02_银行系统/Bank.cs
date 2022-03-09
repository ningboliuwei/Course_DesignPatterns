#region

using System.Collections.Generic;

#endregion

namespace 实验02_银行系统 {
    internal class Bank {
        private readonly List<Account> accounts = new List<Account>();

        public Account FindAccount(string id) {
            foreach (var account in accounts) {
                if (account.Id == id) {
                    return account;
                }
            }

            return null;
        }

        public Account OpenAccount(string id, string password, double balance) {
            var account = new Account(id, password, balance);
            accounts.Add(account);

            return account;
        }
    }
}