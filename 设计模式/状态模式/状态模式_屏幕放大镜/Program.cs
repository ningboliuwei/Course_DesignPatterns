using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_屏幕放大镜
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();

            screen.OnClick();
            screen.OnClick();
            screen.OnClick();
       

            Console.ReadLine();
        }
    }
}
