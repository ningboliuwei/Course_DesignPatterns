namespace 适配器模式_对象适配器 {
    internal class Adapter : Target {
        private readonly Adaptee adaptee = new Adaptee();

        public override void Request() {
            adaptee.SpecificRequest();
        }
    }
}