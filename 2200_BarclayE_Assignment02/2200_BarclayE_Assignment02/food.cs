using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assignment02
{
    internal class food
    {
        // constructor for recieving and array of strings
        public food(string[] foodArray)
        {
            FoodName = foodArray[0];
            Calcium = double.Parse(foodArray[1]);
            ServingSize = foodArray[2];
            Weight = double.Parse(foodArray[3]);
        }
        public string FoodName { get; set; }
        public double Calcium { get; set; }
        public string ServingSize { get; set; }
        public double Weight { get; set; }

    }

}
