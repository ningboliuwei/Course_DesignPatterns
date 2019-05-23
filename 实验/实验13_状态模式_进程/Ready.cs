using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验13_状态模式_进程
{
    class Ready:State
    {
        public Ready()
        {
            StateName = "就绪";
        }

        public void GetCPU(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 GetCPU 操作已由");
            Console.Write($"[{thread.CurrentState.StateName}]转为");
            thread.CurrentState = new Running();
            Console.Write($"[{thread.CurrentState.StateName}]\n");
        }
    }
}
