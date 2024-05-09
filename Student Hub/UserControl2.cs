﻿using MySql.Data.MySqlClient;
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
        DBConnection connect = new DBConnection();

        public UCProfile()
        {
            InitializeComponent();
            LoadDetails();
            DisableAdded();
        }

        private void LoadDetails()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

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
                    string studentCourse = reader["clm_stdProgram"].ToString();
                    string studentGender = reader["clm_stdGender"].ToString();

                    lblNamePlaceholder.Text = studentFName; // Display the name in the label
                    lblCoursePlaceholder.Text = studentCourse;
                    txtFullName.Text = studentFName + " " + studentLName;
                    txtAge.Text = studentAge;
                    txtStudentID.Text = studentNumber;
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
                connect.CloseCon();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourse.Text == "")
            {
                txtCourse.BorderColor = Color.Red;
                txtCourse.PlaceholderText = "*";
            }
            else if (txtGender.Text == "")
            {
                txtGender.BorderColor = Color.Red;
                txtGender.PlaceholderText = "*";
            }
            else
            {
                DialogResult result = MessageBox.Show("You can't modify this once it is saved, Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lblCoursePlaceholder.Text = txtCourse.Text;
                    DisableTextBox();

                    try
                    {
                        connect.OpenCon();
                        string query = "UPDATE db_acadmastery.tbl_stdinfo " +
                                       "SET clm_stdProgram = '" + txtCourse.Text + "', clm_stdGender = '" + txtGender.Text + "'" +
                                       "WHERE clm_stdNumber = @clm_stdNumber";
                        MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                        cmd.Parameters.AddWithValue("@clm_stdNumber", txtStudentID.Text);
                        cmd.Parameters.AddWithValue("clm_stdProgram", txtCourse.Text);
                        cmd.Parameters.AddWithValue("clm_stdGender", txtGender.Text);
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
            if (!string.IsNullOrEmpty(txtCourse.Text) && !string.IsNullOrEmpty(txtGender.Text))
            {
                txtCourse.Enabled = false;
                txtGender.Enabled = false;
                btnSave.Enabled = false;
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