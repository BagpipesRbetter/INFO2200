using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assingment03
{
    public class Axolotl : Animal
    {
        public Axolotl(string skinType, string foodType) : base(skinType, foodType)
        {
        }
        public override string Move()
        {
            return "swims in the water";
        }
        public override string Unique()
        {
            return "Regenerates Limbs";
        }
    }
}
