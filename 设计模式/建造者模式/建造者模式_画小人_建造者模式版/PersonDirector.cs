namespace 建造者模式_画小人_建造者模式版 {
    internal class PersonDirector {
        private readonly PersonBuilder _builder;

        public PersonDirector(PersonBuilder builder) {
            _builder = builder;
        }

        public void CreatePerson() {
            _builder.BuildHead();
            _builder.BuildBody();
            _builder.BuildLeftArm();
            _builder.BuildRightArm();
            _builder.BuildLeftLeg();
            _builder.BuildRightLeg();
        }
    }
}