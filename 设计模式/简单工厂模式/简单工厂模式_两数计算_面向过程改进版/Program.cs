#region

using System;

#endregion

namespace 简单工厂模式_两数计算_面向过程改进版 {
    internal class Program {
        private static void Main(string[] args) {
            Console.Write("请输入数字A: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("请选择运算符号(+ - * /): ");
            var oper = Console.ReadLine();
            Console.Write("请输入数字B: ");
            var b = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            var ifDividedByZero = false;

            if (oper == "+") {
                result = a + b;
            }

            if (oper == "-") {
                result = a - b;
            }

            if (oper == "*") {
                result = a * b;
            }

            if (oper == "/") {
                result = a / b;
            }

            Console.WriteLine("结果是: " + result);
            Console.ReadLine();
        }
    }
}