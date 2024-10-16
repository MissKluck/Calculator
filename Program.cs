namespace Oppgaver_til_18._10___Klasser__Interfaces_og_metoder;

class Program
{
    static void Main(string[] args)
    {
        // Creates an object from the calculator template, gives it the name "calculator" and defines that it works as the method calculator
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.AddNumbers(2, 5));

        Console.WriteLine(calculator.AddNumbers(5, 50));

        Console.WriteLine("Hello, World!");
    }
}
