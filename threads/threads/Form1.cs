using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threads
{
    public partial class Form1 : Form
    {
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush purple = new SolidBrush(Color.Purple);
        int xr = 171, yr = 52, xg = 539, yg = 52, xb = 171, yb = 274, xp = 539, yp = 274;
        public Form1()
        {
            InitializeComponent();
        }

        void initial_drawing()
        {
            Graphics g = pictureBox_Panel.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Black), 133, 63, 100, 100);
            g.DrawEllipse(new Pen(Color.Black), 501, 63, 100, 100);
            g.DrawEllipse(new Pen(Color.Black), 133, 285, 100, 100);
            g.DrawEllipse(new Pen(Color.Black), 501, 285, 100, 100);
            g.FillEllipse(red, xr, yr, 25, 25);
            g.FillEllipse(green, xg, yg, 25, 25);
            g.FillEllipse(blue, xb, yb, 25, 25);
            g.FillEllipse(purple, xp, yp, 25, 25);
        }

        void rotate_red()
        {
            Graphics g = pictureBox_Panel.CreateGraphics();
            double alpha;
            for (alpha = Math.PI * 1.50; alpha <= 3.5 * Math.PI; alpha += 0.02)
            {
                g.FillEllipse(new SolidBrush(Color.White), xr, yr, 25, 25);
                g.DrawEllipse(new Pen(Color.Black), 133, 63, 100, 100);
                xr = (int)(171 + 50 * Math.Cos(alpha));
                yr = (int)(102 + 50 * Math.Sin(alpha));
                g.FillEllipse(red, xr, yr, 25, 25);
                Thread.Sleep(10);
            }
        }

        void rotate_green()
        {
            Graphics g = pictureBox_Panel.CreateGraphics();
            double alpha;
            for (alpha = Math.PI * 1.50; alpha <= 3.5 * Math.PI; alpha += 0.02)
            {
                g.FillEllipse(new SolidBrush(Color.White), xg, yg, 25, 25);
                g.DrawEllipse(new Pen(Color.Black), 501, 63, 100, 100);
                xg = (int)(539 + 50 * Math.Cos(alpha));
                yg = (int)(102 + 50 * Math.Sin(alpha));
                g.FillEllipse(green, xg, yg, 25, 25);
                Thread.Sleep(10);
            }
        }

        void rotate_blue()
        {
            Graphics g = pictureBox_Panel.CreateGraphics();
            double alpha;
            for (alpha = Math.PI * 1.50; alpha <= 3.5 * Math.PI; alpha += 0.02)
            {
                g.FillEllipse(new SolidBrush(Color.White), xb, yb, 25, 25);
                g.DrawEllipse(new Pen(Color.Black), 133, 285, 100, 100);
                xb = (int)(171 + 50 * Math.Cos(alpha));
                yb = (int)(324 + 50 * Math.Sin(alpha));
                g.FillEllipse(blue, xb, yb, 25, 25);
                Thread.Sleep(10);
            }
        }

        void rotate_purple()
        {
            Graphics g = pictureBox_Panel.CreateGraphics();
            double alpha;
            for (alpha = Math.PI * 1.50; alpha <= 3.5 * Math.PI; alpha += 0.02)
            {
                g.FillEllipse(new SolidBrush(Color.White), xp, yp, 25, 25);
                g.DrawEllipse(new Pen(Color.Black), 501, 285, 100, 100);
                xp = (int)(539 + 50 * Math.Cos(alpha));
                yp = (int)(324 + 50 * Math.Sin(alpha));
                g.FillEllipse(purple, xp, yp, 25, 25);
                Thread.Sleep(10);
            }
        }

        private void pictureBox_Panel_Click(object sender, EventArgs e)
        {
            initial_drawing();
        }

        private void button_WithoutThread_Click(object sender, EventArgs e)
        {
            rotate_red();
            rotate_green();
            rotate_blue();
            rotate_purple();
        }

        private void button_WithThread_Click(object sender, EventArgs e)
        {
            Thread threadred = new Thread(() => rotate_red());
            threadred.Start();
            Thread threadgreen = new Thread(() => rotate_green());
            threadgreen.Start();
            Thread threadblue = new Thread(() => rotate_blue());
            threadblue.Start();
            Thread threadpurple = new Thread(() => rotate_purple());
            threadpurple.Start();
        }
    }
}
