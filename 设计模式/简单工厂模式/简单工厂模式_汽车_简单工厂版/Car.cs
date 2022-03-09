#region

using System;

#endregion

namespace 简单工厂模式_汽车_简单工厂版 {
    internal class Car {
        public Engine Engine { get; set; }

        public void Drive() {
            Engine.Launch();
            Console.WriteLine("Car is running");
        }
    }
}