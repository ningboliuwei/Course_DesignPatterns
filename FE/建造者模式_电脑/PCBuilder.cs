namespace 建造者模式_电脑 {
    internal abstract class PCBuilder {
        public abstract void BuildDesktop();

        public abstract void BuildMonitor();

        public abstract void BuildPeripherals();
    }
}