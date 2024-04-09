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
        private int labelCounter = 0;
        
        public formGrades()
        {
            InitializeComponent();
            
        }

        private void formGrades_Load(object sender, EventArgs e)
        {
            if(chkPrelim.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtPrelimGrade.Text = (" " + txtTotalGrade.Text);
                }
            }else if(chkMidterm.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtMidtermGrade.Text = (" " + txtTotalGrade.Text);  
                }
            }else if(chkFinals.Checked)
            {
                if (btnTotal.Enabled)
                {
                    txtFinalGrade.Text = (" " + txtTotalGrade.Text);
                }
            }
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            // Create a new label
            Guna2HtmlLabel newLabel = new Guna2HtmlLabel();
            Font font = new Font("Bookman Old Style", 15, FontStyle.Regular);
            newLabel.Text = "Course " + labelCounter.ToString();
            newLabel.Size = new System.Drawing.Size(170, 32 * 30);
            
            newLabel.Font = font;
            newLabel.BackColor = System.Drawing.Color.Transparent;    
            newLabel.Location = new Point(53, 124 + labelCounter * 30); // Adjust the position based on counter
            this.Controls.Add(newLabel);

            // Create a new textbox
            Guna2TextBox newTextBox = new Guna2TextBox();
            Border3DStyle border = Border3DStyle.SunkenOuter;
            newTextBox.Location = new Point(171, 124 + labelCounter * 30); // Adjust the position based on counter
            newTextBox.Size = new System.Drawing.Size(150, 32);
            newTextBox.BorderRadius = 10;
            newTextBox.BackColor = System.Drawing.Color.Transparent;
            newTextBox.ForeColor =  System.Drawing.Color.Black;
            
            newTextBox.FillColor = System.Drawing.Color.Tan;
            newTextBox.ReadOnly = true;
            this.Controls.Add(newTextBox);

            labelCounter++; // Increment the counter for the next label and textbox
        }

       
    }
}
