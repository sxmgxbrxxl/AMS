using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Hub
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cpbLogo.Increment(1);

            if (cpbLogo.Value == 100) 
            {
                timer1.Enabled = false;

                frmDashboard Dashboard = new frmDashboard();
                Dashboard.Show();
                this.Hide();
            }
        }
    }
}
