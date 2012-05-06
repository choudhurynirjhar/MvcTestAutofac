using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcAutofacTest.Service
{
    public interface IWeatherDataProvider
    {
        IDictionary<string, string> GetWeatherInfo(int zipCode);
    }
}
