#region

using System;

#endregion

namespace 组合模式_形状 {
    internal class Circle : Shape {
        public override void Draw() {
            Console.Write("○");
        }
    }
}