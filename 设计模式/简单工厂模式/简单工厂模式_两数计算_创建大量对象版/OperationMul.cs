﻿namespace 简单工厂模式_两数计算_创建大量对象版 {
    internal class OperationMul : Operation {
        public override double GetResult() {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}