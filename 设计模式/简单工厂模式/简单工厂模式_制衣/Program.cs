#region

using System;

#endregion

namespace 简单工厂模式_制衣 {
    internal class Program {
        private static void Main(string[] args) {
            Console.Write("请输入服装类型: ");
            var coatType = Console.ReadLine();
            var coat = CoatFactory.CreateCoat(coatType);
            Console.WriteLine(coat.GetCoat());
            Console.ReadLine();
        }
    }
}