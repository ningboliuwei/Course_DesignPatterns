namespace 简单工厂模式_汽车_简单工厂版 {
    internal class EngineFactory {
        public static Engine MakeEngine(string engineType) {
            Engine engine;

            switch (engineType) {
                case "Gasoline":
                    engine = new GasolineEngine();
                    break;
                case "Solar":
                    engine = new SolarEngine();
                    break;
                default:
                    return null;
                    break;
            }

            return engine;
        }
    }
}