using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planets
{
    public partial class Form2 : Form
    {
        public string pcname;
        public double pcxloc;
        public double pcyloc;
        public double pcxvel;
        public double pcyvel;
        public double pcmass;

        public Form2(string name, double thelocx, double thelocy, double thevelx, double thevely, double themass)
        {
            InitializeComponent();
            thename.Text = name;
            xloc.Text = thelocx.ToString();
            yloc.Text = thelocy.ToString();
            xvel.Text = thevelx.ToString();
            yvel.Text = thevely.ToString();
            mass.Text = themass.ToString();
        }

        private void okbutt_Click(object sender, EventArgs e)
        {
            pcmass = Convert.ToDouble(mass.Text);
            pcyvel = Convert.ToDouble(yvel.Text);
            pcxvel = Convert.ToDouble(xvel.Text);
            pcyloc = Convert.ToDouble(yloc.Text);
            pcxloc = Convert.ToDouble(xloc.Text);
            pcname = thename.Text;
        }
    }
}
