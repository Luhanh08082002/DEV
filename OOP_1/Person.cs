using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Person
    {
        private int age;
        private string name;
        public int Age
        { 
            get { return age; } 
            set { age = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void DisplayPerson()
        {
        }
        public void Input()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
