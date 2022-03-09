using System;

namespace LECTURE3
{
    public abstract class Animal
    {
        public abstract string GetShoutSound();

        private string Foo() {
            return "foo";
        }
    }

    public class Dog : Animal
    {
        public override string GetShoutSound() {
            return "汪汪汪";
        }
    }

    public class Cat : Animal
    {
        public override string GetShoutSound() {
            return "喵喵喵";
        }
    }

    internal class Program
    {
        private static void Main(string[] args) {
            var cat1 = new Cat();
            var dog1 = new Dog();

            var animals = new Animal[2];
            animals[0] = cat1;
            animals[1] = dog1;

            Console.WriteLine(animals[0].GetShoutSound());
            Console.WriteLine(animals[1].GetShoutSound());
            Console.ReadKey();
        }
    }
}