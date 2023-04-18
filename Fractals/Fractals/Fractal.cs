using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    internal class Fractal
    {
        protected Bitmap image;
        protected Graphics g;
        protected PictureBox pictureBox;
        protected Rectangle renderArea;
        protected Point screenSize;
        protected int maxIterations = 255;

        public int MaxIterations { get { return maxIterations; } set { maxIterations = value; } }

        public Fractal(Bitmap image, Graphics g, PictureBox pictureBox, Rectangle bounds, Point screenSize)
        {
            this.image = image;
            this.g = g;
            this.pictureBox = pictureBox;
            this.renderArea = bounds;
            this.screenSize = screenSize;
        }

        public virtual void DrawFractal(int shading)
        {

        }

    }
}
