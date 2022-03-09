using System;

class Number {
    private int _numberValue;

    public int Value {
        get {
            return _numberValue;
        };
        set {
            _numberValue = value;
        }
    }

    public int ValueSquare {
        get {
            return _numberValue * _numberValue;
        }
    }
}

public class Script {
    static void Main (string[] args) {
        var number1 = new Number ();
        number1.Value = 12;
        System.Console.WriteLine (number1.Value);
    }
}