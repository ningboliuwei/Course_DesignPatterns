using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式_共享状态_开关
{
    class OffState : SwitchState
    {
        public override void Press(Switch s) {
            s.SetState(s.GetOnState());
            Console.WriteLine($"开关 {s.Name} 被打开了");
        }
    }
}