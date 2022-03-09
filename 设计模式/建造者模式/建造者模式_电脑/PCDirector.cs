namespace 建造者模式_电脑 {
    internal class PCDirector {
        private readonly PCBuilder pb;

        public PCDirector(PCBuilder pcBuilder) {
            pb = pcBuilder;
        }

        public void CreatePC() {
            pb.BuildCPU();
            pb.BuildHarddisk();
            pb.BuildKeyboard();
            pb.BuildMonitor();
            pb.BuildRAM();
            pb.BuildMouse();
        }
    }
}