namespace 状态模式_俱乐部 {
    internal class ClubAccount {
        public ClubAccount(string name) //构造函数
        {
            CustomerName = name;
            State = new VisitorState(0.0, this);
        }

        //金额属性（只能通过Deposit()和Cost()方法改变）
        public double Balance => State.Balance;

        //顾客姓名
        public string CustomerName { get; set; }

        public ClubState State { get; set; }

        public void ClubService() {
            State.ClubService();
        }

        public void Cost(double amount) {
            State.Cost(amount);
        }

        public void Deposit(double amount) {
            State.Deposit(amount);
        }
    }
}