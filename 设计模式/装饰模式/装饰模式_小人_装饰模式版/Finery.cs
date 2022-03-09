namespace 装饰模式_小人_装饰模式版 {
    internal class Finery : Person {
        protected Person _person;

        public void Decorate(Person person) {
            _person = person;
        }

        public override void Show() {
            if (_person != null) {
                _person.Show();
            }
        }
    }
}