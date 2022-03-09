#region

using System;

#endregion

namespace 实验08_双向适配器模式 {
    internal class Dog : IDog {
        public void Cry() {
            Console.WriteLine("汪汪汪");
        }
    }
}