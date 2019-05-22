using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 状态模式_共享状态_开关;

namespace 状态模式_共享状态_开关
{
    abstract class SwitchState
    {
        public abstract void Press(Switch s);
    }
}