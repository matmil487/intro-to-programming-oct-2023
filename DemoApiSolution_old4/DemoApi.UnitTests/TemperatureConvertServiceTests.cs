
using DemoApi.Services;

namespace DemoApi.UnitTests;
public class TemperatureConvertServiceTests
{

	[Fact]
	public void NoFeeOnWeekends()
	{
		var service = new TemperatureConverterService();

		ConversionWithFeeResponse response = service.ConvertFtoC(100F);

		Assert.Equal(0, response.Fee);
	}

	[Fact]
	public void FeeOnOtherDays()
	{
		var service = new TemperatureConverterService();

		ConversionWithFeeResponse response = service.ConvertFtoC(100F);

		Assert.Equal(.03M, response.Fee);
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
