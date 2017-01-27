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
using System.Xml.Serialization;
using System.Xml;

namespace Planets
{
    public partial class Form1 : Form
    {


        string[] planetlist = new string[10];
        int planetcount = 0;
        double theinterval = 0.1;
        double thetime = 0;
        double thescale = 1;
        Int32 oldx=0, oldy=0;

        public class APlanet
        {
            [XmlAttribute("name")]
            public string Name { get; set; }
            public double xlocation { get; set; }
            public double ylocation { get; set; }
            public double xvelocity { get; set; }
            public double yvelocity { get; set; }
            public double mass { get; set; }

        }

        [XmlRoot("info")]
        public class Info
        {
            [XmlArray("planets")]
            [XmlArrayItem("planet")]
            public List<APlanet> Planets { get; set; }
            public double interval { get; set; }
            public double scale { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            List<APlanet> planets;
            var serializer = new XmlSerializer(typeof(Info));
            using (var reader = XmlReader.Create("info.xml"))
            {
                Info info = (Info)serializer.Deserialize(reader);
                planets = info.Planets;
                theinterval = info.interval;
                thescale = info.scale;
            }
            interval.Text = theinterval.ToString();
            scale.Text = thescale.ToString();
            foreach (APlanet aplanet in planets)
            {
              planetcomponent pc= new planetcomponent(aplanet.mass, aplanet.xlocation, aplanet.ylocation, aplanet.xvelocity, aplanet.yvelocity);
                pc.Name = aplanet.Name;
                pc.labelname = pc.Name;
                pc.Location = new Point(Convert.ToInt32(aplanet.xlocation / thescale) + 200, Convert.ToInt32(aplanet.ylocation / thescale) + 200);
                planetlist[planetcount] = pc.Name;
                this.Controls.Add(pc);
                planetcount++;
            }


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
            { 
                timer1.Enabled = true;
           // DrawIt(300, 300, Color.Green);
        }
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
            //System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
           // graphics.FillEllipse(brush1, new System.Drawing.Rectangle(50, 50, 100, 100));
            System.Drawing.SolidBrush brush2 = new System.Drawing.SolidBrush(color);
            //graphics.FillEllipse(brush2, new System.Drawing.Rectangle(x, y,5, 5));
//            graphics.FillEllipse(brush2, new System.Drawing.Rectangle(x, y,25, 25));
            graphics.FillRectangle(brush2, new System.Drawing.Rectangle(0, 0,700, 700));
            //  brush1.Dispose();
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
            pc.Location = new Point(200, 200);
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
                double G = 6.67408E-11;
                if (planetname !=null)
                {
                    planetcomponent planet = this.Controls.Find(planetname, true).FirstOrDefault() as planetcomponent;
                    //planet.Location = new Point(x , y);
                    //x = planet.Location.X * thescale;
                    //y = planet.Location.Y * thescale;

                    mass = planet.mass;
                    double ax=0;
                    double ay=0;
                    x = planet.xlocation;
                    y = planet.ylocation;
                    vx = planet.xvelocity;
                    vy = planet.yvelocity;
                    

                    foreach (string otherplanetname in planetlist)
                    {
                        double ox = 0, oy = 0;
                        double omass;
                        if (otherplanetname != null && !String.Equals(planetname, otherplanetname) )
                            //if (otherplanetname != null && !String.Equals(planetname, otherplanetname))
                            {
                                planetcomponent otherplanet = this.Controls.Find(otherplanetname, true).FirstOrDefault() as planetcomponent;
                            ox = otherplanet.xlocation;
                            oy = otherplanet.ylocation;
                            omass = otherplanet.mass;
                            double r = Math.Sqrt((ox - x) * (ox - x) + (oy - y) * (oy - y));
                            double r3 = Math.Pow(r, 3);
                            ax = -omass * G * (x - ox) / r3+ax;
                            ay = -omass * G * (y - oy) / r3+ay;
 
                        }
                    }
                 
                    planet.xvelocity = vx + ax * theinterval;
                    planet.yvelocity = vy + ay * theinterval;
                    planet.xlocation = x + planet.xvelocity * theinterval;
                    planet.ylocation = y + planet.yvelocity * theinterval;
                    planet.Location = new Point(Convert.ToInt32(planet.xlocation / thescale) + 200, Convert.ToInt32(planet.ylocation / thescale) + 200);
                    //if (Math.Abs(planet.oldx - planet.Location.X) > 5 && Math.Abs(planet.oldy - planet.Location.Y)>5)
                    //{
                    //   DrawIt(planet.oldx, planet.oldy, Color.Green);
                    //   planet.oldx = planet.Location.X;
                    //   planet.oldy = planet.Location.Y;
                    //}
                    planet.apt[planet.pointcount] = planet.Location;
                    planet.pointcount++;
                    Graphics graphics= this.CreateGraphics();
                    Pen myPen = new Pen(Color.Black);
                    Point [] thepoints = new Point[planet.pointcount];
                    Array.Copy(planet.apt, 0, thepoints, 0, planet.pointcount);
                    if (planet.pointcount>2)
                    graphics.DrawCurve(myPen, thepoints);


                }
            }
        }
    }
}
