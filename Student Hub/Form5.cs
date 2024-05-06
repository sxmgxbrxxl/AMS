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
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string email = frmForgot.to;

            string constring = "server=localhost;uid=root;password=1234;database=student_hub";
            MySqlConnection conn = new MySqlConnection(constring);

            try
            {
                conn.Open();
                string query = "UPDATE student_hub.stdhub_table SET clm_stdPass = @newpassword WHERE clm_stdEmail = @email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@newpassword", txtNewPassword.Text);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully");

                frmMain form1 = new frmMain();
                form1.Show();
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

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
                txtVerifyPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
                txtVerifyPassword.PasswordChar = '*';
            }
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
