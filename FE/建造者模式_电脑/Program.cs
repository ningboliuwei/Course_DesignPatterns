#region

using System;

#endregion

namespace 建造者模式_电脑 {
    internal class Program {
        private static void Main(string[] args) {
            var builder = new CheapPCBuilder(); //创建Expensive PC
            //ExpensivePCBuilder builder = new ExpensivePCBuilder();//创建Cheap PC
            var director = new PCDirector(builder);

            director.CreatePC();

            Console.ReadLine();
        }
    }
}