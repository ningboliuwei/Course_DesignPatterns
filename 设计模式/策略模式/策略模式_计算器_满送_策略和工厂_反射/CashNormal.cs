﻿namespace 策略模式_计算器_满送_策略和工厂_反射 {
    internal class CashNormal : CashSuper {
        public override double AcceptCash(double money) {
            return money;
        }
    }
}