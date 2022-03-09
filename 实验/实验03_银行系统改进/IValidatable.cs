namespace 实验03_银行系统改进 {
    internal interface IValidatable {
        bool Validate(string id, string password);
    }
}