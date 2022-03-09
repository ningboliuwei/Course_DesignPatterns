#region

using System;

#endregion

namespace 工厂方法模式_汽车 {
    internal class GasolineEngine : Engine {
        public override void Launch() {
            Console.WriteLine("Gasonline engine starts...");
        }
    }
}