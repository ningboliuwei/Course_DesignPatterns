namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal interface IFactory {
        Dynamo GetDynamo();
        Engine GetEngine();
    }
}