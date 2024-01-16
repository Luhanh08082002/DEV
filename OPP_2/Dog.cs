using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    class Dog : Animal
    {
        private string breed;
        public string Name { get; set; }

        public Dog(string name, string breed) : base("Mammal")
        {
            Name = name;
            this.breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof!";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", Name: " + Name + ", Breed: " + breed;
        }
    }
}
