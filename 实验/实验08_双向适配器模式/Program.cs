using System;

namespace 实验08_双向适配器模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICat cat = new AnimalAdapter(new Dog());
            Console.Write("我是一只猫：");
            cat.CatchMouse();

            IDog dog = new AnimalAdapter(new Cat());
            Console.Write("我是一条狗：");
            dog.Cry();

            Console.ReadKey();
        }
    }
}