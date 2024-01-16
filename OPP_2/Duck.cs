using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    class Duck : Animal
    {
        public string Name { get; set; }

        public Duck(string name) : base("Bird")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Quack!";
        }

        public void Swim(string thing)
        {
            Console.WriteLine(Name + " is swimming in " + thing + ".");
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", Name: " + Name;
        }
    }
}
