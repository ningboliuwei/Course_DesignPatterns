namespace 抽象工厂模式_房产 {
    internal class VankeFactory : IFactory {
        public IApartment ProduceApartment() {
            return new VankeApartment();
        }

        public IVilla ProduceVilla() {
            return new VankeVilla();
        }
    }
}