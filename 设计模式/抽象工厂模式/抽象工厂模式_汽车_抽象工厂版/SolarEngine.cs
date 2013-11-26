using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 抽象工厂模式_汽车_抽象工厂版
{
    class SolarEngine : Engine
    {
        public override void Launch()
        {
            Console.WriteLine("Solar engine starts...");
        }
    }
}