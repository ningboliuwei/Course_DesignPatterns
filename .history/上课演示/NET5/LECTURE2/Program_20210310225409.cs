using System;

namespace LECTURE2 {
    public class Dog {
        private string _name;

        public Dog (string name) {
            _name = name;
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
    }

    class Program {
        static void Main (string[] args) {
            var dog = new Dog ("gold");

            Console.WriteLine (dog.Name);

            Console.ReadKey ();
        }
    }
}