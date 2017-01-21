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
        public int pcxloc;
        public int pcyloc;
        public int pcxvel;
        public int pcyvel;
        public int pcmass;

        public Form2(string name, int thelocx, int thelocy, int thevelx, int thevely, int themass)
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
            pcmass = Convert.ToInt32(mass.Text);
            pcyvel = Convert.ToInt32(yvel.Text);
            pcxvel = Convert.ToInt32(xvel.Text);
            pcyloc = Convert.ToInt32(yloc.Text);
            pcxloc = Convert.ToInt32(xloc.Text);
            pcname = thename.Text;
        }
    }
}
