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
            PercentWater = double.Parse(foodArray[4]);
            Energy = double.Parse(foodArray[5]);
            Protien = double.Parse(foodArray[6]);
            Carbohydrate = double.Parse(foodArray[7]);
            Fiber = double.Parse(foodArray[8]);
            Cholesterol = double.Parse(foodArray[9]);
            TotalFat = double.Parse(foodArray[10]);
            SaturatedFat = double.Parse(foodArray[11]);
            MonounsaturatedFat = double.Parse(foodArray[12]);
            PolyunsaturatedFat = double.Parse(foodArray[13]);
            Iron = double.Parse(foodArray[14]);
            Magnesium = double.Parse(foodArray[15]);
            Sodium = double.Parse(foodArray[15]);
            Phosphorus = double.Parse(foodArray[16]);
            CaPRation = double.Parse(foodArray[17]);
            Potassium = double.Parse(foodArray[18]);
            Zinc = double.Parse(foodArray[19]);
            Niacin = double.Parse(foodArray[20]);
            Thiamin = double.Parse(foodArray[21]);
            Riboflavin = double.Parse(foodArray[22]);
            VitaminA = double.Parse(foodArray[23]);
            VitaminB6 = double.Parse(foodArray[24]);
            VitaminC = double.Parse(foodArray[25]);
            FoodType = foodArray[26];

        }
        public string FoodName { get; set; }
        public double Calcium { get; set; }
        public string ServingSize { get; set; }
        public double Weight { get; set; }
        public double PercentWater { get; set; }
        public double Energy { get; set; }
        public double Protien { get; set; }
        public double Carbohydrate { get; set; }
        public double Fiber { get; set; }
        public double Cholesterol { get; set; }
        public double TotalFat { get; set; }
        public double SaturatedFat { get; set; }
        public double MonounsaturatedFat { get; set; }
        public double PolyunsaturatedFat { get; set; }
        public double Iron { get; set; }
        public double Magnesium { get; set; }
        public double Sodium { get; set; }
        public double Phosphorus { get; set; }
        public double CaPRation { get; set; }
        public double Potassium { get; set; }
        public double Zinc { get; set; }
        public double Niacin { get; set; }
        public double Thiamin { get; set; }
        public double Riboflavin { get; set; }
        public double VitaminA { get; set; }
        public double VitaminB6 { get; set; }
        public double VitaminC { get; set; }
        public string FoodType { get; set; }

    }

}
