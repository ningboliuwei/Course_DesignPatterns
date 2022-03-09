namespace 策略模式_计算器_满送_策略 {
    internal class CaculatorContext {
        private readonly ICaculator _caculator;

        public CaculatorContext(ICaculator caculator) {
            _caculator = caculator;
        }

        public double GetPrice(double originalPrice) {
            return _caculator.CaculatePrice(originalPrice);
        }
    }
}