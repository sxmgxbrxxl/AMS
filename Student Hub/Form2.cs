using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Hub
{
    public partial class frmSignUp : Form
    {
        public static string StudentNumber { get; set; }
        DBConnection connect = new DBConnection();

        public frmSignUp()
        {
            InitializeComponent();
           
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain form1 = new frmMain();
            form1.Show();
            this.Hide();
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void addDetails()
        {
            try
            {
                connect.OpenCon();

                
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAge.Text == "" || txtStudentNumber.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO db_acadmastery.tbl_stdinfo(clm_stdNumber, clm_stdFName, clm_LName, clm_stdAGE, clm_stdEMAIL, clm_stdPASS) " +
                                "VALUES (@clm_stdNumber, @clm_stdFName, @clm_LName, @clm_stdAGE, @clm_stdEMAIL, @clm_stdPASS)";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("@clm_stdFName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@clm_LName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@clm_stdAGE", txtAge.Text);
                cmd.Parameters.AddWithValue("@clm_stdEMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@clm_stdPASS", txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User created successfully!", "Success");

                StudentNumber = txtStudentNumber.Text;
                frmDashboard form3 = new frmDashboard();
                form3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text == "")
            {
                txtFirstName.BorderColor = Color.Red;
            }
            if (txtLastName.Text == "")
            {
                txtLastName.BorderColor = Color.Red;
            }
            if (txtAge.Text == "")
            {
                txtAge.BorderColor = Color.Red;
            }
            if (txtStudentNumber.Text == "")
            {
                txtStudentNumber.BorderColor = Color.Red;
            }
            if (txtEmail.Text == "")
            {
                txtEmail.BorderColor = Color.Red;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.BorderColor = Color.Red;
            }
            else
            {
                addDetails(); 
            }
        }


        private void chkShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass2.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
