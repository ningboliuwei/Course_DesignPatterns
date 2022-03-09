namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal class SolarFactory : IFactory {
        public Dynamo GetDynamo() {
            return new SolarDynamo();
        }

        public Engine GetEngine() {
            return new SolarEngine();
        }
    }
}