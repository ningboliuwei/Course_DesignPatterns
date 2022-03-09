namespace 策略模式_电影票折扣 {
    internal class MovieTicket {
        private Discount m_discount;

        public void GetPrice() {
            m_discount.Caculate();
        }

        public void SetDiscount(Discount discount) {
            m_discount = discount;
        }
    }
}