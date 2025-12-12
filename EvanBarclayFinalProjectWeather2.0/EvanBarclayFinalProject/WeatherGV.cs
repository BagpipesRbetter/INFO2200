using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvanBarclayFinalProject
{
    public static class WeatherGV
    {
        public static string CityName { get; set; } = string.Empty;
        public static double CurTemp { get; set; }
        public static double MinTemp { get; set; }
        public static double MaxTemp { get; set; }
        public static double WindSpeed { get; set; }
        public static string WindDir { get; set; } 
        public static double WindDirDeg { get; set; }
        public static double CurHum { get; set; }
        public static double CurPres { get; set; }
        public static double SunUp { get; set; }
        public static double SunSet { get; set; }
    }
}
