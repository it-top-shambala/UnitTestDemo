namespace UnitTestDemo.Lib.Test;

public class CalculatorTest
{
    [Fact]
    public void Div_Positive_Test()
    {
        var x = 5.0;
        var y = 2.0;
        var expected = x / y;

        var calc = new Calculator();
        var actual = calc.Div(x, y);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Div_Exception_Test()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Div(5, 0));
    }
}