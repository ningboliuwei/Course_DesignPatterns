namespace 简单工厂模式_两数计算_简单工厂版 {
    internal class Operation {
        public double NumberA { get; set; } = 0;

        public double NumberB {
            get;
            set;
            //
        } = 0;

        public virtual double GetResult() {
            double result = 0;
            return result;
        }
    }
}