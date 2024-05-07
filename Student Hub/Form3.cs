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

        public frmDashboard()
        {
            InitializeComponent();
            ShowHome();
        }

        private void AddUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        public void ShowHome()
        {
            UCHome home = new UCHome();
            AddUserControl(home);
            btnHome.Checked = true;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome home = new UCHome();
            AddUserControl(home);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UCProfile profile = new UCProfile();
            AddUserControl(profile);
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            UCGrades grades = new UCGrades();
            AddUserControl(grades);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            UCRecords records = new UCRecords();
            AddUserControl(records);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UCAbout about = new UCAbout();
            AddUserControl(about);
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}