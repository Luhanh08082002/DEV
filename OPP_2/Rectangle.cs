using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    internal class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle: Top Left (" + x + ", " + y + "), Width: " + width + ", Height: " + height);
        }

        public override string ToString()
        {
            return "Rectangle: Top Left (" + x + ", " + y + "), Width: " + width + ", Height: " + height;
        }
    }
}
