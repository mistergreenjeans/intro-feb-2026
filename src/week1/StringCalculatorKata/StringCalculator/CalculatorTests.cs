

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("223", 223)]
    public void SingleDigit(string input, int expected)
    {
        var calc = new Calculator();
        var result = calc.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,4", 6)]
    public void DoubleAdd(string input, int expected)
    {
        var calc = new Calculator();
        var result = calc.Add(input);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,4,6", 12)]
    [InlineData("223,1,1,1,1,4", 231)]
    public void MultiAdd(string input, int expected)
    {
        var calc = new Calculator();
        var result = calc.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("2,4\n6", 12)]
    [InlineData("223\n1\n1\n1,1,4", 231)]
    public void MixDelimiters(string input, int expected)
    {
        var calc = new Calculator();
        var result = calc.Add(input);
        Assert.Equal(expected, result);
    }
}
