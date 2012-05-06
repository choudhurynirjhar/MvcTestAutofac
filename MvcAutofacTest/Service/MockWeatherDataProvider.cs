using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAutofacTest.Service
{
    public class MockWeatherDataProvider : IWeatherDataProvider
    {
        public IDictionary<string, string> GetWeatherInfo(int zipCode)
        {
            IDictionary<string, string> weather = new Dictionary<string, string>();
            weather.Add("High Temp", "90");
            weather.Add("Low Temp", "80");
            weather.Add("Record High", "100");
            weather.Add("Record Low", "40");
            return weather;
        }
    }
}