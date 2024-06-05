using Microsoft.Extensions.Logging;
using Moq;
using BookYourRoom.Api.Controllers;
using System;
using Xunit;
using Shouldly;
using System.Linq;

namespace BookYourRoom.Api.Tests
{
    public class WeatherControllerTests
    {
        [Fact]
        public void Should_Return_Forcast_Results()
        {
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            var result = controller.Get();

            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(1);
            
        }
    }
}
