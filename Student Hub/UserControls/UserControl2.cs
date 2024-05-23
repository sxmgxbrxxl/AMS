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
    public partial class UCProfile : UserControl
    {
        public static string Program { get; set; }

        DBConnection connect = new DBConnection();

        string[] program = {"BSCS-DS"};

        public UCProfile()
        {
            InitializeComponent();
            LoadComboBox();
            LoadDetails();
            DisableAdded();
        }

        private void LoadComboBox()
        {
            Array.Sort(program);
            cboProgram.Items.Clear();
            cboProgram.Items.AddRange(program);
        }

        private void LoadDetails()
        {
            try
            {
                connect.OpenCon();
                string query = "SELECT clm_stdNumber, clm_stdFName, clm_stdLName, clm_stdAGE, clm_stdEMAIL, clm_stdProgram , clm_stdGender FROM tbl_stdinfo WHERE clm_stdNumber = @clm_stdNumber";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                if (!string.IsNullOrEmpty(frmMain.StudentNumber))
                {
                    cmd.Parameters.AddWithValue("@clm_stdNumber", frmMain.StudentNumber);
                }
                else if (!string.IsNullOrEmpty(frmSignUp.StudentNumber))
                {
                    cmd.Parameters.AddWithValue("@clm_stdNumber", frmSignUp.StudentNumber);
                }
                else
                {
                    // Handle the case where neither StudentNumber is provided
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if a record was found
                {
                    string studentFName = reader["clm_stdFName"].ToString();
                    string studentLName = reader["clm_stdLName"].ToString();
                    string studentNumber = reader["clm_stdNumber"].ToString();
                    string studentAge = reader["clm_stdAGE"].ToString();
                    string studentEmail = reader["clm_stdEMAIL"].ToString();
                    string studentProgram = reader["clm_stdProgram"].ToString();
                    string studentGender = reader["clm_stdGender"].ToString();

                    lblFullNamePlaceholder.Text = studentFName + " " + studentLName; // Display the name in the label
                    lblCoursePlaceholder.Text = studentProgram;
                    txtFName.Text = studentFName;
                    txtLName.Text = studentLName;
                    txtAge.Text = studentAge;
                    txtGender.Text = studentGender;
                    txtStudentNumber.Text = studentNumber;
                    txtEmail.Text = studentEmail;
                    cboProgram.Text = studentProgram;

                    Program = cboProgram.Text;
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
                connect.CloseCon();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cboProgram.Text == "")
            {
                cboProgram.BorderColor = Color.Red;
            }
            else
            {
                DialogResult result = MessageBox.Show("You can't modify this once it is saved, Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lblCoursePlaceholder.Text = cboProgram.Text;
                    DisableTextBox();

                    try
                    {
                        connect.OpenCon();
                        string query = "UPDATE db_acad.tbl_stdinfo " +
                                       "SET clm_stdProgram = '" + cboProgram.Text + "'" +
                                       "WHERE clm_stdNumber = @clm_stdNumber";
                        MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                        cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentNumber.Text);
                        cmd.Parameters.AddWithValue("clm_stdProgram", cboProgram.Text);
                        cmd.ExecuteNonQuery();
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
                else
                {
                    //Cancelled
                }
            }
        }

        private void DisableAdded()
        {
            if (!string.IsNullOrEmpty(cboProgram.Text))
            {
                cboProgram.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void DisableTextBox()
        {
            cboProgram.Enabled = false;
            btnSave.Enabled = false;
        }

        private void cboProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCProfile_Load(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }   
        
}
