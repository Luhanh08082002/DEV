using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP_TUAN1
{
    internal class equaton
    {
        public equaton() {
            Console.WriteLine("tim nghiem cua phuong trinh ax2 + bx + c = 0");
            Console.WriteLine("nhap a :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap b :");
              double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap c");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"phuong trinh cua chung ta {a}x2 + {b}x + {c} = 0");

            

        }
    }
}
