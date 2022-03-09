#region

using System;

#endregion

namespace 简单工厂模式_汽车_简单工厂版 {
    internal class SolarEngine : Engine {
        public override void Launch() {
            Console.WriteLine("Solar engine starts...");
        }
    }
}