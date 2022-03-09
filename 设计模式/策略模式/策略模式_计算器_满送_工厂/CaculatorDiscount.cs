namespace 策略模式_计算器_满送_工厂 {
    internal class CaculatorDiscount : Caculator {
        private readonly double _discount;

        public CaculatorDiscount(double discount) {
            _discount = discount;
        }

        public override double CaculatePrice(double originalPrice) {
            return originalPrice * _discount;
        }
    }
}