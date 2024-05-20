using Google.Protobuf.WellKnownTypes;
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
    public partial class formMidtermCalculator : Form
    {
        //public static string FGrade {  get; set; }

        // Other code...

        public static int stdID { get; set; }

        public static string courseName { get; set; }

        DBConnection connect = new DBConnection();

        double firstvalue = 0;
        double secondvalue = 0;
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public string Grade
        {
            get { return txtGrade.Text; }
            set { txtGrade.Text = value; }
        }
  
        public formMidtermCalculator()
        {
            InitializeComponent();
        }

        /*private void GetPreviousGrade()
        {
            try
            {
                connect.OpenCon();

                string query = "SELECT clm_courseGrade FROM tbl_stdcourses WHERE clm_Term = 'Prelim' && clm_courseName = @clm_courseName && clm_stdID = @clm_stdID";
                MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
                cmd.Parameters.AddWithValue("@clm_stdID", stdID);
                cmd.Parameters.AddWithValue("@clm_courseName", courseName);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if a record was found
                {
                    string courseGrade = reader["clm_courseGrade"].ToString();
                    txtPreviousGrade.Text = courseGrade;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Error: " + ex.Message); // Display the specific MySQL error message
            }
            finally
            {
                connect.CloseCon();
            }
        }*/

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtPreview.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            txtScore.Text = txtResult.Text;
        }

        private void btnOverScore_Click(object sender, EventArgs e)
        {
            txtOverScore.Text = txtResult.Text;
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            txtPreviousGrade.Text = txtResult.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            firstvalue = double.Parse(txtResult.Text);
            txtPreview.Text = firstvalue + " " + operationPerformed;
            txtResult.Clear();
            isOperationPerformed = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //Recitation
            double percentRecit = 70;
            double pRresult = percentRecit / 100;


            double recit = Convert.ToDouble(txtScore.Text);
            double overrecit = Convert.ToDouble(txtOverScore.Text);

            double recitresult = (recit / overrecit) * 50 + 50;

            double rresult = recitresult * pRresult;

            txtTotalScore.Text = Convert.ToString(rresult);

            //Exam
            double percentExam = 30;
            double pEresult = percentExam / 100;

            double exam = Convert.ToDouble(txtPreviousGrade.Text);
           
            double eresult = exam * pEresult;
            double eresult2 = eresult;
            string finalscore = eresult2.ToString("0.00");

            txtTotalExam.Text = finalscore;

            //Total All
            double totalrecit = Convert.ToDouble(txtTotalScore.Text);
            double totalexam = Convert.ToDouble(txtTotalExam.Text);

            double grade = totalrecit  + totalexam;

            double grade2 = grade;
            double finalresult; //= grade2.ToString("0.00");
            double fractioned = grade2 - Math.Floor(grade2);
            if(fractioned >= 0.5)
            {
                finalresult = Math.Ceiling(grade2);
                txtGrade.Text = Convert.ToString(finalresult);
            } else if(fractioned <= 0.4)
            {
                finalresult = Math.Floor(grade2);
                txtGrade.Text = Convert.ToString(finalresult);
            }

            
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void termsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRELIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrelimCalculator frmcalcu = new formPrelimCalculator();
            this.Hide();
            frmcalcu.Show();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            secondvalue = double.Parse(txtResult.Text);

            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = (firstvalue + secondvalue).ToString();
                    break;
                case "−":
                    txtResult.Text = (firstvalue - secondvalue).ToString();
                    break;
                case "×":
                    txtResult.Text = (firstvalue * secondvalue).ToString();
                    break;
                case "÷":
                    if (secondvalue != 0)
                        txtResult.Text = (firstvalue / secondvalue).ToString();
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    break;
            }
            txtPreview.Text = firstvalue + " " + operationPerformed + " " + secondvalue + " =";
        }

        private void btnSaveMid_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fINALSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFinalsCalculator fcalc = new formFinalsCalculator();
            this.Hide();
            fcalc.Show();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
