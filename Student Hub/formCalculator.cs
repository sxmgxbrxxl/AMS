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

        public formCalculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (isOperationPerformed))
                txtResult.Clear();

            isOperationPerformed = false;
            Button button = (Button) sender;

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

    }
}
