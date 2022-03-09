#region

using System;

#endregion

namespace 实验13_状态模式_进程 {
    internal class Running : State {
        public Running() {
            StateName = "运行";
        }

        public void Stop(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 Stop 操作已由");
            Console.Write($" {thread.CurrentState.StateName} 转为");
            thread.CurrentState = new Dead();
            Console.Write($" {thread.CurrentState.StateName}\n");
        }

        public void Suspend(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 Suspend 操作已由");
            Console.Write($" {thread.CurrentState.StateName} 转为");
            thread.CurrentState = new Blocked();
            Console.Write($" {thread.CurrentState.StateName}\n");
        }
    }
}