namespace 策略模式_计算器_满送_工厂 {
    internal class CaculatorNormal : Caculator {
        public override double CaculatePrice(double originalPrice) {
            return originalPrice;
        }
    }
}