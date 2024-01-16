using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    class Cat : Animal
    {
        public string Name { get; set; }

        public Cat(string name) : base("Mammal")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }

        public void Climb(string thing)
        {
            Console.WriteLine(Name + " is climbing " + thing + ".");
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", Name: " + Name;
        }
    }
}
