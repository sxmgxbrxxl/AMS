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
            string constring = "server=localhost;uid=root;password=1234;database=student_hub";
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
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO student_hub.stdhub_table (student_number, stud_fname, stud_lname, stud_age, stud_email, stud_pass) " +
                               "VALUES ('" + txtStudentNumber.Text + "', '" + txtFirstName.Text + "','" + txtLastName.Text + "', '" + txtAge.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("student_number", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("stud_fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("stud_lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("stud_age", txtAge.Text);
                cmd.Parameters.AddWithValue("stud_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("stud_pass", txtPassword.Text);
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
    }
}
