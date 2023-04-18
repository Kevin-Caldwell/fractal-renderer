namespace Fractals
{
    partial class FractalsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FractalDisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.DrawNewtonButton = new System.Windows.Forms.Button();
            this.FlatShadingNewtonButton = new System.Windows.Forms.Button();
            this.PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MandelbrotButton = new System.Windows.Forms.Button();
            this.MagnitudeMandelbrotButton = new System.Windows.Forms.Button();
            this.IterateMandelbrotButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetViewButton = new System.Windows.Forms.Button();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.ZoomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DrawFractalButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FractalDisplayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FractalDisplayPictureBox
            // 
            this.FractalDisplayPictureBox.Location = new System.Drawing.Point(12, 12);
            this.FractalDisplayPictureBox.Name = "FractalDisplayPictureBox";
            this.FractalDisplayPictureBox.Size = new System.Drawing.Size(600, 600);
            this.FractalDisplayPictureBox.TabIndex = 0;
            this.FractalDisplayPictureBox.TabStop = false;
            this.FractalDisplayPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalDisplayPictureBox_Paint);
            this.FractalDisplayPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FractalDisplayPictureBox_MouseClick);
            this.FractalDisplayPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FractalDisplayPictureBox_MouseDown);
            this.FractalDisplayPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FractalDisplayPictureBox_MouseMove);
            // 
            // DrawNewtonButton
            // 
            this.DrawNewtonButton.Location = new System.Drawing.Point(30, 19);
            this.DrawNewtonButton.Name = "DrawNewtonButton";
            this.DrawNewtonButton.Size = new System.Drawing.Size(102, 23);
            this.DrawNewtonButton.TabIndex = 1;
            this.DrawNewtonButton.Text = "Gradient Shading";
            this.DrawNewtonButton.UseVisualStyleBackColor = true;
            this.DrawNewtonButton.Click += new System.EventHandler(this.DrawNewtonButton_Click);
            // 
            // FlatShadingNewtonButton
            // 
            this.FlatShadingNewtonButton.Location = new System.Drawing.Point(156, 19);
            this.FlatShadingNewtonButton.Name = "FlatShadingNewtonButton";
            this.FlatShadingNewtonButton.Size = new System.Drawing.Size(102, 23);
            this.FlatShadingNewtonButton.TabIndex = 2;
            this.FlatShadingNewtonButton.Text = "Flat Shading";
            this.FlatShadingNewtonButton.UseVisualStyleBackColor = true;
            this.FlatShadingNewtonButton.Click += new System.EventHandler(this.FlatShadingNewtonButton_Click);
            // 
            // PowerTrackBar
            // 
            this.PowerTrackBar.Location = new System.Drawing.Point(76, 48);
            this.PowerTrackBar.Maximum = 20;
            this.PowerTrackBar.Minimum = 1;
            this.PowerTrackBar.Name = "PowerTrackBar";
            this.PowerTrackBar.Size = new System.Drawing.Size(182, 45);
            this.PowerTrackBar.TabIndex = 3;
            this.PowerTrackBar.Value = 3;
            this.PowerTrackBar.Scroll += new System.EventHandler(this.PowerTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DrawNewtonButton);
            this.groupBox1.Controls.Add(this.PowerTrackBar);
            this.groupBox1.Controls.Add(this.FlatShadingNewtonButton);
            this.groupBox1.Location = new System.Drawing.Point(798, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Newton Fractal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exponent";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MandelbrotButton);
            this.groupBox2.Controls.Add(this.MagnitudeMandelbrotButton);
            this.groupBox2.Location = new System.Drawing.Point(798, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mandelbrot Set";
            // 
            // MandelbrotButton
            // 
            this.MandelbrotButton.Location = new System.Drawing.Point(30, 19);
            this.MandelbrotButton.Name = "MandelbrotButton";
            this.MandelbrotButton.Size = new System.Drawing.Size(120, 23);
            this.MandelbrotButton.TabIndex = 1;
            this.MandelbrotButton.Text = "Gray Scale Shading";
            this.MandelbrotButton.UseVisualStyleBackColor = true;
            this.MandelbrotButton.Click += new System.EventHandler(this.MandelbrotButton_Click);
            // 
            // MagnitudeMandelbrotButton
            // 
            this.MagnitudeMandelbrotButton.Location = new System.Drawing.Point(153, 19);
            this.MagnitudeMandelbrotButton.Name = "MagnitudeMandelbrotButton";
            this.MagnitudeMandelbrotButton.Size = new System.Drawing.Size(111, 23);
            this.MagnitudeMandelbrotButton.TabIndex = 2;
            this.MagnitudeMandelbrotButton.Text = "Magnitude Shading";
            this.MagnitudeMandelbrotButton.UseVisualStyleBackColor = true;
            this.MagnitudeMandelbrotButton.Click += new System.EventHandler(this.MagnitudeMandelbrotButton_Click);
            // 
            // IterateMandelbrotButton
            // 
            this.IterateMandelbrotButton.Location = new System.Drawing.Point(798, 224);
            this.IterateMandelbrotButton.Name = "IterateMandelbrotButton";
            this.IterateMandelbrotButton.Size = new System.Drawing.Size(132, 23);
            this.IterateMandelbrotButton.TabIndex = 9;
            this.IterateMandelbrotButton.Text = "Iterate Current Fractal";
            this.IterateMandelbrotButton.UseVisualStyleBackColor = true;
            this.IterateMandelbrotButton.Click += new System.EventHandler(this.IterateMandelbrotButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iterations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // ResetViewButton
            // 
            this.ResetViewButton.Location = new System.Drawing.Point(819, 392);
            this.ResetViewButton.Name = "ResetViewButton";
            this.ResetViewButton.Size = new System.Drawing.Size(111, 23);
            this.ResetViewButton.TabIndex = 7;
            this.ResetViewButton.Text = "Reset View Region";
            this.ResetViewButton.UseVisualStyleBackColor = true;
            this.ResetViewButton.Click += new System.EventHandler(this.ResetViewButton_Click);
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Location = new System.Drawing.Point(872, 305);
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.IterationsTextBox.TabIndex = 8;
            this.IterationsTextBox.Text = "255";
            this.IterationsTextBox.TextChanged += new System.EventHandler(this.IterationsTextBox_TextChanged);
            // 
            // ZoomTextBox
            // 
            this.ZoomTextBox.Location = new System.Drawing.Point(872, 337);
            this.ZoomTextBox.Name = "ZoomTextBox";
            this.ZoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZoomTextBox.TabIndex = 10;
            this.ZoomTextBox.Text = "3";
            this.ZoomTextBox.TextChanged += new System.EventHandler(this.ZoomTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zoom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Scaled Coordinates:";
            // 
            // DrawFractalButton
            // 
            this.DrawFractalButton.Location = new System.Drawing.Point(954, 223);
            this.DrawFractalButton.Name = "DrawFractalButton";
            this.DrawFractalButton.Size = new System.Drawing.Size(114, 23);
            this.DrawFractalButton.TabIndex = 12;
            this.DrawFractalButton.Text = "Draw Current Fractal";
            this.DrawFractalButton.UseVisualStyleBackColor = true;
            this.DrawFractalButton.Click += new System.EventHandler(this.DrawFractalButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tip: Try increasing the number of iterations as you zoom in!";
            // 
            // FractalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 637);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DrawFractalButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IterateMandelbrotButton);
            this.Controls.Add(this.ZoomTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IterationsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetViewButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FractalDisplayPictureBox);
            this.Name = "FractalsForm";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.FractalDisplayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FractalDisplayPictureBox;
        private System.Windows.Forms.Button DrawNewtonButton;
        private System.Windows.Forms.Button FlatShadingNewtonButton;
        private System.Windows.Forms.TrackBar PowerTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MandelbrotButton;
        private System.Windows.Forms.Button MagnitudeMandelbrotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetViewButton;
        private System.Windows.Forms.TextBox IterationsTextBox;
        private System.Windows.Forms.Button IterateMandelbrotButton;
        private System.Windows.Forms.TextBox ZoomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DrawFractalButton;
        private System.Windows.Forms.Label label6;
    }
}

