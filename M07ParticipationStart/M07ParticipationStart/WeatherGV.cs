using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07ParticipationStart
{
    // change modifer to public and make a static class
    // static class allows calling methods of the class
    // without instantiating an object of the class
    public static class WeatherGV
    {
        public static string CityName { get; set; } = string.Empty;
        public static double CurTemp { get; set; }
        public static double MinTemp { get; set; }
        public static double MaxTemp { get; set; }
    }
}
