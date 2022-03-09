#region

using System;

#endregion

namespace 抽象工厂模式_房产 {
    internal class VankeVilla : IVilla {
        public void Show() {
            Console.WriteLine("This is a Vanke Villa");
        }
    }
}