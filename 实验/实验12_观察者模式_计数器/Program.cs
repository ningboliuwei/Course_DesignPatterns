using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器
{
    class Program
    {
        static void Main(string[] args) {
            var incrementer = new Incrementor {StartNumber = 5, CountNumber = 10};
            incrementer.CountStart += incrementer.ShowCountStart;
            incrementer.Counting += incrementer.ShowCounting;
            incrementer.CountEnd += incrementer.ShowCountEnd;

            incrementer.Count();

            Console.ReadKey();
        }
    }
}
