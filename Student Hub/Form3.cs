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
    public partial class frmDashboard : Form
    {
        formDashboard dashboard;
        formProfile profile;
        formGrades grades;
        formCalculator calculator;
        formAbout about;
        
        public frmDashboard()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        private void studentTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flwStudent.Height += 10;
                if (flwStudent.Height >= 200)
                {
                    studentTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flwStudent.Height -= 10;
                if (flwStudent.Height <= 80)
                {
                    studentTransition.Stop();
                    menuExpand = false;

                }
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            studentTransition.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmMain form1 = new frmMain();
            form1.Show();
            this.Close();
        }

        private void picLogo_Click_1(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                profile = new formProfile();
                profile.MdiParent = this;
                profile.Show();
            }
            else
            {
                profile.Activate();
            }
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            if (grades == null)
            {
                grades = new formGrades();
                grades.MdiParent = this;
                grades.Show();
            }
            else
            {
                grades.Activate();
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (calculator == null)
            {
                calculator = new formCalculator();
                calculator.MdiParent = this;
                calculator.Show();
            }
            else
            {
                calculator.Activate();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new formAbout();
                about.MdiParent = this;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
    }
}
