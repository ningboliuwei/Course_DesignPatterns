#region

using System;

#endregion

namespace 工厂方法模式_汽车 {
    internal class NuclearEngine : Engine {
        public override void Launch() {
            Console.WriteLine("Nuclear engine starts...");
        }
    }
}