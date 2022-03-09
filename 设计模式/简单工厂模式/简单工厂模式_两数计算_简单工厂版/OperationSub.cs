namespace 简单工厂模式_两数计算_简单工厂版 {
    internal class OperationSub : Operation {
        public override double GetResult() {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}