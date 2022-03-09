#region

using System;

#endregion

namespace 工厂方法模式_汽车 {
    internal class Car {
        public Engine Engine { get; set; }

        public void Drive() {
            Engine.Launch();
            Console.WriteLine("Car is running");
        }
    }
}