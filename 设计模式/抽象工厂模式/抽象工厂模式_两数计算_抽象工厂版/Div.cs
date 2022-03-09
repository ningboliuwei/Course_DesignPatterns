﻿#region

using System;

#endregion

namespace 工厂方法模式_两数计算 {
    internal class OperationDiv : Operation {
        public override double GetResult() {
            double result = 0;
            if (NumberB == 0) {
                throw new Exception("除数不能为0");
            }

            result = NumberA / NumberB;

            return result;
        }
    }
}