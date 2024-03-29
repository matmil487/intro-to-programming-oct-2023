namespace LinkedOutTests;


public class UnitTest1
{
    [Fact]
    public void CanAddTwoSpecificIntegers()
    {
        // Given - "Arrange" - "Setup the world"
        int a = 10;
        int b = 20;
        int total;

        // When - "Act" - Poke at it and see what happens.
        total = a + b; // "System Under Test" ("SUT")


        // Then - "Assert" - Find out.
        Assert.Equal(30, total);

    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        int total = a + b;

        Assert.Equal(expected, total);
    }

    [Fact]
    public void CanFormatNames()
    {
        NameFormatter formatter = new NameFormatter();
        string fullName = formatter.FormatName("Han", "Solo");
        Assert.Equal("Solo, Han", fullName);
    }
}