using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assingment03
{
    public class Stork : Animal
    {
        public Stork(string skinType, string foodType, string animalType) : base(skinType, foodType, animalType)
        {
        }
        public override string Move()
        {
            return "flies in the sky";
        }
        public override string Unique()
        {
            return "Lives In Swamps And Somtimes Eats Juvenile Crocodiles";
        }
    }
}
