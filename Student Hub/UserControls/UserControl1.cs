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
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Hub
{
    public partial class UCHome : UserControl
    {
        DBConnection connect = new DBConnection();
        
        public static int stdID { get; set; }

        public UCHome()
        {
            InitializeComponent();
            FetchStudentName();
            LoadChart1();
            LoadChart2();
            LoadChart3();
            LoadNumberOfUsers();
            lblDate.Text = DateTime.Now.ToString("MMM, yyyy");
        }

        private void FetchStudentName()
        {
            string studentNumber = null;

            // Check if frmMain is instantiated and StudentNumber is not null or empty
            if (frmMain.StudentNumber != null && !string.IsNullOrEmpty(frmMain.StudentNumber))
            {
                studentNumber = frmMain.StudentNumber;
            }
            // If frmMain is not available or StudentNumber is empty, check frmSignUp
            else if (frmSignUp.StudentNumber != null && !string.IsNullOrEmpty(frmSignUp.StudentNumber))
            {
                studentNumber = frmSignUp.StudentNumber;
            }

            lblStudentNumberPlaceholder.Text = studentNumber;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            try
            {
                connect.OpenCon();

                string query = "SELECT clm_stdFName FROM tbl_stdinfo WHERE clm_stdNumber = @clm_stdNumber";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());


                if (studentNumber != null)
                {
                    cmd.Parameters.AddWithValue("@clm_stdNumber", MySqlDbType.VarChar).Value = studentNumber;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Check if a record was found
                    {
                        string studentFName = reader["clm_stdFName"].ToString();
                        lblNamePlaceholder.Text = studentFName; // Display the name in the label
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message); // Display the specific MySQL error message
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void LoadChart1()
        {
            try
            {
                connect.OpenCon();

                // Define the SQL query to retrieve data
                string query = "SELECT clm_stdAGE, COUNT(*) AS Count FROM tbl_stdinfo GROUP BY clm_stdAGE";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Clear existing series in the chart
                chart1.Series.Clear();

                // Add a new series to the chart
                Series series = new Series("Year Count");
                series.ChartType = SeriesChartType.Pie;

                // Bind data to the series
                series.XValueMember = "clm_stdAGE";
                series.YValueMembers = "Count";
                chart1.Series.Add(series);

                // Set chart data source
                chart1.DataSource = dt;

                chart1.Legends[0].Font = new Font("Century Gothic", 10);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void LoadChart2()
        {
            try
            {
                connect.OpenCon();

                // Define the SQL query to retrieve the highest grade for each course
                string query = "SELECT clm_courseName, MAX(clm_courseGrade) AS MaxGrade FROM tbl_stdcourses WHERE clm_stdID = @stdID GROUP BY clm_courseName";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@stdID", stdID);

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Clear existing series in the chart
                chart2.Series.Clear();

                // Add a new series to the chart
                Series series = new Series("Highest Grade");
                series.ChartType = SeriesChartType.Bar;

                // Bind data to the series
                series.XValueMember = "clm_courseName";
                series.YValueMembers = "MaxGrade";
                chart2.Series.Add(series);

                // Set chart data source
                chart2.DataSource = dt;

                // Set the maximum value for the y-axis
                chart2.ChartAreas[0].AxisY.Maximum = 100;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void LoadChart3()
        {
            try
            {
                connect.OpenCon();

                // Define the SQL query to retrieve data
                string query = "SELECT clm_stdProgram, COUNT(*) AS Count FROM tbl_stdinfo GROUP BY clm_stdProgram";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Clear existing series in the chart
                chart3.Series.Clear();

                // Add a new series to the chart
                Series series = new Series("Program Count");
                series.ChartType = SeriesChartType.Pie;

                // Bind data to the series
                series.XValueMember = "clm_stdProgram";
                series.YValueMembers = "Count";
                chart3.Series.Add(series);

                // Set chart data source
                chart3.DataSource = dt;

                // Set legend font
                chart3.Legends[0].Font = new Font("Century Gothic", 10);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void LoadNumberOfUsers()
        {
            try
            {
                connect.OpenCon();

                // Define the SQL query to retrieve data
                string query = "SELECT COUNT(clm_stdID) AS Count FROM tbl_stdinfo"; // Fix the query syntax
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if a record was found
                {
                    string NumberOfUsers = reader["Count"].ToString(); // Access the count directly
                    lblNumber.Text = NumberOfUsers;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}