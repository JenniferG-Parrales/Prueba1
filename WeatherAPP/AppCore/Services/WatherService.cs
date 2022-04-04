using AppCore.Interface;
using Domain.Entities.Weather;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class WatherService : IWeatherService
    {
        public IModel model;

        public WatherService(IModel model)
        {
            this.model = model;
        }
        public Root GetWeather(string Ciudad)
        {
            return model.GetWeather(Ciudad);
        }
    }
}