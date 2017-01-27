using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planets
{
    public partial class planetcomponent : UserControl
    {
        private Point MouseDownLocation;
        //private bool NameDisabled = false;
        public double mass=1;
        public double xvelocity = 0;
        public double yvelocity = 0;
        public double xlocation = 0;
        public double ylocation = 0;
        public Int32 oldx, oldy;

        public string Labelname;
        public planetcomponent()
        {
            InitializeComponent();
        }
        public planetcomponent(double themass, double x, double y, double xvel, double yvel)
        {
            InitializeComponent();
            mass = themass;
            xlocation = x;
            ylocation = y;
            xvelocity = xvel;
            yvelocity = yvel;
        }

        public bool NameDisabled
        {
            get;set;
        }

        public string labelname
        {
            get { return Labelname; }
            set {
                Labelname = value;               
                thelabel.Text = Labelname;
                }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            int x = 0,y = 0;
            Graphics graphics = e.Graphics;
            //Pen myPen = new Pen(Color.Black);
            //// Draw the button in the form of a circle
            //graphics.DrawEllipse(myPen, 0, 0, 100, 100);
            //myPen.Dispose();
            System.Drawing.SolidBrush brush2 = new System.Drawing.SolidBrush(Color.Red);
            graphics.FillEllipse(brush2, new System.Drawing.Rectangle(x, y, 20, 20));
            brush2.Dispose();

        }
        private void planet_MyMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void planet_MyMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        public void showmydialog(object sender, EventArgs e)
        {
            // MessageBox.Show("MineMineMine", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            planetcomponent theguy = (planetcomponent)sender;
            
            Form2 mydialog = new Planets.Form2(theguy.Name, theguy.xlocation,theguy.ylocation,theguy.xvelocity,theguy.yvelocity,theguy.mass);
            TextBox namebox = mydialog.Controls.Find("thename", true).FirstOrDefault() as TextBox;
            TextBox scalebox = this.Parent.Controls.Find("scale", true).FirstOrDefault() as TextBox;

            double thescale = Convert.ToDouble(scalebox.Text);
            if (NameDisabled)  namebox.Enabled = false;
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                //set values              
                theguy.Name = mydialog.pcname;
                theguy.mass = mydialog.pcmass;
                theguy.xvelocity = mydialog.pcxvel;
                theguy.yvelocity = mydialog.pcyvel;
                //                theguy.Location = new Point(Convert.ToInt32(mydialog.pcxloc), Convert.ToInt32(mydialog.pcyloc));
                theguy.Location=new Point(Convert.ToInt32(mydialog.pcxloc/thescale)+200, Convert.ToInt32(mydialog.pcyloc/thescale)+200);
                theguy.xlocation = mydialog.pcxloc;
                theguy.ylocation = mydialog.pcyloc;
                theguy.thelabel.Text = mydialog.pcname;
                theguy.thelabel.BackColor = Color.Transparent;

            }
            NameDisabled = true;  
        }
    }
}
