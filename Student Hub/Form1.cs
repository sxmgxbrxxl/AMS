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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp form2 = new frmSignUp();
            form2.Show();
            this.Hide();
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;uid=root;password=1234;database=student_hub";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM student_hub.stdhub_table WHERE student_number = @student_number AND stud_pass = @stud_pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_number", txtStudentNumber.Text);
                    cmd.Parameters.AddWithValue("@stud_pass", txtPassword.Text); // Assuming password is stored in txtPassword TextBox

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Optionally, navigate to another form after successful login//
                        frmDashboard form3 = new frmDashboard();
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid student number or password. " +
                                        "Please check your credentials.", "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
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
