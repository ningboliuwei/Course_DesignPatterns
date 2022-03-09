#region

using System;

#endregion

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal class Program {
        private static void Main(string[] args) {
            var car1 = new Car();
            IFactory factory = new SolarFactory();
            car1.Engine = factory.GetEngine();
            car1.Dynamo = factory.GetDynamo();

            car1.Drive();

            Console.ReadLine();
        }
    }
}