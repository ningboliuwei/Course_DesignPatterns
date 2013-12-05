using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_屏幕放大镜
{
    class LargestState : State
    {
        public override void Display()
        {
            Console.WriteLine("四倍大小");
        }
    }
}
