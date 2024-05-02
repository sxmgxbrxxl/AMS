using MySql.Data.MySqlClient;
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
        formHome home;
        formProfile profile;
        formGrades grades;
        formCalculator calculator;
        formAbout about;
        formRecords records;

        public frmDashboard()
        {
            InitializeComponent();
            ShowHome();
        }
        
        public void ShowHome()
        {
            home = new formHome();
            home.MdiParent = this;
            home.Show();
            btnHome.Checked = true;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            home = new formHome();
            home.MdiParent = this;
            home.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile = new formProfile();
            profile.MdiParent = this;
            profile.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            grades = new formGrades();
            grades.MdiParent = this;
            grades.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            records = new formRecords();
            records.MdiParent = this;
            records.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about = new formAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmMain form1 = new frmMain();
            form1.Show();
            this.Close();
        }

        bool menuExpand = false;
        private void studentTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flwStudent.Height += 10;
                if (flwStudent.Height >= 190)
                {
                    studentTransition.Stop();
                    menuExpand = true;
                    btnStudent.Checked = true;
                }
            }
            else
            {
                flwStudent.Height -= 10;
                if (flwStudent.Height <= 70)
                {
                    studentTransition.Stop();
                    menuExpand = false;
                    btnStudent.Checked = false;
                }
            }
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            studentTransition.Start();
            btnHome.Checked = false;
            btnRecords.Checked = false;
            btnAbout.Checked = false;
            btnLogOut.Checked = false;
            btnProfile.Checked = false;
            btnGrades.Checked = false;
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}