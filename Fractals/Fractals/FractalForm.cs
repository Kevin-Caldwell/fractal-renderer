using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class FractalsForm : Form
    {
        private int _screenWidth, _screenHeight;

        private Bitmap fractalImageBitmap;
        private Graphics fractalDrawingSurface;

        private Fractal currentFractal;
        private int shading = 1;
        private Rectangle bounds;
        private int power = 3;

        private Point mouseCoords;
        private int maxIterations = 255;
        private double zoom = 3;

        public FractalsForm()
        {
            InitializeComponent();
            _screenWidth = FractalDisplayPictureBox.Height;
            _screenHeight = _screenWidth;


            fractalImageBitmap = new Bitmap(_screenWidth, _screenHeight);
            fractalDrawingSurface = Graphics.FromImage(fractalImageBitmap);

            bounds = new Rectangle(-0.5, 0, 2, 2);
            mouseCoords = new Point(0, 0);

            currentFractal = new MandelbrotSet(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight));
            currentFractal.DrawFractal(shading);
        }

        private void DrawNewtonButton_Click(object sender, EventArgs e)
        {
            shading = 2;
            currentFractal = new NewtonFractal(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight), power);
            currentFractal.MaxIterations = maxIterations;
            currentFractal.DrawFractal(shading);
        }


        private void FlatShadingNewtonButton_Click(object sender, EventArgs e)
        {
            currentFractal = new NewtonFractal(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight), power);
            shading = 1;
            currentFractal.MaxIterations = maxIterations;
            currentFractal.DrawFractal(shading);
        }

        private void PowerTrackBar_Scroll(object sender, EventArgs e)
        {
            if (currentFractal is NewtonFractal newton)
            {
                newton.Power = PowerTrackBar.Value;

            }
            power = PowerTrackBar.Value;
        }

        private void FractalDisplayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(fractalImageBitmap, 0, 0);
            double zoomWidth = _screenWidth / zoom;
            double zoomHeight = _screenHeight / zoom;
            e.Graphics.DrawRectangle(new Pen(Color.Coral),
                new System.Drawing.Rectangle((int) (mouseCoords.X - zoomWidth / 2),
                                             (int) (mouseCoords.Y - zoomHeight / 2),
                                            (int) zoomWidth, (int) zoomHeight));
        }

        private void MandelbrotButton_Click(object sender, EventArgs e)
        {
            currentFractal = new MandelbrotSet(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight));
            shading = 1;
            currentFractal.MaxIterations = maxIterations;
            currentFractal.DrawFractal(shading);
        }

        private void FractalDisplayPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Complex a = newton.iterate(new Complex(e.Location.X, e.Location.Y));
        }

        private void FractalDisplayPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void FractalDisplayPictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            bounds.X += (double) (e.Location.X - _screenWidth / 2) / _screenWidth * bounds.Width;
            bounds.Y += (double) (e.Location.Y - _screenHeight / 2) / _screenHeight * bounds.Height;
            bounds.Width /= zoom;
            bounds.Height /= zoom;

            currentFractal.DrawFractal(shading);
        }

        private void FractalDisplayPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            double x = bounds.X + (double) (e.Location.X - _screenWidth / 2) / _screenWidth * bounds.Width;
            double y = bounds.Y - (double) (e.Location.Y - _screenHeight / 2) / _screenHeight * bounds.Height;

            label3.Text = "(" + x + "," + y + ")";
            mouseCoords.X = e.X;
            mouseCoords.Y = e.Y;
            FractalDisplayPictureBox.Refresh();
        }

        private void ResetViewButton_Click(object sender, EventArgs e)
        {
            bounds.X = 0;
            bounds.Y = 0;
            bounds.Width = 10;
            bounds.Height = 10;
            currentFractal.DrawFractal(shading);
        }

        private void MagnitudeMandelbrotButton_Click(object sender, EventArgs e)
        {
            currentFractal = new MandelbrotSet(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight));
            currentFractal.MaxIterations = maxIterations;
            shading = 2;
            currentFractal.DrawFractal(shading);
        }

        

        private void IterationsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IterationsTextBox.Text.Length > 0)
            {
                int.TryParse(IterationsTextBox.Text, out maxIterations);
            }
            currentFractal.MaxIterations = maxIterations;
            //currentFractal.DrawFractal(shading);

        }

        private void IterateMandelbrotButton_Click(object sender, EventArgs e)
        {
            if (IterationsTextBox.Text.Length != 0)
            {
                for (int i = 1; i < int.Parse(IterationsTextBox.Text); i++)
                {

                    //currentFractal = new MandelbrotSet(fractalImageBitmap, fractalDrawingSurface, FractalDisplayPictureBox, bounds, new Point(_screenWidth, _screenHeight));
                    currentFractal.MaxIterations = i;
                    shading = 1;
                    currentFractal.DrawFractal(shading);
                }
            }

        }

        private void ZoomTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ZoomTextBox.Text.Length > 0)
            {
                double.TryParse(ZoomTextBox.Text, out zoom);
            }
        }

        private void DrawFractalButton_Click(object sender, EventArgs e)
        {
            currentFractal.DrawFractal(shading);
        }

        private void saveImage(string name)
        {
            fractalImageBitmap.Save(name + ".jpg");
        }
    }
}
