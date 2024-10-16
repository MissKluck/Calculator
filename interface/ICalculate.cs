/*
* Interface means that we define the basic method(aka function) by giving it a name and a description of how we want the method to work
* Interface corresponds with the classes, in this case the Calculator class, where we can specify how we want the method to work(This creates a blueprint/template for how this specific method works)
* Then in the main program we can call on the method and use it to do what we want
*/ 
public interface ICalculator
{
    // Descriptions of the methods used for ICalculator

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