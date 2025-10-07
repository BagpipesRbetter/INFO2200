using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assingment03
{
    public abstract class Animal
    {
        private string _skinType;
        private string _foodType;

        public Animal(string skinType, string foodType)
        {
            _skinType = skinType;
            _foodType = foodType;
        }

        public string SkinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }
        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }
        public string Eat()
        {
            return "chomp chomp";
        }

        public virtual string Move()
        {
            return "hippity hop";
        }

        public string Reproduce()
        {
            return "create offspring";
        }
        public abstract string Unique();
    }
}
    

