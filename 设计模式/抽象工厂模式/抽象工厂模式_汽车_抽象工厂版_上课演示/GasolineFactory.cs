namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal class GasolineFactory : IFactory {
        Dynamo IFactory.GetDynamo() {
            return new GaslolineDynamo();
        }

        public Engine GetEngine() {
            return new GasolineEngine();
        }
    }
}