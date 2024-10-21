public class Calculator : ICalculator
{
    // The physical code for how we want the method to behave when called upon aka what we want the method to do
    public double AddNumbers(double a, double b)
    {
        return a + b;
    }

    public double SubtractNumbers(double a, double b)
    {
        return a - b;
    }

    public double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    public double DivideNumbers(double a, double b)
    {
        if (b == 0 || b.Equals(0))
        {
            Console.WriteLine("Cannot divide by 0");
            throw new Exception();
        }
        else
        {
            return a / b;
        }
    }
}