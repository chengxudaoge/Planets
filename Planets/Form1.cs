using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Planets
{
    public partial class Form1 : Form
    {
        double theta = 0;
        int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            double theta = 0;
            int x=0, y=0;
            while (true)
            {
                DrawIt(x, y, Color.White);
                x = (int)(100*Math.Cos(theta)+90);
                y = (int)(100*Math.Sin(theta)+90);
                DrawIt(x, y,Color.Green);
                theta = theta + 10*Math.PI / 180.0;
                Thread.Sleep(100);
            }
        }

        private void DrawIt(int x, int y, Color color)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
            //    50, 100, 150, 150);
            //graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            //graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            graphics.FillEllipse(brush1, new System.Drawing.Rectangle(50, 50, 100, 100));
            System.Drawing.SolidBrush brush2 = new System.Drawing.SolidBrush(color);
            graphics.FillEllipse(brush2, new System.Drawing.Rectangle(x, y, 20, 20));
            brush1.Dispose();
            brush2.Dispose();
            graphics.Dispose();
        }

        private void showdialog(object sender, EventArgs e)
        {
            MessageBox.Show("The calculations are complete", "My Application",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DrawIt(x, y, Color.White);
            x = (int)(100 * Math.Cos(theta) + 90);
            y = (int)(100 * Math.Sin(theta) + 90);
            //DrawIt(x, y, Color.Green);
            theta = theta + 10 * Math.PI / 180.0;

            planetcomponent planet = this.Controls.Find("planetcomponent1", true).FirstOrDefault() as planetcomponent;
            planet.Location= new Point(x, y);
        }
    }
}
