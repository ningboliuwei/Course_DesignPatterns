#region

using System;

#endregion

namespace 装饰模式_小人_装饰模式版 {
    internal class Person {
        private readonly string _name;

        public Person() {
        }

        public Person(string name) {
            _name = name;
        }

        public virtual void Show() {
            Console.WriteLine("装扮的{0}", _name);
        }
    }
}