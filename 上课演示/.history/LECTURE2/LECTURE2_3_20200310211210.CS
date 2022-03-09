using System;
using System.Collections;
using System.Collections.Generic;
using System.

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

    public void Shout () {
        System.Console.WriteLine ("I'm " + _name + GetShoutSound ());
    }

    public virtual string GetShoutSound () {
        return "";
    }
}

public class Dog : Animal {
    public Dog (string name) : base (name) {

    }

    public void CatchDisc () {
        System.Console.WriteLine ("disc");
    }

    public override string GetShoutSound () {
        return " wooo";
    }
}

public class Cat : Animal {
    public Cat (string name) : base (name) {

    }

    public void CatchMouse () {
        System.Console.WriteLine ("mouse");
    }

    public override string GetShoutSound () {
        return " memo";
    }
}

public class Sheep : Animal {
    public Sheep (string name) : base (name) {

    }

    public override string GetShoutSound () {
        return " miemie";
    }
}

public class LECTURE2_3 {
    static void Main (string[] args) {
        // Animal[] animals = new Animal[3];
        var animals = new List<Animal> ();

        animals.Add (new Dog ("Tom"));
        animals.Add (new Cat ("Jane"));
        animals.Add (new Dog ("Alex"));
        animals.Add (new Sheep ("Lili"));

        for (var i = 0; i < animals.Count; i++) {
            animals[i].Shout ();
        }

    }
}