using System;
// The previous content of this file has been saved into 
// C:\Users\Liu Wei\AppData\Roaming\Code\User\cs-script.user\new_script.cs.bak 

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
public class Cat {
    public Cat () {

    }

    public Cat (string name) {
        Name = name;
    }

    public string Name { private set; get; }

    public string Shout () {
        return "I'm " + Name + ", mewo~";
    }
}

class Script {
    static void Main (string[] args) {
        Cat cat1 = new Cat ("Tom");
        Cat cat2 = new Cat ("Alex");
        // cat1.Name = "Jane";
        Console.WriteLine (cat1.Shout ());

        // cat2.Name = "Alex";
        Console.WriteLine (cat2.Shout ());
    }
}