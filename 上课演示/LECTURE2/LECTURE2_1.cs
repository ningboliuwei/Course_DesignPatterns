public class Number
{
    public int Value { get; set; }

    public int ValueSquare => Value * Value;

    public void AddNumber(int number) {
        Value = Value + number;
    }
}

public class Script
{
    // static void Main (string[] args) {
    //     var number1 = new Number ();
    //     number1.Value = 12;
    //     System.Console.WriteLine (number1.Value);
    //     System.Console.WriteLine (number1.ValueSquare);
    //     number1.AddNumber (100);
    //     System.Console.WriteLine (number1.Value);
    // }
}