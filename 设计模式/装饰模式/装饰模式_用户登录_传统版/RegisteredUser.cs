#region

using System;

#endregion

namespace 装饰模式_用户登录_传统版 {
    internal class RegisteredUser : User {
        private bool IsValid() {
            bool isValid;

            if (Name == "admin" && Password == "123456") {
                isValid = true;
            }
            else {
                isValid = false;
            }

            return isValid;
        }

        public override void SignIn() {
            var isValid = IsValid();

            if (isValid) {
                Console.WriteLine("经过了安全验证");
                base.SignIn();
            }
            else {
                throw new Exception("无效的用户名或密码");
            }
        }
    }
}