using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private MySqlConnection conn;

        public frmSignUp()
        {
            InitializeComponent();
            string constring = "server=localhost;uid=root;password=1234567890;database=student_hub";
            conn = new MySqlConnection(constring);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO student_hub.stdhub_table (clm_stdNumber, clm_stdFname, clm_stdLname, clm_stdAge, clm_stdEmail, clm_stdPass) " +
                               "VALUES ('" + txtStudentNumber.Text + "', '" + txtFirstName.Text + "','" + txtLastName.Text + "', '" + txtAge.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("clm_stdNumber", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("clm_stdFname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("clm_stdLname", txtLastName.Text);
                cmd.Parameters.AddWithValue("clm_stdAge", txtAge.Text);
                cmd.Parameters.AddWithValue("clm_stdEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("clm_stdPass", txtPassword.Text);
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
                if (conn.State == ConnectionState.Open)
                    conn.Close();
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
    }
}
