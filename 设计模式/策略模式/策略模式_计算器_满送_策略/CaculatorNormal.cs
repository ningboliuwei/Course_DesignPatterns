namespace 策略模式_计算器_满送_策略 {
    internal class CaculatorNormal : ICaculator {
        public override double CaculatePrice(double originalPrice) {
            return originalPrice;
        }
    }
}