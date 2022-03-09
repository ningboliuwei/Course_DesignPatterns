#region

using System;

#endregion

namespace 实验08_加密适配器模式 {
    internal class Program {
        private static void Main(string[] args) {
            var userHelper = new UserHelper();
            userHelper.SetPassword();
            userHelper.SaveEncryptedPassword();

            Console.ReadKey();
        }
    }
}