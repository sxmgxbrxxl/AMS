using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Student_Hub
{
    public partial class formGrades : Form
    {
        private int labelCounter = 1;
        public static string txtGrade1 {  get; set; }
        public static string txtGrade2 { get; set; }
        public static string txtGrade3 { get; set; }
        public static string txtGrade4 { get; set; }
        public static string txtGrade5 { get; set; }
        public static string txtGrade6 { get; set; }
        public static string txtGrade7 { get; set; }
        public static string txtGrade8 { get; set; }
        public static string txtGrade9 { get; set; }

     

        public formGrades()
        {
            InitializeComponent();
            formCalculator frmCalc = new formCalculator();
            txtcrsGrade1.Text = formCalculator.Grade;
        }

        private void btncalc1_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc1 = new formCalculator();
            this.Hide();
            frmCalc1.Show();
            


        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc2 = new formCalculator();
            this.Hide();
            frmCalc2.Show();
        }

        private void btncalc3_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc3 = new formCalculator();
            this.Hide();
            frmCalc3.Show();
        }

        private void btncalc4_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc4 = new formCalculator();
            this.Hide();
            frmCalc4.Show();
        }

        private void btncalc5_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc5 = new formCalculator();
            this.Hide();
            frmCalc5.Show();
        }

        private void btncalc6_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc6 = new formCalculator();
            this.Hide();
            frmCalc6.Show();
        }

        private void btncalc7_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc7 = new formCalculator();
            this.Hide();
            frmCalc7.Show();
        }

        private void btncalc8_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc8 = new formCalculator();
            this.Hide();
            frmCalc8.Show();
        }

        private void btncalc9_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc9 = new formCalculator();
            this.Hide();
            frmCalc9.Show();
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if (btnMinus1.Enabled)
            {
                txtcrsName1.Visible = false;
                txtcrsGrade1.Visible = false;
                btnMinus1.Visible = false;  
            }
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {

            if (btnMinus2.Enabled)
            {
                txtcrsName2.Visible = false;
                txtcrsGrade2.Visible = false;
                btnMinus2.Visible = false;  
            }
        }

        private void btnMinus3_Click(object sender, EventArgs e)
        {
            if (btnMinus3.Enabled)
            {
                txtcrsName3.Visible = false;
                txtcrsGrade3.Visible = false;
                btnMinus3.Visible = false;  
            }
        }

        private void btnMinus4_Click(object sender, EventArgs e)
        {
            if (btnMinus4.Enabled)
            {
                txtcrsName4.Visible = false;
                txtcrsGrade4.Visible = false;
                btnMinus4.Visible = false;  
            }
        }

        private void btnMinus5_Click(object sender, EventArgs e)
        {
            if (btnMinus5.Enabled)
            {
                txtcrsName5.Visible = false;
                txtcrsGrade5.Visible = false;
                btnMinus5.Visible = false;
            }
        }

        private void btnMinus6_Click(object sender, EventArgs e)
        {
            if (btnMinus6.Enabled)
            {
                txtcrsName6.Visible = false;
                txtcrsGrade6.Visible = false;
                btnMinus6.Visible = false;
            }
        }

        private void btnMinus7_Click(object sender, EventArgs e)
        {
            if (btnMinus7.Enabled)
            {
                txtcrsName7.Visible = false;
                txtcrsGrade7.Visible = false;
                btnMinus7.Visible = false;
            }
        }

        private void btnMinus8_Click(object sender, EventArgs e)
        {
            if (btnMinus8.Enabled)
            {
                txtcrsName8.Visible = false;
                txtcrsGrade8.Visible = false;
                btnMinus8.Visible = false;
            }
        }

        private void btnMinus9_Click(object sender, EventArgs e)
        {
            if (btnMinus9.Enabled)
            {
                txtcrsName9.Visible = false;
                txtcrsGrade9.Visible = false;
                btnMinus9.Visible = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void chkPrelim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formGrades_Load(object sender, EventArgs e)
        {
            if (chkPrelim.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtPrelimGrade.Text = (" " + txtTotalGrade.Text);
                }
            }
            else if (chkMidterm.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtMidtermGrade.Text = (" " + txtTotalGrade.Text);
                }
            }
            else if (chkFinals.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtFinalGrade.Text = (" " + txtTotalGrade.Text);
                }
            }

        }

        private void txtcrsGrade1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrsGrade9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
