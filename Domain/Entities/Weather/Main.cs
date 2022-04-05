using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Weather
{
    public class Main
    {
        public double Temp { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public double Preasure { get; set; }
        public double Humedity { get; set; }
        public int Visibility { get; set; }
        public int TimeZone { get; set; }
    }
}
