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
        private string _animalType;

        public Animal(string skinType, string foodType, string animalType)
        {
            _skinType = skinType;
            _foodType = foodType;
            _animalType = animalType;
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
        public string AnimalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }
        public string Eat()
        {
            return "Jaw Bone";
        }

        public virtual string Move()
        {
            return "Walks";
        }

        public virtual string Reproduce()
        {
            return "Lays Eggs";
        }
        public abstract string Unique();
    }
}
    

