using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Hub
{
    public partial class frmSignUp : Form
    {
        public static string StudentNumber { get; set; }
        DBConnection connect = new DBConnection();
        string[] gender = { "Male", "Female" };

        public frmSignUp()
        {
            InitializeComponent();
            cboGender.Items.AddRange(gender);
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

                
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtStudentNumber.Text) || string.IsNullOrWhiteSpace(cboGender.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO tbl_stdinfo(clm_stdNumber, clm_stdFName, clm_stdLName, clm_stdGender, clm_stdEMAIL, clm_stdPASS) " +
                                "VALUES (@clm_stdNumber, @clm_stdFName, @clm_stdLName, @clm_stdGender, @clm_stdEMAIL, @clm_stdPASS)";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("@clm_stdFName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@clm_stdLName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@clm_stdGender", cboGender.Text);
                cmd.Parameters.AddWithValue("@clm_stdEMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("@clm_stdPASS", txtPassword.Text);

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StudentNumber = txtStudentNumber.Text;
                SplashScreen SS = new SplashScreen();
                SS.Show();
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.TextLength <= 2)
            {
                MessageBox.Show("Please enter a proper First Name with at least 3 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.BorderColor = Color.Red;
                lblFNAsterisk.Text = "*";
                lblFNAsterisk.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.TextLength <= 1)
            {
                MessageBox.Show("Please enter a proper Last Name with at least 2 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.BorderColor = Color.Red;
                lblLNAsterisk.Text = "*";
                lblLNAsterisk.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) || txtStudentNumber.TextLength <= 6 || HasAllSameCharacters(txtStudentNumber.Text))
            {
                MessageBox.Show("Please enter a student number with at least 7 digits and ensure it does not contain the same digit repeated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentNumber.BorderColor = Color.Red;
                lblSNAsterisk.Text = "*";
                lblSNAsterisk.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Please choose your Gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGender.BorderColor = Color.Red;
                lblAsteriskGender.Text = "*";
                lblAsteriskGender.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text) || IsInvalidGmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email and ensure Gmail addresses have more than one character before the '@' symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.BorderColor = Color.Red;
                lblEAsterisk.Text = "*";
                lblEAsterisk.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.TextLength < 8 || !ContainsLettersCharactersNumbers(txtPassword.Text) || txtPassword.Text.Contains(' '))
            {
                MessageBox.Show("Please enter a password with at least 8 characters, including letters, characters, and numbers, and no spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.BorderColor = Color.Red;
                lblPAsterisk.Text = "*";
                lblPAsterisk.ForeColor = Color.Red;
                return;
            }
            else if (txtConfirmPASSWORD.Text != txtPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPASSWORD.BorderColor = Color.Red;
                lblCPAsterisk.Text = "*";
                lblCPAsterisk.ForeColor = Color.Red;
                return;
            }
            else
            {
                addDetails();
            }

        }
        bool HasAllSameCharacters(string input)
        {
            return input.Distinct().Count() == 1;
        }

        bool IsInvalidGmail(string email)
        {
            var match = Regex.Match(email, @"^([a-zA-Z0-9._-]{8,})@gmail\.com$");
            if (!match.Success)
                return true;

            string localPart = match.Groups[1].Value;
            bool hasCapital = localPart.Any(char.IsUpper);
            bool hasSymbol = localPart.Any(ch => ch == '_' || ch == '.' || ch == '-');
            bool hasNumber = localPart.Any(char.IsDigit);

            return !(hasCapital && hasSymbol && hasNumber);
        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        bool ContainsLettersCharactersNumbers(string input)
        {
            bool hasLetter = input.Any(char.IsLetter);
            bool hasDigit = input.Any(char.IsDigit);
            bool hasSpecial = input.Any(ch => !char.IsLetterOrDigit(ch));
            return hasLetter && hasDigit && hasSpecial;
        }

        // Method to check if the password contains a combination of letters, characters, and numbers
        /**private bool ContainsLettersCharactersNumbers(string password)
        {
            // Regular expression to match at least one letter, one character, and one number
            string pattern = @"^(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }**/

        private void chkShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass2.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPASSWORD.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPASSWORD.PasswordChar = '*';
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            txtStudentNumber.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtConfirmPASSWORD_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPASSWORD.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
