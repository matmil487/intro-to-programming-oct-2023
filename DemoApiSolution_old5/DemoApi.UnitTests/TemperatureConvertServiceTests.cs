


using DemoApi.Services;

namespace DemoApi.UnitTests;
public class TemperatureConvertServiceTests
{

    [Fact]
    public void UsesTheFeeCalculator()
    {
        var fakeFeeCalculator = Substitute.For<ICalculateFees>();
        fakeFeeCalculator.GetCurrentFee().Returns(42.23M);
        var service = new TemperatureConverterService(fakeFeeCalculator);

        ConversionWithFeeResponse response = service.ConvertFtoC(100);


        Assert.Equal(42.23M, response.Fee);
    }


}





/* {
	"f":100,
	"c":37.77778,
	"fee": 0	
}


{
	"f":100,
	"c":37.77778
	"fee": 0.03	
} */
