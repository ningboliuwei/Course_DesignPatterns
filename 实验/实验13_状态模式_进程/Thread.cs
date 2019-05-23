using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验13_状态模式_进程
{
    class Thread
    {
        public State CurrentState { get; set; } = new New();

        public int ThreadId { get; set; }

        public void Start() {
            ((New) CurrentState).Start(this);
        }

        public void GetCPU() {
            ((Ready) CurrentState).GetCPU(this);
        }

        public void Suspend() {
            ((Running) CurrentState).Suspend(this);
        }

        public void Resume() {
            ((Blocked) CurrentState).Resume(this);
        }

        public void Stop() {
            ((Running) CurrentState).Stop(this);
        }
    }
}