namespace 抽象工厂模式_房产 {
    internal interface IFactory {
        IApartment ProduceApartment();
        IVilla ProduceVilla();
    }
}