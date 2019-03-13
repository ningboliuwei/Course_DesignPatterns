namespace 实验03_银行系统改进
{
    class User : IValidatable
    {
        public string RealName { get; set; }
        public string PIN { get; set; }

        public User(string realName, string pin)
        {
            RealName = realName;
            PIN = pin;
        }


        public bool Validate(string id, string password)
        {
            if (id == RealName && password == PIN)
                return true;

            return false;
        }
    }
}