using Domain.Entities.Weather;
using Domain.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class JsonWeatherRepository : IModel
    {
        public Root Info;
        string APIKey = "570496f54018376c20a198c2ffc0bb1d";

        public Root GetWeather(string Ciudad)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={Ciudad}&appid={APIKey0}");
                var json = web.DownloadString(url);
                Info = JsonConvert.DeserializeObject<Root>(json);
                return Info;
            }
        }
    }
}
