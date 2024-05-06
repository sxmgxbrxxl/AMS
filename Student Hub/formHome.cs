using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Hub
{
    public partial class formHome : Form
    { 

        public formHome()
        {
            InitializeComponent();
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

            string constring = "server=localhost;uid=root;password=1234;database=student_hub";
            MySqlConnection conn = new MySqlConnection(constring);

            try
            {
                conn.Open();

                string query = "SELECT clm_stdFname FROM stdhub_table WHERE clm_stdNumber = @clm_stdNumber";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                if (studentNumber != null)
                {
                    cmd.Parameters.AddWithValue("@clm_stdNumber", studentNumber);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Check if a record was found
                    {
                        string studentFName = reader["clm_stdFname"].ToString();
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            FetchStudentName();
            lblDate.Text = DateTime.Now.ToString("MMMM d, yyyy");
            lblTime.Text = DateTime.Now.ToString("h:m tt");
        }
    }
}
