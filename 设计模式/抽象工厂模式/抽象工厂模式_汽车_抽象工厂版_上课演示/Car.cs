#region

using System;

#endregion

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal class Car {
        public Dynamo Dynamo { get; set; }

        public Engine Engine { get; set; }

        public void Drive() {
            Engine.Launch();
            Dynamo.PowerOn();
            Console.WriteLine("Car is running");
        }
    }
}