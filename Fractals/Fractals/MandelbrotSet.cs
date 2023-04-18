using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    internal class MandelbrotSet : Fractal
    {

        public MandelbrotSet(Bitmap image, Graphics g, PictureBox pictureBox, Rectangle renderArea, Point screenSize) : base(image, g, pictureBox, renderArea, screenSize)
        {
        }

        private Complex function(Complex c, Complex c0)
        {
            //return c * c + c0;
            return c * c + c0;
        }

        private Color GrayscaleColoring(Complex c0)
        {
            Complex c = c0;
            Color color = Color.White;
            int i = 0;
            for (i = 0; i < maxIterations; i++)
            {
                if (c.Magnitude > 2)
                {
                    break;
                }
                c = function(c, c0);
            }

            i = (int) ((double) i / maxIterations * 255);
            if (i < 255)
            {
                color = Color.FromArgb(i, i, i);
            }
            return color;
        }

        private Color GradientColoring(Complex c0)
        {
            Complex c = c0;
            Color color = Color.Black;
            int i = 0;
            for (i = 0; i < maxIterations; i++)
            {
                if (c.Magnitude > 2)
                {
                    break;
                }
                c = function(c, c0);
            }
            int a = 0;
            if (c.Magnitude < 10)
            {
                a = (int) (c.Magnitude * 255 / 10);
            }
            return Color.FromArgb(a, a, 100);
        }
        public void DrawGrayScaleColoringMandelbrotSet()
        {
            for (int i = 0; i < screenSize.X; i++)
            {
                for (int j = 0; j < screenSize.Y; j++)
                {
                    double x = renderArea.X + (((double) i / screenSize.X) - 0.5) * renderArea.Width;
                    double y = renderArea.Y + (((double) j / screenSize.Y) - 0.5) * renderArea.Height;

                    image.SetPixel(i, j, GrayscaleColoring(new Complex(x, y)));
                }
                pictureBox.Refresh();
            }
            //pictureBox.Refresh();
        }
        public void DrawGradientColoringMandelbrotSet()
        {
            for (int i = 0; i < screenSize.X; i++)
            {
                for (int j = 0; j < screenSize.Y; j++)
                {
                    double x = renderArea.X + (((double) i / screenSize.X) - 0.5) * renderArea.Width;
                    double y = renderArea.Y + (((double) j / screenSize.Y) - 0.5) * renderArea.Height;

                    image.SetPixel(i, j, GradientColoring(new Complex(x, y)));
                }
                pictureBox.Refresh();
            }
            //pictureBox.Refresh();
        }

        public override void DrawFractal(int shading)
        {
            switch (shading)
            {
                case 1:
                    DrawGrayScaleColoringMandelbrotSet();
                    break;
                case 2:
                    DrawGradientColoringMandelbrotSet();
                    break;
                default:
                    break;
            }

        }

    }
}
