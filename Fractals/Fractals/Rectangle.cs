using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    internal class Rectangle
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }

        public Rectangle(double x, double y, double width, double height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
