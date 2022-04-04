using Domain.Entities.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interface
{
    public interface IWeatherService
    {
        Root GetWeather(string Ciudad);
    }
}