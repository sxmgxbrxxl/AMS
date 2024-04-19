using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();

            string constring = "server=localhost;uid=root;password=1234;database=student_hub";
            MySqlConnection conn = new MySqlConnection(constring);

            try
            {
                conn.Open();

                string query = "SELECT stud_fname FROM stdhub_table WHERE student_number = @student_number";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student_number", 2213001);
                object result = cmd.ExecuteScalar();

                if (result != null) // Check if a name was found
                {
                    string studentName = Convert.ToString(result);
                    lblNamePlaceholder.Text = studentName; // Display the name in the label
                }
                else
                {
                    lblNamePlaceholder.Text = "Student not found!";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
