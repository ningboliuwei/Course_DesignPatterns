namespace 实验08_双向适配器模式 {
    internal class AnimalAdapter : ICat, IDog {
        private readonly ICat _cat;
        private readonly IDog _dog;

        public AnimalAdapter(ICat cat) {
            _cat = cat;
        }

        public AnimalAdapter(IDog dog) {
            _dog = dog;
        }

        public void CatchMouse() {
            _dog.Cry();
        }

        public void Cry() {
            _cat.CatchMouse();
        }
    }
}