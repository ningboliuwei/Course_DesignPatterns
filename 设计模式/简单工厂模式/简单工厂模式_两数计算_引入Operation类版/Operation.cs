namespace 简单工厂模式_两数计算_引入Operation类版 {
    internal class Operation {
        public static double GetResult(double numberA, string operate, double NumberB) {
            double result = 0;

            switch (operate) {
                case "+":
                    result = numberA + NumberB;
                    break;
                case "-":
                    result = numberA - NumberB;
                    break;
                case "*":
                    result = numberA * NumberB;
                    break;
                case "/":
                    result = numberA / NumberB;
                    break;
            }

            return result;
        }
    }
}