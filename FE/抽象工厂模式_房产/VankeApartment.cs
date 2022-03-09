#region

using System;

#endregion

namespace 抽象工厂模式_房产 {
    internal class VankeApartment : IApartment {
        public void Show() {
            Console.WriteLine("This is a Vanke Apartment");
        }
    }
}