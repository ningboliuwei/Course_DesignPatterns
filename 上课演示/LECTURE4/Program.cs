using System;
using System.Collections.Generic;

namespace LECTURE4
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

            var animals = new List<Animal>();
            animals.Add(cat1);
            animals.Add(dog1);

            Console.WriteLine(animals[0].GetShoutSound());
            Console.WriteLine(animals[1].GetShoutSound());
            Console.ReadKey();
        }
    }
}