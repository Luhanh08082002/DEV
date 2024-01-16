using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATTAP_TAILOp
{
    class Student:People
    {
        private string Department;
        private double AverageScore;

        public void SetDepartment(string department)
        {
            Department = department;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public void SetAverageScore(double averageScore)
        {
            AverageScore = averageScore;
        }

        public double GetAverageScore()
        {
            return AverageScore;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student ID: " + GetID());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Average Score: " + AverageScore);
            Console.WriteLine();
        }
    }

}
