#region

using System;

#endregion

namespace 工厂方法模式_汽车 {
    internal class Program {
        private static void Main(string[] args) {
            //以下为固定模式生成GasonlineEngine汽车
            //EngineFactory engineFactory1 = new GasonlineEngineFactory();

            //Car car1 = new Car();
            //car1.Engine = engineFactory1.MakeEngine();
            //car1.Drive();

            //Car car2 = new Car();
            //car2.Engine = engineFactory1.MakeEngine();
            //car2.Drive();

            //Car car3 = new Car();
            //car3.Engine = engineFactory1.MakeEngine();
            //car3.Drive();

            //Car car4 = new Car();
            //car4.Engine = engineFactory1.MakeEngine();
            //car4.Drive();
            //---------------------------------------------------------------------

            //以下代码为让用户选择生成汽车的类型
            Console.WriteLine("Please input engine type: Gasoline/Solar/Nuclear");
            var engineType = Console.ReadLine();

            //EngineFactory engineFactory = new SolarEngineFactory();
            //EngineFactory engineFactory = new GasonlineEngineFactory();
            EngineFactory engineFactory = new NuclearEngineFactory();

            switch (engineType) {
                case "Gasoline":
                    engineFactory = new GasonlineEngineFactory();
                    break;
                case "Solar":
                    engineFactory = new SolarEngineFactory();
                    break;
                case "Nuclear":
                    engineFactory = new NuclearEngineFactory();
                    break;
            }

            var car = new Car();
            car.Engine = engineFactory.MakeEngine();
            car.Drive();
            //---------------------------------------------------------------

            Console.ReadLine();
        }
    }
}