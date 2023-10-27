namespace DemoApi.Services;


public class TemperatureConverterService
{
    private readonly ICalculateFees _feeCalculator;

    public TemperatureConverterService(ICalculateFees feeCalculator)
    {
        _feeCalculator = feeCalculator;
    }

    public ConversionWithFeeResponse ConvertFtoC(float temp)
    {
        // Write the code you wish you had.
        // I am saying WHAT I need, not WHO I need.
        decimal fee = _feeCalculator.GetCurrentFee();

        var convertedTemp = TemperatureConverter.ConvertFromF(temp);
        return new ConversionWithFeeResponse(temp, convertedTemp, fee);
    }
}