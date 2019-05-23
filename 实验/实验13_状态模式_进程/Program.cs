using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验13_状态模式_进程
{
    class Program
    {
        static void Main(string[] args) {
            var thread1 = new Thread {ThreadId = 1};

            thread1.Start();
            thread1.GetCPU();
            thread1.Suspend();
            thread1.Resume();
            thread1.GetCPU();
            thread1.Stop();

            Console.ReadKey();
        }
    }
}