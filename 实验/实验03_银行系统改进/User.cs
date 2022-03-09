namespace 实验03_银行系统改进 {
    internal class User : IValidatable {
        public User(string realName, string pin) {
            RealName = realName;
            PIN = pin;
        }

        public string PIN { get; set; }
        public string RealName { get; set; }

        public bool Validate(string id, string password) {
            if (id == RealName && password == PIN) {
                return true;
            }

            return false;
        }
    }
}