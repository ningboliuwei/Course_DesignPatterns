#region

using System;

#endregion

namespace 实验13_状态模式_进程 {
    internal class New : State {
        public New() {
            StateName = "新建";
        }

        public void Start(Thread thread) {
            Console.Write($"ID 为 {thread.ThreadId} 的线程通过 Start 操作已由");
            Console.Write($" {thread.CurrentState.StateName} 转为");
            thread.CurrentState = new Ready();
            Console.Write($" {thread.CurrentState.StateName}\n");
        }
    }
}