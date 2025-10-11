using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assingment03
{
    public class Dog : Animal
    {
        public Dog(string skinType, string foodType, string animalType) : base(skinType, foodType, animalType)
        {
        }
        public override string Move()
        {
            return "runs on all fours";
        }
        public override string Reproduce()
        {
            return "Gives Birth to Live Young";
        }
        public override string Unique()
        {
            return "Man's Best Friend";
        }
    }
}
