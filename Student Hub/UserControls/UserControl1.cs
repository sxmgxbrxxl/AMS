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
    public partial class UCHome : UserControl
    {
        DBConnection connect = new DBConnection();

        public UCHome()
        {
            InitializeComponent();
            FetchStudentName();
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
    }
}