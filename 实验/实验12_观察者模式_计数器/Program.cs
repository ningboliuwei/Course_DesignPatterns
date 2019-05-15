using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器 {
    class Program {
        static void Main(string[] args) {
            var incrementer = new Incrementer {StartNumber = 5, CountNumber = 10};

            var consoleOutputer = new ConsoleOutputer();
            incrementer.CountStart += consoleOutputer.ShowCountStart;
            incrementer.Counting += consoleOutputer.ShowCounting;
            incrementer.CountEnd += consoleOutputer.ShowCountEnd;

            var fileOutputer = new FileOutputer{FilePath = Path.Combine(Environment.CurrentDirectory, "output.txt")};
            incrementer.CountStart += fileOutputer.WriteCountStart;
            incrementer.Counting += fileOutputer.WriteCounting;
            incrementer.CountEnd += fileOutputer.WriteCountEnd;

            incrementer.Count();

            Console.ReadKey();
        }
    }
}