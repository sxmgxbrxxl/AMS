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
        public static string Grade {  get; set; }
       
        public formCalculator()
        {
            InitializeComponent();

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();

            Button button = (Button)sender;
            txtResult.Text = txtResult.Text + button.Text;
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

        private void btnSaveRecit_Click(object sender, EventArgs e)
        {
            txtRecitation.Text = txtResult.Text;
        }

        private void btnOverRecit_Click(object sender, EventArgs e)
        {
            txtOverRecit.Text = txtResult.Text;
        }

        private void btnPercentageRecit_Click(object sender, EventArgs e)
        {
            txtPercentRecit.Text = txtResult.Text + "%";
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            txtTask.Text = (" " + txtResult.Text);
        }

        private void btnOverTask_Click(object sender, EventArgs e)
        {
            txtOverTask.Text = txtResult.Text;
        }

        private void btnPercentageTask_Click(object sender, EventArgs e)
        {
            txtPercentTask.Text = txtResult.Text + "%";
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            txtQuizes.Text = txtResult.Text;
        }

        private void btnOverQuiz_Click(object sender, EventArgs e)
        {
            txtOverQuiz.Text = txtResult.Text;
        }

        private void btnPercentageQuiz_Click(object sender, EventArgs e)
        {
            txtPercentQuiz.Text = txtResult.Text + "%";
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            txtExam.Text = txtResult.Text;
        }

        private void btnOverExam_Click(object sender, EventArgs e)
        {
            txtOverExam.Text = txtResult.Text;
        }

        private void btnPercentageExam_Click(object sender, EventArgs e)
        {
            txtPercentExam.Text = txtResult.Text + "%";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
