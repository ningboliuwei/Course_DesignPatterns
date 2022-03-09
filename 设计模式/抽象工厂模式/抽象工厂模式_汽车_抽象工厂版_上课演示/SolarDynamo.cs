#region

using System;

#endregion

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示 {
    internal class SolarDynamo : Dynamo {
        public override void PowerOn() {
            Console.WriteLine("Solar dynamo starts...");
        }
    }
}