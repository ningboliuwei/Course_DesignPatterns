using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版
{
    class SolarDynamo : Dynamo
    {
        public override void PowerOn()
        {
            Console.WriteLine("Solar electricity");
        }
    }
}