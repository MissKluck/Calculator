﻿namespace Oppgaver_til_18._10___Klasser__Interfaces_og_metoder;

class Program
{
    static void Main(string[] args)
    {
        // Creates an object from the calculator template, gives it the name "calculator" and defines that it works as the method calculator
        Calculator calculator = new Calculator();
        
            //vi trenger en variabel for at den kan printe resultatet
            double result = 0;

            // the computer always reads input as string, not double or int even though we write 1 in the terminal because the computer reads it as "1"
            // we tell the computer that it should read input from the terminal and then convert the terminal from string to double by using conver.todouble
            Console.WriteLine("Enter first number");
            string? input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            Console.WriteLine("Enter one of these +, -, * or /");
            string? operation = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string? input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            // tells the computer to add or subtract using the methods created with ICalculate and Calculator
            switch(operation)
            {
                case "+":
                result = calculator.AddNumbers(num1, num2);
                break;

                case "-":
                result = calculator.SubtractNumbers(num1, num2);
                break;

                case "*":
                result = calculator.MultiplyNumbers(num1, num2);
                break;

                case "/":
                result = calculator.DivideNumbers(num1, num2);
                break;
            }
            Console.WriteLine("The result is " + result);
    }
}
