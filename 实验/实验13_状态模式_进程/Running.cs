using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验13_状态模式_进程
{
    class Running : State
    {
        public Running() {
            StateName = "运行";
        }

        public void Suspend(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 Suspend 操作已由");
            Console.Write($"[{thread.CurrentState.StateName}]转为");
            thread.CurrentState = new Blocked();
            Console.Write($"[{thread.CurrentState.StateName}]\n");
        }

        public void Stop(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 Stop 操作已由");
            Console.Write($"[{thread.CurrentState.StateName}]转为");
            thread.CurrentState = new Dead();
            Console.Write($"[{thread.CurrentState.StateName}]\n");
        }
    }
}