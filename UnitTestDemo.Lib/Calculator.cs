namespace UnitTestDemo.Lib;

public class Calculator
{
    public double Div(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Делить на ноль нельзя!");
        }

        return x / y;
    }
}