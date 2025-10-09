using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Assingment03
{
    public class Dog : Animal
    {
        public Dog(string skinType, string foodType) : base(skinType, foodType)
        {
        }
        public override string Move()
        {
            return "runs on all fours";
        }
        public override string Unique()
        {
            return "Wags Tail";
        }
    }
}
