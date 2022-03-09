namespace 适配器模式_姚明 {
    internal class Translator : Player {
        private readonly ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name)
            : base(name) {
            wjzf.Name = name;
        }

        public override void Attack() {
            wjzf.JinGong();
        }

        public override void Defense() {
            wjzf.FangShou();
        }
    }
}