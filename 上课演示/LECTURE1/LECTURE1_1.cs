using System;

// public class Cat {
//     private string _name;
//     public string Name {
//         get {
//             return _name;
//         };
//         set {
//             _name = value;
//         }
//     }
// }
public class Cat
{
    public Cat() {
    }

    public Cat(string name) {
        Name = name;
    }

    public string Name { get; }

    public string Shout() {
        return "I'm " + Name + ", mewo~";
    }
}

public class LECTURE1_1
{
    private static void Main(string[] args) {
        var cat1 = new Cat("Tom");
        var cat2 = new Cat("Alex");
        // cat1.Name = "Jane";
        Console.WriteLine(cat1.Shout());

        // cat2.Name = "Alex";
        Console.WriteLine(cat2.Shout());
    }
}