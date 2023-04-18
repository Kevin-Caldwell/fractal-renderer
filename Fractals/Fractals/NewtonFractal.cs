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
    internal class NewtonFractal : Fractal
    {

        public Complex[] newtonSolutions = { new Complex(1, 0), new Complex(-1 / 2, 0.86602540378), new Complex(-1 / 2, -0.86602540378) };

        private int power = 3;

        public NewtonFractal(Bitmap image, Graphics g, PictureBox pictureBox, Rectangle renderArea, Point screenSize, int power) : base(image, g, pictureBox, renderArea, screenSize)
        {
            this.power = power;
            CalculateRoots(power);
        }

        public int Power { get { return power; } set { power = value; CalculateRoots(power); } }

        public void CalculateRoots(int power)
        {
            newtonSolutions = new Complex[power];
            for (int i = 0; i < power; i++)
            {
                newtonSolutions[i] = new Complex(Math.Cos(2 * i * Math.PI / power), Math.Sin(2 * i * Math.PI / power));
            }
        }

        public Complex iterate(Complex c)
        {
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                c -= (f(c) / fPrime(c));
            }
            return c;
        }

        private Complex f(Complex c)
        {
            Complex result = new Complex(1, 0);
            for (int i = 0; i < power; i++)
            {
                result *= c;
            }
            return result - 1;
        }

        private Complex fPrime(Complex c)
        {
            Complex result = new Complex(1, 0);
            for (int i = 0; i < power - 1; i++)
            {
                result *= c;
            }
            return power * result;
        }

        private Color GradientColoring(double x, double y)
        {
            double threshold = 0.01;
            Complex c = new Complex(x, y);
            Color PixelColor = Color.Black;
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                c -= (f(c) / fPrime(c));
                for (int i = 0; i < newtonSolutions.Length; i++)
                {
                    if (Math.Abs((c - newtonSolutions[i]).Magnitude) < threshold)
                    {
                        PixelColor = ColorFromHSV(360 * i / power, c.Magnitude / 2, 1);
                        break;
                    }
                }
            }
            return PixelColor;
        }

        private Color ThresholdColoring(double x, double y)
        {
            double threshold = 0.01;
            Complex c = new Complex(x, y);
            Color PixelColor = Color.Black;
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                c -= (f(c) / fPrime(c));
                for (int i = 0; i < newtonSolutions.Length; i++)
                {
                    if (Math.Abs((c - newtonSolutions[i]).Magnitude) < threshold)
                    {
                        PixelColor = ColorFromHSV(360 * i / power, 1, 1);
                        break;
                    }
                }
            }
            return PixelColor;
        }


        public void DrawGradientColoringNewtonFractal()
        {
            //g.Clear(Color.White);
            //pictureBox.Refresh();
            for (int i = 0; i < screenSize.X; i++)
            {
                for (int j = 0; j < screenSize.Y; j++)
                {
                    double x = renderArea.X + (((double) i / screenSize.X) - 0.5) * renderArea.Width;
                    double y = renderArea.Y + (((double) j / screenSize.Y) - 0.5) * renderArea.Height;

                    image.SetPixel(i, j, GradientColoring(x, y));
                }
                pictureBox.Refresh();
            }
            //pictureBox.Refresh();

        }

        public void DrawFlatColoringNewtonFractal()
        {
            //g.Clear(Color.White);
            for (int i = 0; i < screenSize.X; i++)
            {
                for (int j = 0; j < screenSize.Y; j++)
                {
                    double x = renderArea.X + (((double) i / screenSize.X) - 0.5) * renderArea.Width;
                    double y = renderArea.Y + (((double) j / screenSize.Y) - 0.5) * renderArea.Height;

                    image.SetPixel(i, j, ThresholdColoring(x, y));
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
                    DrawFlatColoringNewtonFractal();
                    break;
                case 2:
                    DrawGradientColoringNewtonFractal();
                    break;
                default:
                    break;
            }
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            Color color = Color.Black;
            if (hi == 0)
                color = Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                color = Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                color = Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                color = Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                color = Color.FromArgb(255, t, p, v);
            else
                color = Color.FromArgb(255, v, p, q);

            return color;
        }
    }
}
