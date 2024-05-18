using Google.Protobuf.WellKnownTypes;
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
    public partial class formCalculator : Form
    {
        //public static string FGrade {  get; set; }

        // Other code...

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
  
        public formCalculator()
        {
            InitializeComponent();
        }

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

        private void btnSaveRecit_Click(object sender, EventArgs e)
        {
            txtRecitation.Text = txtResult.Text;
        }

        private void btnOverRecit_Click(object sender, EventArgs e)
        {
            txtOverRecit.Text = txtResult.Text;
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            txtExam.Text = txtResult.Text;
        }

        private void btnOverExam_Click(object sender, EventArgs e)
        {
            txtOverExam.Text = txtResult.Text;
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
            double percentRecit = 20;
            double pRresult = percentRecit / 100;


            double recit = Convert.ToDouble(txtRecitation.Text);
            double overrecit = Convert.ToDouble(txtOverRecit.Text);

            double recitresult = (recit / overrecit) * 50 + 50;

            double rresult = recitresult * pRresult;

            txtTotalRecit.Text = Convert.ToString(rresult);

            //Exam
            double percentExam = Convert.ToDouble(txtPercentExam.Text);
            double pEresult = percentExam / 100;

            double exam = Convert.ToDouble(txtExam.Text);
            double overExam = Convert.ToDouble(txtOverExam.Text);

            double examresult = (exam / overExam) * 50 + 50;

            double eresult = examresult * pEresult;
            double eresult2 = eresult;
            string finalscore = eresult2.ToString("0.00");

            txtTotalExam.Text = finalscore;

            //Total All
            double totalrecit = Convert.ToDouble(txtTotalRecit.Text);
            double totalexam = Convert.ToDouble(txtTotalExam.Text);

            double grade = totalrecit  + totalexam;

            double grade2 = grade;
            string finalresult = grade2.ToString("0.00");


            txtGrade.Text = finalresult;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            /**try
            {
                UCGrades frmGrade = new UCGrades();
                frmGrade.txtGrade.Text = txtGrade.Text;
                this.Hide();
                frmGrade.Show();
            }catch (Exception ex) {
                MessageBox.Show(" " + ex.Message);
            }**/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void termsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRELIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCalculator frmcalcu = new formCalculator();
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
    }
}
