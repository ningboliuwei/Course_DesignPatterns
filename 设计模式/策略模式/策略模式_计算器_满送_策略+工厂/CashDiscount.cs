namespace 策略模式_计算器_满送_策略和工厂 {
    internal class CashDiscount : CashSuper {
        private readonly double moneyDiscount = 1;

        public CashDiscount(string moneyRebate) {
            moneyDiscount = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money) {
            return money * moneyDiscount;
        }
    }
}