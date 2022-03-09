#region

using System;

#endregion

namespace 外观模式_家庭影院_传统版 {
    internal class Lights {
        public void SetBrightness(int brightness) {
            Console.WriteLine($"灯光已调到 {brightness} 的亮度");
        }
    }
}