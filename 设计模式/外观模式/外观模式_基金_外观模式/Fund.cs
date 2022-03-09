namespace 外观模式_基金_外观模式 {
    internal class Fund {
        private readonly House h1;
        private readonly Stock1 s1;

        private readonly Stock2 s2;

        private readonly Stock3 s3;

        public Fund() {
            s1 = new Stock1();
            s2 = new Stock2();
            s3 = new Stock3();
            h1 = new House();
        }

        public void BuyFund() {
            s1.Buy();
            s2.Buy();
            s3.Buy();
            h1.Buy();
        }

        public void SellFund() {
            s1.Sell();
            s2.Sell();
            s3.Sell();
            h1.Sell();
        }
    }
}