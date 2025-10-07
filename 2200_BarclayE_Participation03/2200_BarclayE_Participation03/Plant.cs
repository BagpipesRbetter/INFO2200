using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_BarclayE_Participation03
{
    public class Plant
    {
        private string _environment;
        private string _type;
        private string _name;
        // constructor
        public Plant(string env, string typ, string nm)
        {
            _environment = env;
            _type = typ;
            _name = nm;
        }
        // properties
        public string Environment
        {
            get { return _environment; }
            set { _environment = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public virtual string Sniff()
        {
            return "Let's sniff plants.";
        }
    }
}
