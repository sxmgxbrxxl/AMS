using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Hub
{
    public partial class frmReset : Form
    {
        DBConnection connect = new DBConnection();
        public frmReset()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.TextLength < 8 || !ContainsLettersCharactersNumbers(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a password with at least 8 characters, including letters, characters, and numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.BorderColor = Color.Red;
                return;
            }
            if (txtVerifyPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVerifyPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                addDeets();
            }
        }
        private bool ContainsLettersCharactersNumbers(string password)
        {
            // Regular expression to match at least one letter, one character, and one number
            string pattern = @"^(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
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
        private void addDeets()
        {
            string email = frmForgot.to;

            try
            {
                connect.OpenCon();
                string query = "UPDATE db_acad.tbl_stdinfo SET clm_stdPASS = @newpassword WHERE clm_stdEMAIL = @email";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                // Set parameters
                cmd.Parameters.AddWithValue("@newpassword", txtNewPassword.Text);
                cmd.Parameters.AddWithValue("@email", email); // Removed MySqlDbType.VarChar

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
                connect.CloseCon();
            }


        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmReset_Load(object sender, EventArgs e)
        {

        }
    }
}
