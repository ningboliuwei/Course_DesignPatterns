#region

using System;

#endregion

namespace 简单工厂模式_两数计算_创建大量对象版 {
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