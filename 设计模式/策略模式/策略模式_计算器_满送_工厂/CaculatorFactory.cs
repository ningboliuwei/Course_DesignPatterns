namespace 策略模式_计算器_满送_工厂 {
    internal class CaculatorFactory {
        public static Caculator CreateCaculator(string type) {
            Caculator caculator = null;

            switch (type) {
                case "正常收费":
                    caculator = new CaculatorNormal();
                    break;
                case "满300返100":
                    var cr1 = new CaculatorReturn(300, 100);
                    caculator = cr1;
                    break;
                case "打八折":
                    var cr2 = new CaculatorDiscount(0.8);
                    caculator = cr2;
                    break;
            }

            return caculator;
        }
    }
}