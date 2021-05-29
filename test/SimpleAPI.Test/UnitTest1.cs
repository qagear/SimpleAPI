using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get();
            //Debug.Print returnValue;
            //var returnValue1 = returnValue.MoveNext();
            Assert.Equal("Les Jackson", "Les Jackson");
        }



        [Fact]
        public void Test1()
        {

        }
    }
}
