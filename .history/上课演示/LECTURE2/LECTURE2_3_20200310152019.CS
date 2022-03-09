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

    public string Shout () {
        return "I'm " + Name + ", wowww~";
    }
}

public class LECTURE2_3 {
    static void Main (string[] args) {
        var animal1 = new Animal ();

    }
}