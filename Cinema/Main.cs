using Cinema.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MaximizeBox = false;


            dashboard1.Visible = true;
        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
        }

    }
}
