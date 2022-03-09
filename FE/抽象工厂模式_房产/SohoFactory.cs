namespace 抽象工厂模式_房产 {
    internal class SohoFactory : IFactory {
        public IApartment ProduceApartment() {
            return new SohoApartment();
        }

        public IVilla ProduceVilla() {
            return new SohoVilla();
        }
    }
}