using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Participation03
{
    public class Tree : Plant
    {
        public Tree(string env, string type, string nm) : base(env, type, nm)
        {
        }
        public override string Sniff()
        {
            return "I like the smell of trees.";
        }
        }
}
