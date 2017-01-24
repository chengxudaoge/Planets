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
        private bool DisableName = false;
        public double mass=1;
        public double xvelocity = 0;
        public double yvelocity = 0;
        public planetcomponent()
        {
            InitializeComponent();
        }

       public bool NameDisabled
        {
            get { return DisableName; }
            set { DisableName = value; }
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
            
            Form2 mydialog = new Planets.Form2(theguy.Name, theguy.Location.X,theguy.Location.Y,theguy.xvelocity,theguy.yvelocity,theguy.mass);
            TextBox namebox= mydialog.Controls.Find("thename", true).FirstOrDefault() as TextBox;
            if (NameDisabled) namebox.Enabled = false;
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                //set values              
                theguy.Name = mydialog.pcname;
                theguy.mass = mydialog.pcmass;
                theguy.xvelocity = mydialog.pcxvel;
                theguy.yvelocity = mydialog.pcyvel;
                theguy.Location = new Point(Convert.ToInt32(mydialog.pcxloc), Convert.ToInt32(mydialog.pcyloc));
                theguy.thelabel.Text = mydialog.pcname;
                theguy.thelabel.BackColor = Color.Transparent;

            }
            NameDisabled = true;  
        }
    }
}
