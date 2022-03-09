#region

using System;

#endregion

namespace 简单工厂模式_两数计算_面向过程版 {
    internal class Program {
        private static void Main(string[] args) {
            Console.Write("请输入数字A: ");
            var numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("请选择运算符号(+ - * /): ");
            var oper = Console.ReadLine();
            Console.Write("请输入数字B: ");
            var numberB = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            if (oper == "+") {
                result = numberA + numberB;
            }

            if (oper == "-") {
                result = numberA - numberB;
            }

            if (oper == "*") {
                result = numberA * numberB;
            }

            if (oper == "/") {
                result = numberA / numberB;
            }

            Console.WriteLine("结果是: " + result);
            Console.ReadLine();
        }
    }
}