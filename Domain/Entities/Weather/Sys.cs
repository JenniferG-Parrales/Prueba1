using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Weather
{
    public class Sys
    {
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public string Country { get; set; }
    }
}
