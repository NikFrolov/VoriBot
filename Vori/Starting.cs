using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vori
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();

            StartingScreenTimer.Start();
        }

        private void StartingScreenTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += .03;
            if (this.Opacity == 1)
            {
                StartingScreenTimer.Stop();
            }
        }
    }
}
