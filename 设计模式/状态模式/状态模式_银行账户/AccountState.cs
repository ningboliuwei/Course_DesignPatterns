namespace 状态模式_银行账户 {
    internal abstract class AccountState {
        protected Account Account;

        //存款
        public abstract void Deposit(double amount);

        //检查账户状态
        public abstract void StateCheck();

        //取款
        public abstract void Withdraw(double amount);
    }
}