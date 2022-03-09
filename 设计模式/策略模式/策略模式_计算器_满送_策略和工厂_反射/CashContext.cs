﻿namespace 策略模式_计算器_满送_策略和工厂_反射 {
    internal class CashContext {
        private readonly CashSuper m_cs;

        public CashContext(CashSuper cashSuper) {
            m_cs = cashSuper;
        }

        public double GetResult(double money) {
            return m_cs.AcceptCash(money);
        }
    }
}