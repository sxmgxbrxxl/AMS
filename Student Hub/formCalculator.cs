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
        double firstvalue = 0;
        double secondvalue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public static string Grade {  get; set; }
       

        public formCalculator()
        {
            InitializeComponent();

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (isOperationPerformed))
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

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            firstvalue = double.Parse(txtResult.Text);
            lblPreview.Text = firstvalue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblPreview.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
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
            lblPreview.Text = firstvalue + " " + operationPerformed + " " + secondvalue + " =";
        }

        private void btnSaveRecit_Click(object sender, EventArgs e)
        {

            if (btnSaveRecit.Enabled)
            {
                txtRecitation.Text = (" " + txtResult.Text);
            }
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            if (btnSaveTask.Enabled)
            {
                txtTask.Text = (" " + txtResult.Text);
            }
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            if (btnSaveQuiz.Enabled)
            {
                txtQuizes.Text = (" " + txtResult.Text);
            }
        }

        private void formCalculator_Load(object sender, EventArgs e)
        {
          
        }

        private void btnEqlRecit_Click(object sender, EventArgs e)
        {

            double percentRecit = Convert.ToDouble(txtPercentRecit.Text);
            double pRresult = percentRecit / 100;


            double recit = Convert.ToDouble(txtRecitation.Text);
            double overrecit = Convert.ToDouble(txtOverRecit.Text);

            double recitresult = (recit / overrecit) * 50 + 50;

            double rresult = recitresult * pRresult;

            txtTotalRecit.Text = Convert.ToString(rresult);

        }

        private void btnEqlTask_Click(object sender, EventArgs e)
        {
            double percentTask = Convert.ToDouble(txtPercentTask.Text);
            double pTresult = percentTask / 100;

            double task = Convert.ToDouble(txtTask.Text);
            double overTask = Convert.ToDouble(txtOverTask.Text);

            double taskresult = (task / overTask) * 50 + 50;

            double tresult = taskresult * pTresult;

            txtTotalTask.Text = Convert.ToString(tresult);

        }

        private void btnEqlQuiz_Click(object sender, EventArgs e)
        {
            double percentQuiz = Convert.ToDouble(txtPercentQuiz.Text);
            double pQresult = percentQuiz / 100;

            double quiz = Convert.ToDouble(txtQuizes.Text);
            double overQuiz = Convert.ToDouble(txtOverQuiz.Text);

            double quizresult = (quiz / overQuiz) * 50 + 50;

            double qresult = quizresult * pQresult;

            txtTotalQuiz.Text = Convert.ToString(qresult);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double percentExam = Convert.ToDouble(txtPercentExam.Text);
            double pEresult = percentExam / 100;

            double exam = Convert.ToDouble(txtExam.Text);
            double overExam = Convert.ToDouble(txtOverExam.Text);

            double examresult = (exam / overExam) * 50 + 50;

            double eresult = examresult * pEresult;
            double eresult2 = eresult;
            string finalscore = eresult2.ToString("0.00");

            txtTotalExam.Text = finalscore;

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double totalrecit = Convert.ToDouble(txtTotalRecit.Text);
            double totaltask = Convert.ToDouble(txtTotalTask.Text);
            double totalquiz = Convert.ToDouble(txtTotalQuiz.Text);
            double totalexam = Convert.ToDouble(txtTotalExam.Text);

            double grade = totalrecit + totaltask + totalquiz + totalexam;

            double grade2 = grade;
            string finalresult = grade2.ToString("0.00");


            txtGrade.Text = finalresult;
            Grade = txtGrade.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
               
            }
        }
    }
}
