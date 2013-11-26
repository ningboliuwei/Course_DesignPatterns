using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFactory factory = new SolarFactory();//创建太阳能工厂对象，用于生产太阳能汽车所需的引擎与发电机
            //IFactory factory = new GasolineFactory(); //如需生产汽油汽车所需的引擎与发电机，则将对象改为GasolineFactory

            Car car1 = new Car();
            car1.Engine = factory.MakeEngine();
            car1.Dynamo = factory.MakeDynamo();
            car1.Drive();

            Car car2 = new Car();
            car2.Engine = factory.MakeEngine();
            car2.Dynamo = factory.MakeDynamo();
            car2.Drive();


            Console.ReadLine();
        }
    }
}