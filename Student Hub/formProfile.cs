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
    public partial class formProfile : Form
    {
        public formProfile()
        {
            InitializeComponent();
            LoadDetails();
        }

        private void LoadDetails()
        {
            string constring = "server=localhost;uid=root;password=1234;database=student_hub";
            MySqlConnection conn = new MySqlConnection(constring);

            try
            {
                conn.Open();

                string query = "SELECT stud_fname, stud_lname, stud_age, stud_email, stud_course , stud_gender FROM stdhub_table WHERE student_number = @student_number";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(frmMain.StudentNumber))
                {
                    cmd.Parameters.AddWithValue("@student_number", frmMain.StudentNumber);
                }
                else if (!string.IsNullOrEmpty(frmSignUp.StudentNumber))
                {
                    cmd.Parameters.AddWithValue("@student_number", frmSignUp.StudentNumber);
                }
                else
                {
                    // Handle the case where neither StudentNumber is provided
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if a record was found
                {
                    string studentFName = reader["stud_fname"].ToString();
                    string studentLName = reader["stud_lname"].ToString();
                    string studentAge = reader["stud_age"].ToString();
                    string studentEmail = reader["stud_email"].ToString();
                    string studentCourse = reader["stud_course"].ToString();
                    string studentGender = reader["stud_gender"].ToString();

                    lblNamePlaceholder.Text = studentFName; // Display the name in the label
                    lblCoursePlaceholder.Text = studentCourse;
                    txtFullName.Text = studentFName + " " + studentLName;
                    txtAge.Text = studentAge;
                    txtStudentID.Text = frmMain.StudentNumber;
                    txtEmail.Text = studentEmail;
                    txtCourse.Text = studentCourse;
                    txtGender.Text = studentGender;
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You can't modify this once it is saved, Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lblCoursePlaceholder.Text = txtCourse.Text;
                DisableTextBox();
                
                string StudentNumber = frmMain.StudentNumber;

                string constring = "server=localhost;uid=root;password=1234;database=student_hub";
                MySqlConnection conn = new MySqlConnection(constring);

                try
                {
                    conn.Open();
                    string query = "UPDATE student_hub.stdhub_table " +
                                   "SET stud_course = '" + txtCourse.Text + "', stud_gender = '" + txtGender.Text + "'" +
                                   "WHERE student_number = @student_number";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(frmMain.StudentNumber))
                    {
                        cmd.Parameters.AddWithValue("@student_number", frmMain.StudentNumber);
                    }
                    else if (!string.IsNullOrEmpty(frmSignUp.StudentNumber))
                    {
                        cmd.Parameters.AddWithValue("@student_number", frmSignUp.StudentNumber);
                    }
                    cmd.Parameters.AddWithValue("stud_course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("stud_gender", txtGender.Text);
                    cmd.ExecuteNonQuery();
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
            else
            {
                //Cancelled
            }
        }

        private void DisableTextBox()
        {
            txtGender.Enabled = false;
            txtCourse.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}
