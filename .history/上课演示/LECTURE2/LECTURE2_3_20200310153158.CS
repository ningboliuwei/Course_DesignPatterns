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

    // public void Shout () {
    //     System.Console.WriteLine ("I'm " + _name);
    // }
}

public class Dog : Animal {
    public Dog (string name) : base (name) {

    }

    public void CatchDisc () {
        System.Console.WriteLine ("飞盘");
    }

    public void Shout () {
        System.Console.WriteLine ("I'm " + _name + " wooo");
    }
}

public class Cat : Animal {
    public Cat (string name) : base (name) {

    }

    public void CatchMouse () {
        System.Console.WriteLine ("老鼠");
    }

    public void Shout () {
        System.Console.WriteLine ("I'm " + _name + " memw");
    }
}

public class LECTURE2_3 {
    static void Main (string[] args) {
        var dog1 = new Dog ("Tom");
        var cat1 = new Cat ("Jane");
        dog1.Shout ();
        dog1.CatchDisc ();
        cat1.Shout ();
        cat1.CatchMouse ();

    }
}