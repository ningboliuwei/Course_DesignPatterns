#region

using System;

#endregion

namespace 抽象工厂模式_房产 {
    internal class Program {
        private static void Main(string[] args) {
            IFactory vFactory = new VankeFactory();
            IFactory sFactory = new SohoFactory();

            var vVilla = vFactory.ProduceVilla();
            var vApartment = vFactory.ProduceApartment();

            var sVilla = sFactory.ProduceVilla();
            var sApartment = sFactory.ProduceApartment();

            vVilla.Show();
            vApartment.Show();

            sVilla.Show();
            sApartment.Show();

            Console.ReadLine();
        }
    }
}