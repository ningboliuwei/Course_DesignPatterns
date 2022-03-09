#region

using System;
using System.Collections.Generic;

#endregion

namespace LECTURE_DEMO {
    internal class Program {
        private static void AnimalsAllShout(List<Animal> animals) {
            foreach (var animal in animals) {
                Console.WriteLine(animal.Shout());
            }
        }

        private static List<Animal> GenerateAnimals() {
            var count = new Random().Next(1, 11);
            // var animals = new Animal[count];

            var animals = new List<Animal>();

            for (var i = 0; i < count; i++) {
                Animal animal = null;
                var type = new Random().Next(0, 3);
                if (type == 0) {
                    animal = new Cat("cat" + i);
                }
                else if (type == 1) {
                    animal = new Dog("dog" + i);
                }
                else if (type == 2) {
                    animal = new Monkey("pig" + i);
                }

                animals.Add(animal);
            }

            return animals;
        }

        private static void Main(string[] args) {
            // var animals = GenerateAnimals();
            //
            // object o = new Cat("cat1");
            // Cat cat1 = (Cat) o;
            //
            //
            // AnimalsAllShout(animals);
            // var changers = new IChange[2];

            //changers[0] = new MachineCat("机器猫");
            //changers[1] = new StoneMonkey("孙悟空");

            // foreach (var animal in changers) {
            //   animal.Change();
            //}
            var start = DateTime.Now;
            for (var i = 0; i < 2000000; i++) {
                if (i == 0) {
                    // do nothing
                }
            }

            var end = DateTime.Now;

            Console.WriteLine((end - start).TotalMilliseconds / 1000);

            Console.ReadKey();
        }
    }
}