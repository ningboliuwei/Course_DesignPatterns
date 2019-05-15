using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器
{
    class CountingEventArgs:EventArgs {
        public int CurrentNumber;
    }
}
