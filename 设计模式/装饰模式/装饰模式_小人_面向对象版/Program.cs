#region

using System;

#endregion

namespace 装饰模式_小人_面向对象版 {
    internal class Program {
        private static void Main(string[] args) {
            //第一种装扮
            var person = new Person("小毛");
            Console.WriteLine("\n第一种装扮");
            Finery tShirt = new TShirts();
            Finery bigTrousers = new BigTrousers();
            Finery sneakers = new Sneakers();

            tShirt.Show();
            bigTrousers.Show();
            sneakers.Show();
            person.Show();
            //第一种装扮

            //第二种装扮
            //Person person = new Person("小毛");
            //Console.WriteLine("\n第二种装扮");
            //Finery bigTrousers = new BigTrousers();

            //bigTrousers.Show();
            //person.Show();
            //第二种装扮
            Console.ReadLine();
        }
    }
}