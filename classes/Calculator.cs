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
}