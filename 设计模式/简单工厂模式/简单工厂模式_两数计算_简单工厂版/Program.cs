#region

using System;

#endregion

namespace 简单工厂模式_两数计算_简单工厂版 {
    internal class Program {
        private static void Main(string[] args) {
            Operation operation;

            Console.Write("请输入数字A: ");
            var strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号(+ - * /): ");
            var strOperate = Console.ReadLine();
            Console.Write("请输入数字B: ");
            var strNumberB = Console.ReadLine();
            var strResult = "";

            operation = OperationFactory.CreateOperation(strOperate);
            operation.NumberA = Convert.ToDouble(strNumberA);
            operation.NumberB = Convert.ToDouble(strNumberB);
            strResult = operation.GetResult().ToString();

            Console.WriteLine("结果是：" + strResult);
            Console.ReadLine();
        }
    }
}