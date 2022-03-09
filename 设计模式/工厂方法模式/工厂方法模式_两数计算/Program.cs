#region

using System;

#endregion

namespace 工厂方法模式_两数计算 {
    internal class Program {
        private static void Main(string[] args) {
            Console.Write("请输入数字A: ");
            var strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号(+ - * /): ");
            var strOperate = Console.ReadLine();
            Console.Write("请输入数字B: ");
            var strNumberB = Console.ReadLine();

            IOperationFactory factory = null;
            switch (strOperate) {
                case "+":
                    factory = new AddFactory();
                    break;
                case "-":
                    factory = new SubFactory();
                    break;
                case "*":
                    factory = new MulFactory();
                    break;
                case "/":
                    factory = new DivFactory();
                    break;
            }

            Operation operation = null;
            if (factory != null) {
                operation = factory.CreateOperation();
            }

            operation.NumberA = Convert.ToDouble(strNumberA);
            operation.NumberB = Convert.ToDouble(strNumberB);
            Console.WriteLine("结果为: " + operation.GetResult());
            Console.ReadLine();
        }
    }
}