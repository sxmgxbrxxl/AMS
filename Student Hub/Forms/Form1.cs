using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        public static string StudentNumber { get; set; }

        DBConnection connect  = new DBConnection();

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

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot form4 = new frmForgot();
            form4.Show();
            this.Hide();
        }

        private void ctrClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connect.OpenCon();

                string query = "SELECT COUNT(*) FROM tbl_stdinfo WHERE clm_stdNumber = @clm_stdNumber AND clm_stdPASS = @clm_stdPASS";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("@clm_stdPASS", txtPassword.Text); // Assuming password is stored in txtPassword TextBox

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Optionally, navigate to another form after successful login//
                    SplashScreen SS = new SplashScreen();
                    this.Hide();
                    SS.Show();

                    StudentNumber = txtStudentNumber.Text;
                }
                else
                {
                    MessageBox.Show("Invalid student number or password. " +
                                    "Please check your credentials.", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }

            try
            {
                connect.OpenCon();

                string query = "SELECT clm_stdID FROM tbl_stdinfo WHERE clm_stdNumber = @clm_stdNumber";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCGrades.stdID = Convert.ToInt32(reader["clm_stdID"].ToString());
                    formMidtermCalculator.stdID = Convert.ToInt32(reader["clm_stdID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }

            /*try
            {
                connect.OpenCon();

                string query = "SELECT clm_stdFName, clm_stdNumber FROM tbl_stdinfo WHERE clm_stdNumber = @clm_stdNumber";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCHome.GlobalNamePlaceholder.Text = reader["clm_stdFName"].ToString();
                    UCHome.GlobalStudNumPlaceholder.Text = reader["clm_stdNumber"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }*/

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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
