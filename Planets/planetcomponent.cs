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
        public planetcomponent()
        {
            InitializeComponent();
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

        private void showdialog(object sender, EventArgs e)
        {

        }
    }
}
