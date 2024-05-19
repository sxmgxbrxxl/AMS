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
        string[] year = { "1st", "2nd", "3rd", "4th" };
        string[] sem = { "1st Semester", "2nd Semester" };
        string[] term = { "Prelim", "Midterm", "Finals" };
        string[] CSCourse1F = { "CC 1100 Introduction to Computing", "CC 1101 Computer Programming 1 (Fundamentals of Programming)", "GE 1 Understanding the Self",
                         "GE 2 Readings in Philippine History", "GE 3 Mathematics in the Modern World", "GE 4 Purposive Communication", "MST 01 Environmental Science",
                         "NSTP 1 Civic Welfare Training Service 1", "NSTP 1 Reserve Officers Training Corps 1", "PE 1 Self-Testing Activities" };
        string[] CSCourse1S = { "CC 1202 Computer Programming 2 (Intermediate Programming)", "GE 5 The Contemporary World", "GE 6 Art Appreciation",
                         "GE 7 Science, Technology and Society", "GE 8 Ethics", "MST 02 Living in the IT Era", "NSTP 2 Civic Welfare Training Service 2",
                         "NSTP 2 Reserve Officers Training Corps 2", "PC 1201 Discrete Structures", "PE 2 Rhythmic Activities" };
        string[] CSCourse2F = { "CC 2103 Data Structures and Algorithms", "CC 2104 Information Management", "PC 2102 Discrete Structures 2", "PC 2103 Object-oriented Programming 1 (Python)",
                                "PC 2104 Networks and Communication", "PC 2105 Introduction to Data Science", "PE 3 Individual & Dual Sports", "SSP 04 The Entrepreneurial Mind" };
        string[] CSCourse2S = { "GEM Life and Works of Rizal", "PC 2206 Mathematics for Data Science", "PC 2207 Algorithms and Complexity", "PC 2208 Object-oriented Programming 2 (Java)",
                                "PC 2209 Programming 3 (C#)", "PC 2210 Database Management System", "PC 2211 Data Science in Practice", "PE 4 Team Sports" };
        string[] CSCourse3F = { "CC 3105 Applications Development and Emerging Technologies", "PC 3112 Automata Theory and Formal Languages", "PC 3113 Architecture and Organization",
                                "PC 3114 Software Engineering 1", "PC 3115 Information Assurance and Security", "TC 3101 Data Mining and Data Warehousing" };
        string[] CSCourse3S = { "PC 3216 Programming Languages", "PC 3217 Software Engineering 2", "PC 3218 Social Issues and Professional Practice", "PC 3219 Introduction to Artificial Intelligence",
                                "PC 3220 Operating Systems", "TC 3202 Machine Learning" };
        string[] CSCourse4F = { "PC 4121 Human Computer Interaction", "PC 4122 CS Thesis 1", "TC 4103 Natural Language Processing" };
        string[] CSCourse4S = { "CS 4223 CS Thesis 2", "CS 4224 Practicum (300 hours)" };
        
        DBConnection conn = new DBConnection();

        public void SetGrade(string grade)
        {
            txtGrade.Text = grade;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            formPrelimCalculator pcalcu = new formPrelimCalculator();
            formMidtermCalculator mcalcu = new formMidtermCalculator();
            formFinalsCalculator fcalcu = new formFinalsCalculator();

            if (pcalcu.ShowDialog() == DialogResult.OK)
            {
                SetGrade(pcalcu.Grade);
            } else if (mcalcu.ShowDialog() == DialogResult.OK)
            {
                SetGrade(mcalcu.Grade);
            } else if (fcalcu.ShowDialog() == DialogResult.OK)
            {
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
            cboYear.Items.AddRange(year);
            cboSem.Items.AddRange(sem);
            cboTerm.Items.AddRange(term);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCourse();
        }

        private void cboSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCourse();
        }

        private void AddCourse()
        {
            cboCourse.Items.Clear();
            if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "1st" && cboSem.Text == "1st Semester")
            {
                System.Array.Sort(CSCourse1F);
                cboCourse.Items.AddRange(CSCourse1F);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "1st" && cboSem.Text == "2nd Semester")
            {
                System.Array.Sort(CSCourse1S);
                cboCourse.Items.AddRange(CSCourse1S);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "2nd" && cboSem.Text == "1st Semester")
            {
                System.Array.Sort(CSCourse2F);
                cboCourse.Items.AddRange(CSCourse2F);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "2nd" && cboSem.Text == "2nd Semester")
            {
                System.Array.Sort(CSCourse2S);
                cboCourse.Items.AddRange(CSCourse2S);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "3rd" && cboSem.Text == "1st Semester")
            {
                System.Array.Sort(CSCourse3F);
                cboCourse.Items.AddRange(CSCourse3F);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "3rd" && cboSem.Text == "2nd Semester")
            {
                System.Array.Sort(CSCourse3S);
                cboCourse.Items.AddRange(CSCourse3S);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "4th" && cboSem.Text == "1st Semester")
            {
                System.Array.Sort(CSCourse4F);
                cboCourse.Items.AddRange(CSCourse4F);
            }
            else if (UCProfile.Program == "BSCS-DS" && cboYear.Text == "4th" && cboSem.Text == "2nd Semester")
            {
                System.Array.Sort(CSCourse4S);
                cboCourse.Items.AddRange(CSCourse4S);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

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
            try
            {
                conn.OpenCon();
                string query = "INSERT INTO `tbl_stdcourses`(`clm_stdID`, `clm_Year`, `clm_Term`, `clm_semester`, `clm_courseName`, `clm_courseGrade`) " +
                    "VALUES (@clm_stdID,@clm_Year,@clm_Term,@clm_semester,@clm_courseName,@clm_courseGrade)";
                MySqlCommand cmd = new MySqlCommand(query, conn.GetConnection());

                cmd.Parameters.AddWithValue("@clm_stdID", stdID);
                cmd.Parameters.AddWithValue("@clm_Year", cboYear.Text);
                cmd.Parameters.AddWithValue("@clm_Term", cboTerm.Text);
                cmd.Parameters.AddWithValue("@clm_semester", cboSem.Text);
                cmd.Parameters.AddWithValue("@clm_courseName", cboCourse.Text);
                cmd.Parameters.AddWithValue("@clm_courseGrade", txtGrade.Text);
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvGrades.Rows.Add(stdID.ToString(), cboTerm.Text, cboCourse.Text, txtGrade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                MessageBox.Show(stdID.ToString());
                conn.CloseCon();
            }
        }

    }
}


