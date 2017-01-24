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


        string[] planetlist = new string[10];
        int planetcount = 0;
        double theinterval = 0.1;
        double thetime = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;


        private void planet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        //private void planet_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        planetcomponent1.Left = e.X + planetcomponent1.Left - MouseDownLocation.X;
        //        planetcomponent1.Top = e.Y + planetcomponent1.Top - MouseDownLocation.Y;
        //    }
        //}
        private void start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
            //double theta = 0;
            //int x=0, y=0;
            //while (true)
            //{
            //    DrawIt(x, y, Color.White);
            //    x = (int)(100*Math.Cos(theta)+90);
            //    y = (int)(100*Math.Sin(theta)+90);
            //    DrawIt(x, y,Color.Green);
            //    theta = theta + 10*Math.PI / 180.0;
            //    Thread.Sleep(100);
            //}
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

        private void addPlanet_Click(object sender, EventArgs e)
        {
            planetcomponent pc = new planetcomponent();
            pc.Location = new Point(50, 50);
            this.Controls.Add(pc);
            pc.Name = "Planet" + planetcount.ToString();
            pc.showmydialog(pc, EventArgs.Empty);
            //you need to update the list if name is changed in the future
            planetlist[planetcount] = pc.Name;
            planetcount++;
        }

        private void Calculate()
        { }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Calculate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////DrawIt(x, y, Color.White);
            //x = (int)(100 * Math.Cos(theta) + 90);
            //y = (int)(100 * Math.Sin(theta) + 90);
            ////DrawIt(x, y, Color.Green);
            //theta = theta + 10 * Math.PI / 180.0;
            theinterval = Convert.ToDouble(interval.Text);
            double thescale = Convert.ToDouble(scale.Text);
           thetime = thetime + theinterval;
            time.Text = thetime.ToString();
            foreach (string planetname in planetlist)
            {
                double x = 0, y = 0;
                double vx, vy;
                double mass;
                if (planetname !=null)
                {
                    planetcomponent planet = this.Controls.Find(planetname, true).FirstOrDefault() as planetcomponent;
                    //planet.Location = new Point(x , y);
                    x=planet.Location.X*thescale;
                    y = planet.Location.Y*thescale;
                    vx = planet.xvelocity;
                    vy = planet.yvelocity;
                    mass = planet.mass;
                    foreach (string otherplanetname in planetlist)
                    {
                        double ox = 0, oy = 0;
                        double omass;

                        if (otherplanetname != null && !String.Equals(planetname, otherplanetname) )
                            //if (otherplanetname != null && !String.Equals(planetname, otherplanetname))
                            {
                                planetcomponent otherplanet = this.Controls.Find(otherplanetname, true).FirstOrDefault() as planetcomponent;
                            ox = otherplanet.Location.X*thescale;
                            oy = otherplanet.Location.Y*thescale;
                            omass = otherplanet.mass;
                            double r = Math.Sqrt((ox - x) * (ox - x) + (oy - y) * (oy - y));
                            double r3 = Math.Pow(r, 3);
                            double ax = -omass * 6.67408E-11 * (x - ox) / r3;
                            double ay = -omass * 6.67408E-11 * (y - oy) / r3;
                            double nvx = vx + ax * theinterval;
                            double nvy = vy + ay * theinterval;
                            double nx = x + nvx * theinterval;
                            double ny = y + nvy * theinterval;
                            planet.Location = new Point(Convert.ToInt32(nx/thescale), Convert.ToInt32(ny/thescale));
                            planet.xvelocity = Convert.ToInt32(nvx);
                            planet.yvelocity = Convert.ToInt32(nvy);
                        }
                    }
                }
            }
        }
    }
}
