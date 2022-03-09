public class Animal {
    private string _name;

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
        Console.WriteLine ("I'm " + _name);
    }
}

public class Dog : Animal {

}

public class LECTURE2_3 {
    static void Main (string[] args) {
        var dog1 = new Dog ();
        dog1.Shout ();

    }
}