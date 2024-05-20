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
    public partial class UCRecords : UserControl
    {
        DBConnection connect = new DBConnection();

        public static int stdID { get; set; }

        public UCRecords()
        {
            InitializeComponent();
            Category();
        }

        private void Category()
        {
            string[] year = { "1st", "2nd", "3rd", "4th" };
            string[] sem = { "1st Semester", "2nd Semester" };
            string[] term = { "Prelim", "Midterm", "Finals" };

            cboYear.Items.AddRange(year);
            cboSemester.Items.AddRange(sem);
            cboTerm.Items.AddRange(term);

            MessageBox.Show("Please fill the required fields before viewing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnView_Click(object sender, EventArgs e)
        { 
            try
            {
                connect.OpenCon();

                string query = "SELECT clm_courseName, clm_Year, clm_semester, clm_Term, clm_courseGrade FROM tbl_stdcourses WHERE clm_stdId = @stdID AND clm_Year = @Year AND clm_semester = @Sem AND clm_Term = @Term";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@stdID", stdID);
                cmd.Parameters.AddWithValue("@Year", cboYear.Text);
                cmd.Parameters.AddWithValue("@Sem", cboSemester.Text);
                cmd.Parameters.AddWithValue("@Term", cboTerm.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // Pass MySqlCommand to MySqlDataAdapter
                da.Fill(dt);
                dgvRecords.DataSource = dt.DefaultView;

                // Customize font and font size of DataGridView
                dgvRecords.DefaultCellStyle.Font = new Font("Century Gothic", 12); // Change "Arial" to your desired font family
                dgvRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold); // Change "Arial" to your desired font family
                dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                connect.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
