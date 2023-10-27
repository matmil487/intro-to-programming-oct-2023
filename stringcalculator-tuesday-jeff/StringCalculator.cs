
namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;

    public StringCalculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        // select - map
        var result = numbers.Split(',', '\n') // => ["1", "2", "3"...]
            .Select(int.Parse) // => [1,2,3,4,6]
            .Sum(); // Language Integrated Query

        _logger.Write(numbers);
        return result;

    }

    public int Add(string numbers, int startingAt)
    {
        return Add(startingAt.ToString() + ", " + numbers);
    }

    public int Add(string numbers, bool singleDigitOnly)
    {
        return -42;
    }

}

public interface ILogger
{
    void Write(string message);
}