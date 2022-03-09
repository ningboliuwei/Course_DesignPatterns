#region

using System;

#endregion

namespace 简单工厂模式_汽车_简单工厂版 {
    internal class Program {
        private static void Main(string[] args) {
            var car1 = new Car();
            car1.Engine = EngineFactory.MakeEngine("Gasoline");
            car1.Drive();

            var car2 = new Car();
            car2.Engine = EngineFactory.MakeEngine("Solar");
            car2.Drive();

            var car3 = new Car();
            car3.Engine = EngineFactory.MakeEngine("Gasoline");
            car3.Drive();

            var car4 = new Car();
            car4.Engine = EngineFactory.MakeEngine("Solar");
            car4.Drive();

            Console.ReadLine();
        }
    }
}