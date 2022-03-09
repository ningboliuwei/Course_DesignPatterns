#region

using System;

#endregion

namespace 装饰模式_用户登录_组合版 {
    internal class RegisteredUser {
        public User User { get; set; }

        private bool IsValid() {
            bool isValid;

            if (User.Name == "admin" && User.Password == "123456") {
                isValid = true;
            }
            else {
                isValid = false;
            }

            return isValid;
        }

        public void SignIn() {
            var isValid = IsValid();

            if (isValid) {
                Console.WriteLine("经过了安全验证");
                User.SignIn();
            }
            else {
                throw new Exception("无效的用户名或密码");
            }
        }
    }
}