using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_2
{
    abstract class Shape
    {
        protected int x;
        protected int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int deltaX, int deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public abstract void Show();
    }
}
