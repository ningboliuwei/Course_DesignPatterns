#region

using System;

#endregion

namespace 外观模式_家庭影院_传统版 {
    internal class Screen {
        public void Down() {
            Console.WriteLine("屏幕已放下");
        }

        public void Up() {
            Console.WriteLine("屏幕已升起");
        }
    }
}