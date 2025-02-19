using Xunit;
using MyDotnetApp.Controllers;
using Microsoft.AspNetCore.Mvc;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_ReturnsSuccessMessage()
    {
        var controller = new WeatherForecastController();
        var result = controller.Get() as OkObjectResult;
        Assert.NotNull(result);
        Assert.Equal("Weather forecast fetched successfully.", result.Value);
    }
}