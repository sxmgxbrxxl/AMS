using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Hub
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Net;
    using System.Net.Mail;
    using System.Windows.Forms;

    public partial class frmForgot : Form
    {
        public static string to { get; set; }
        private string randomCode;

        DBConnection connect = new DBConnection();

        public frmForgot()
        {
            InitializeComponent();
        }

        private void CreateMail()
        {
            string fromName, fromEmail, pass, messageBody;
            Random rand = new Random();
            randomCode = rand.Next(100000, 999999).ToString(); // Create Random Code
            MailMessage message = new MailMessage();

            fromName = "Academic Mastery";
            fromEmail = "academicmastery00@gmail.com";
            pass = "nbce leas ziut krux";


            string to = txtEmail.Text;

            messageBody = $"Your Reset Code is {randomCode}";
            message.To.Add(to);
            message.From = new MailAddress(fromEmail, fromName);
            message.Body = messageBody;
            message.Subject = "Password Reset Code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromEmail, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void lnkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain form1 = new frmMain();
            form1.Show();
            this.Hide();
        }

        private void lnkSendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                connect.OpenCon();

                string query = "SELECT clm_stdEMAIL FROM db_acadmastery.tbl_stdinfo WHERE clm_stdEMAIL = @clm_stdEMAIL";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@clm_stdEMAIL", txtEmail.Text);

                // Execute the query and retrieve the result
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show($"This email ({txtEmail.Text}) is not linked to any users", "Note!", MessageBoxButtons.OK);
                }
                else
                {
                    CreateMail();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the connection
                connect.CloseCon();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == txtCode.Text) // Comparing
            {
                to = txtEmail.Text; // Send the Email to Form5 to tally in database
                frmReset form5 = new frmReset();
                form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmForgot_Load(object sender, EventArgs e)
        {

        }
    }
}
