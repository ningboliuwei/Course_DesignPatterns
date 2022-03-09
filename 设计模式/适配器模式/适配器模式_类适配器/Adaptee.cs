#region

using System;

#endregion

namespace 适配器模式_类适配器 {
    internal class Adaptee {
        public void SpecificRequest() {
            Console.Write("特别请求");
        }
    }
}