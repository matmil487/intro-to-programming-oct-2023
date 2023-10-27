
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1, 2");
        Assert.Equal(3, result);
    }


    [Theory]
    [InlineData("3, 3", 6)]
    [InlineData("10, 3", 13)]
    [InlineData("103, 3", 106)]

    public void TwoDigits(string input, int expected)
    {

        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);

    }


}