using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Student
    {
        private int gpa;

        public int Gpa
        { 
            get { return gpa; }
            set { gpa = value; }    
        }

        public void DisplayStudent()
        {

        }
        public void Input()
        {

        }

        public Student(int gpa)
        {
            this.gpa = gpa;
        }

    }
}
