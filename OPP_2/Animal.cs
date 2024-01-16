using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    abstract class Animal
    {
        protected string type;

        public Animal(string type)
        {
            this.type = type;
        }

        public abstract string MakeSound();

        public virtual string GetInfo()
        {
            return "Type: " + type;
        }
    }
}
