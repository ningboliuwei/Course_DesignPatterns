#region

using System;

#endregion

namespace 装饰模式_小人_面向对象版 {
    internal class TShirts : Finery {
        public override void Show() {
            Console.Write("大T恤 ");
        }
    }
}