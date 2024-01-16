using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    internal class PolyLine : Shape
    {
        private int[] points;

        public PolyLine(int x, int y, params int[] points) : base(x, y)
        {
            this.points = points;
        }

        public override void Show()
        {
            Console.Write("PolyLine: Points (" + x + ", " + y + "), ");
            for (int i = 0; i < points.Length; i += 2)
            {
                Console.Write("(" + points[i] + ", " + points[i + 1] + ")");
                if (i < points.Length - 2)
                    Console.Write(" -> ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string result = "PolyLine: Points (" + x + ", " + y + "), ";
            for (int i = 0; i < points.Length; i += 2)
            {
                result += "(" + points[i] + ", " + points[i + 1] + ")";
                if (i < points.Length - 2)
                    result += " -> ";
            }
            return result;
        }
    }
}
