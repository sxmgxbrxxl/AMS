using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Student_Hub
{
    public partial class UCGrades : UserControl
    {
        public static int stdID { get; set; }

        string[] term = { "Prelim", "Midterm", "Finals" };
        
        DBConnection connect = new DBConnection();
        public void SetGrade(string grade)
        {
            txtGrade.Text = grade;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (cboTerm.Text == "Prelim")
            {
                formPrelimCalculator pcalcu = new formPrelimCalculator();
                pcalcu.ShowDialog(); // ShowDialog() waits for the form to close before proceeding
                SetGrade(pcalcu.Grade);
            }
            else if (cboTerm.Text == "Midterm")
            {
                formMidtermCalculator mcalcu = new formMidtermCalculator();
                mcalcu.ShowDialog(); // ShowDialog() waits for the form to close before proceeding
                SetGrade(mcalcu.Grade);
            }
            else if (cboTerm.Text == "Finals")
            {
                formFinalsCalculator fcalcu = new formFinalsCalculator();
                fcalcu.ShowDialog(); // ShowDialog() waits for the form to close before proceeding
                SetGrade(fcalcu.Grade);
            }
        }

        // string gradeview;
        public UCGrades()
        {
            InitializeComponent();
            CustomizedgvGrades();
            AddingChoices();
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            cboSem.SelectedIndexChanged += cboSem_SelectedIndexChanged;
        }

        private void AddingChoices()
        {
            try
            {
                // Open the connection 
                connect.OpenCon();

                // Add Year
                string yearQuery = "SELECT DISTINCT clm_courseYear FROM tbl_courses";
                MySqlCommand yearCmd = new MySqlCommand(yearQuery, connect.GetConnection());
                using (MySqlDataReader yearReader = yearCmd.ExecuteReader())
                {
                    while (yearReader.Read())
                    {
                        cboYear.Items.Add(yearReader["clm_courseYear"].ToString());
                    }
                }

                // Add Sem
                string semQuery = "SELECT DISTINCT clm_courseSem FROM tbl_courses";
                MySqlCommand semCmd = new MySqlCommand(semQuery, connect.GetConnection());
                using (MySqlDataReader semReader = semCmd.ExecuteReader())
                {
                    while (semReader.Read())
                    {
                        cboSem.Items.Add(semReader["clm_courseSem"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }

            // Add Term
            cboTerm.Items.AddRange(term);
        }


        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDB();
        }

        private void cboSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDB();
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMidtermCalculator.courseName = cboCourse.Text;
            formFinalsCalculator.courseName = cboCourse.Text;
        }

        private void CourseDB()
        {
            cboCourse.Items.Clear();

            connect.OpenCon();

            if (cboYear.Text == "1st" && cboSem.Text == "1st Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '1st' AND clm_courseSem = '1st Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "1st" && cboSem.Text == "2nd Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '1st' AND clm_courseSem = '2nd Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "2nd" && cboSem.Text == "1st Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '2nd' AND clm_courseSem = '1st Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "2nd" && cboSem.Text == "2nd Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '2nd' AND clm_courseSem = '2nd Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "3rd" && cboSem.Text == "1st Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '3rd' AND clm_courseSem = '1st Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "3rd" && cboSem.Text == "2nd Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '3rd' AND clm_courseSem = '2nd Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "4th" && cboSem.Text == "1st Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '4th' AND clm_courseSem = '1st Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (cboYear.Text == "4th" && cboSem.Text == "2nd Semester")
            {
                try
                {
                    string query = "SELECT clm_courseName FROM tbl_courses WHERE clm_courseYear = '4th' AND clm_courseSem = '2nd Semester'";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                    MySqlDataReader drd = cmd.ExecuteReader();
                    while (drd.Read())
                    {
                        cboCourse.Items.Add(drd["clm_courseName"].ToString());
                    }

                    // Close the data reader
                    drd.Close();

                    // Close the connection
                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CustomizedgvGrades()
        {
            dgvGrades.DefaultCellStyle.Font = new Font("Century Gothic", 12); // Font for rows
            dgvGrades.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold); // Font for headers
        }

        private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomizedgvGrades();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboCourse.Text))
            {
                MessageBox.Show("Invalid Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Invalid Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.OpenCon();
                    string query = "INSERT INTO `tbl_stdcourses`(`clm_stdID`, `clm_Year`, `clm_Term`, `clm_semester`, `clm_courseName`, `clm_courseGrade`) " +
                                    "VALUES (@clm_stdID,@clm_Year,@clm_Term,@clm_semester,@clm_courseName,@clm_courseGrade)";
                    MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                    cmd.Parameters.AddWithValue("@clm_stdID", stdID);
                    cmd.Parameters.AddWithValue("@clm_Year", cboYear.Text);
                    cmd.Parameters.AddWithValue("@clm_Term", cboTerm.Text);
                    cmd.Parameters.AddWithValue("@clm_semester", cboSem.Text);
                    cmd.Parameters.AddWithValue("@clm_courseName", cboCourse.Text);
                    cmd.Parameters.AddWithValue("@clm_courseGrade", txtGrade.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGrades.Rows.Add(stdID.ToString(), cboTerm.Text, cboCourse.Text, txtGrade.Text);
                    cboCourse.SelectedIndex = -1;
                    txtGrade.Clear();
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
        }
    }
}


