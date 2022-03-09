﻿namespace 策略模式_计算器_满送_策略和工厂 {
    internal class CashContext {
        private readonly CashSuper m_cs;

        public CashContext(string type) {
            switch (type) {
                case "正常收费":
                    m_cs = new CashNormal();
                    break;
                case "满300返100":
                    var cr1 = new CashReturn("300", "100");
                    m_cs = cr1;
                    break;
                case "打八折":
                    var cr2 = new CashDiscount("0.8");
                    m_cs = cr2;
                    break;
                case "满400返100":
                    var cr3 = new CashReturn("400", "100");
                    m_cs = cr3;
                    break;
            }
        }

        public double GetResult(double money) {
            return m_cs.AcceptCash(money);
        }
    }
}