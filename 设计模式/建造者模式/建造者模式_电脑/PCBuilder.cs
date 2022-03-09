namespace 建造者模式_电脑 {
    internal abstract class PCBuilder {
        public abstract void BuildCPU();

        public abstract void BuildHarddisk();

        public abstract void BuildKeyboard();

        public abstract void BuildMonitor();

        public abstract void BuildMouse();

        public abstract void BuildRAM();
    }
}