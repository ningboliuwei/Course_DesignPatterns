namespace 工厂方法模式_汽车 {
    internal class NuclearEngineFactory : EngineFactory {
        public override Engine MakeEngine() {
            return new NuclearEngine();
        }
    }
}