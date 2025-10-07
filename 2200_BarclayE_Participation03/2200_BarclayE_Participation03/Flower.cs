using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Participation03
{
    public class Flower : Plant
    {
        public Flower(string env, string typ, string nm) : base(env, typ, nm)
        {
        }
        public override string Sniff()
        {
            return "I like the smell of flowers";

        }
        }
}
