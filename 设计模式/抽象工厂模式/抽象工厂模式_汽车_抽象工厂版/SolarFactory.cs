using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版
{
    class SolarFactory : IFactory
    {
        public Engine MakeEngine()
        {
            return new SolarEngine();
        }

        public Dynamo MakeDynamo()
        {
            return new SolarDynamo();
        }
    }
}