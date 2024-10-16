public interface ICalculator
{
    /// <summary>
    /// A method that returns the sum of A + B
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a + b</returns>
    public double AddNumbers(double a, double b);
    /// <summary>
    /// A method that returns the sum of A - B
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a - b</returns>
    public double SubtractNumbers(double a, double b);

}