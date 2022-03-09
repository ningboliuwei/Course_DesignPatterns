#region

using System;

#endregion

namespace 装饰模式_小人_装饰模式版 {
    internal class Suits : Finery {
        public override void Show() {
            Console.Write("西装 ");
            base.Show();
        }
    }
}