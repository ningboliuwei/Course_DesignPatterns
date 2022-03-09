namespace 实验03_银行系统改进 {
    internal class CreditCardAccount : Account {
        public CreditCardAccount(string id, string password, double limit) : base(id, password, 0) {
            Id = id;
            Password = password;
            Limit = limit;
            Credit = 0;
        }

        public long Credit { get; set; }

        public double Limit { get; set; }

        public bool AddCredit(long amount) {
            if (amount < 0) {
                return false;
            }

            Credit += amount;
            return true;
        }

        public bool ReduceCredit(long amount) {
            if (Credit - amount < 0) {
                return false;
            }

            Credit -= amount;
            return true;
        }

        public override bool WithdrawMoney(double amount) {
            if (Balance - amount < -Limit) {
                return false;
            }

            Balance -= amount;
            return true;
        }
    }
}