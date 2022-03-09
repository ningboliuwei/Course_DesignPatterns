using System;
using System.Collections;
using System.Collections.Generic;

public class Animal {
    protected string _name;

    public Animal () { }

    public Animal (string name) {
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

    public virtual void Shout () {
        // System.Console.WriteLine ("ANIMAL: I'm " + _name);
    }
}

public class Dog : Animal {
    public Dog (string name) : base (name) {

    }

    public void CatchDisc () {
        System.Console.WriteLine ("disc");
    }

    public override void Shout () {
        System.Console.WriteLine ("DOG: I'm " + _name + " wooo");
    }
}

public class Cat : Animal {
    public Cat (string name) : base (name) {

    }

    public void CatchMouse () {
        System.Console.WriteLine ("mouse");
    }

    public override void Shout () {
        System.Console.WriteLine ("CAT: I'm " + _name + " memw");
        // Do nothing
    }
}

public class LECTURE2_3 {
    static void Main (string[] args) {
        // Animal[] animals = new Animal[3];
        var animals = new List<Animal> ();

        var dog1 = new Dog ("Tom");
        var cat1 = new Cat ("Jane");
        var dog2 = new Dog ("Alex");

        animals.Add (dog1);
        animals.Add (cat1);
        animals.Add (dog2);

        var x = "hello";
        animals.Add (x);

        // animals[0] = dog1;
        // animals[1] = cat1;
        // animals[2] = dog2;

        for (var i = 0; i < animals.Count; i++) {
            animals[i].Shout ();
        }

    }
}