
namespace StringCalculator;
public class StringCalculatorInterationTests
{
    private readonly StringCalculator _calculator;
    private readonly ILogger _logger;
    public StringCalculatorInterationTests()
    {
        _logger = Substitute.For<ILogger>();
        _calculator = new StringCalculator(_logger);
    }

    [Theory]
    [InlineData("1")]
    [InlineData("2")]
    public void WritesToLogger(string numbers)
    {
        // when 
        _calculator.Add(numbers);

        // then
        // Does "1" get written to the logger's write method?
        _logger.Received().Write(numbers);
    }

}
