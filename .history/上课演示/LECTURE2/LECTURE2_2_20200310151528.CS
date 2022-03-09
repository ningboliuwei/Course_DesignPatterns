using System;
public class Cat {
    private string _name;

    public Cat () { }

    public Cat (string name) {
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

    public string Shout () {
        return "I'm " + Name + ", mewo~";
    }
}

public class Dog {
    private string _name;

    public Dog () { }

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

    public string Shout () {
        return "I'm " + Name + ", wowww~";
    }
}

public class LECTURE1_1 {
    static void Main (string[] args) {
        Cat cat1 = new Cat ();
        Dog dog1 = new Dog ();

        Console.WriteLine (cat1.Shout ());
        Console.WriteLine (dog1.Shout ());
    }
}