#region

using System;

#endregion

namespace 策略模式_计算器_满送_策略和工厂 {
    internal class CashReturn : CashSuper {
        private readonly double moneyCondition;

        private readonly double moneyReturn;

        public CashReturn(string moneyCondition, string moneyReturn) {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money) {
            var result = money;
            if (money >= moneyCondition) {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }

            return result;
        }
    }
}