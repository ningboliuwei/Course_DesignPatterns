using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验13_状态模式_进程
{
    class Dead:State
    {
        public Dead()
        {
            StateName = "死亡";
        }
    }
}
