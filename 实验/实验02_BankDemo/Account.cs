#region

using System;

#endregion

namespace 实验02_BankDemo {
    internal class Account {
        private string id;
        private double money; //decimal money;
        private string pwd;

        //string name;
        public Account(string id, string pwd, double money) {
            if (money < 0) {
                throw new Exception("money less than zero when creating account");
            }

            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }

        public string getId() {
            return id;
        }

        public double getMoney() {
            return money;
        }

        public string getpwd() {
            return pwd;
        }

        public bool IsMatch(string id, string pwd) {
            return id == this.id && pwd == this.pwd;
        }

        public bool SaveMoney(double money) {
            if (money < 0) {
                return false; //卫语句
            }

            this.money += money;
            return true;
        }

        public void setId(string id) {
            this.id = id;
        }

        public void setMoney(double val) {
            money = val;
        }

        public void setPwd(string pwd) {
            this.pwd = pwd;
        }

        public bool WithdrawMoney(double money) {
            if (this.money >= money) {
                this.money -= money;

                return true;
            }

            return false;
        }
    }
}