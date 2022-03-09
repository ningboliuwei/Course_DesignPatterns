namespace 实验07_手机装饰模式 {
    internal class Module : MobilePhone {
        private readonly MobilePhone _phone;

        public Module(MobilePhone phone) {
            _phone = phone;
        }

        public override void Call() {
            _phone.Call();
        }

        public override void SendMessage() {
            _phone.SendMessage();
        }
    }
}