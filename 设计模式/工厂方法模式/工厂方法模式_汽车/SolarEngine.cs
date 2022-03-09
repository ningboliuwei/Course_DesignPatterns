#region

using System;

#endregion

namespace 工厂方法模式_汽车 {
    internal class SolarEngine : Engine {
        public override void Launch() {
            Console.WriteLine("Solar engine starts...");
        }
    }
}