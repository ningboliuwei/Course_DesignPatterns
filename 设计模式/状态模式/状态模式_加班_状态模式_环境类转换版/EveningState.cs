using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_环境类转换版
{
    internal class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间{0}点 加班哦，疲劳之极", work.Hour);
        }
    }
}

