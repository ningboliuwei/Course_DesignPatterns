﻿namespace 工厂方法模式_两数计算 {
    internal class DivFactory : IOperationFactory {
        public Operation CreateOperation() {
            return new OperationDiv();
        }
    }
}