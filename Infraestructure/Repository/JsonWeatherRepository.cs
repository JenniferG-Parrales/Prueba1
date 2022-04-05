using Domain.Entities.Weather;
using Domain.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class JsonWeatherRepository : IModel
    {
        public Root Info;
        string APIKey = "abefba56a9c6af23f7372440f4d1d63b";

        public Root GetWeather(string Ciudad)
        {

            try
            {
                using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",Ciudad,APIKey);
                var json = web.DownloadString(url);
                Info = JsonConvert.DeserializeObject<Root>(json);
                

                return Info;
                }
            }
            catch (Exception)
            {
                return Info = null;
            }
        }
        public string GetImageLocation(Weather w)
        {
            string imageLocation = $@"https://openweathermap.org/img/w/{w.Icon}.png";
            return imageLocation;
        }
    }
    }