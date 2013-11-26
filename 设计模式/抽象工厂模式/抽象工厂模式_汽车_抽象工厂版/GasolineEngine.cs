using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 抽象工厂模式_汽车_抽象工厂版;


namespace 抽象工厂模式_汽车_抽象工厂版
{
    class GasolineEngine : Engine
    {
        public override void Launch()
        {
            Console.WriteLine("Gasonline engine starts...");
        }
    }
}