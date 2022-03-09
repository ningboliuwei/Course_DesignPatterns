#region

using System;

#endregion

namespace 简单工厂模式_两数计算_引入继承版 {
    internal class Program {
        private static void Main(string[] args) {
            try {
                Console.Write("请输入数字A: ");
                var strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+ - * /): ");
                var strOperate = Console.ReadLine();
                Console.Write("请输入数字B: ");
                var strNumberB = Console.ReadLine();
                var strResult = "";

                var operation = new Operation();
                switch (strOperate) {
                    case "+":
                        operation = new OperationAdd();
                        break;
                    case "-":
                        operation = new OperationSub();
                        break;
                    case "*":
                        operation = new OperationMul();
                        break;
                    case "/":
                        operation = new OperationDiv();
                        break;
                }

                operation.NumberA = Convert.ToDouble(strNumberA);
                operation.NumberB = Convert.ToDouble(strNumberB);
                strResult = operation.GetResult().ToString();

                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}