#region

using System;

#endregion

namespace 实验08_双向适配器模式 {
    internal class Cat : ICat {
        public void CatchMouse() {
            Console.WriteLine("抓老鼠");
        }
    }
}