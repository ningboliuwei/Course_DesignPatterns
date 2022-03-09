#region

using System;

#endregion

namespace 组合模式_形状 {
    internal class Star : Shape {
        public override void Draw() {
            Console.WriteLine("☆");
        }
    }
}