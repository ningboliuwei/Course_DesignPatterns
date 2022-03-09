#region

using System;

#endregion

namespace 实验08_双向适配器模式 {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("使用适配器模式之前");
            ICat cat1 = new Cat();
            Console.Write("我是一只猫：");
            cat1.CatchMouse();

            IDog dog1 = new Dog();
            Console.Write("我是一条狗：");
            dog1.Cry();

            Console.WriteLine();
            Console.WriteLine("使用适配器模式之后");
            ICat cat2 = new AnimalAdapter(new Dog());
            Console.Write("我是一只猫：");
            cat2.CatchMouse();

            IDog dog2 = new AnimalAdapter(new Cat());
            Console.Write("我是一条狗：");
            dog2.Cry();

            Console.ReadKey();
        }
    }
}