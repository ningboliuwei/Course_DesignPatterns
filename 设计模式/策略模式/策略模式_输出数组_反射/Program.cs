#region

using System;

#endregion

namespace 策略模式_输出数组_反射 {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine(@"Please input data with the seperator, e.g. Jane,Alex,John");
            var dataString = Console.ReadLine();

            var context = new OutputFileContext(OutputFileContext.GetStrategy());
            context.SaveFile(dataString.Split(','));

            Console.ReadLine();
        }
    }
}