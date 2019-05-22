using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式_共享状态_开关
{
    class Program
    {
        static void Main(string[] args) {
            Switch s1 = new Switch {Name = "厨房的开关"};
            Switch s2 = new Switch {Name = "客厅的开关"};

            s1.Press();
            s1.Press();
            s1.Press();
            Console.WriteLine("-----------------------");
            s2.Press();
            s2.Press();
            s2.Press();

            Console.ReadKey();
        }
    }
}