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

        public formGrades()
        {
            InitializeComponent();
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
            pnlCourse.Controls.Add(newLabel);

            // Create a new textbox
            Guna2TextBox newTextBox = new Guna2TextBox();
            newTextBox.Location = new Point(171, 124 + labelCounter * 30); // Adjust the position based on counter
            newTextBox.Size = new System.Drawing.Size(150, 32);
            newTextBox.BorderRadius = 10;
            newTextBox.BackColor = System.Drawing.Color.Transparent;
            newTextBox.ForeColor =  System.Drawing.Color.Black;

            newTextBox.FillColor = System.Drawing.Color.Tan;
            newTextBox.ReadOnly = true;
            pnlCourse.Controls.Add(newTextBox);

            labelCounter++; // Increment the counter for the next label and textbox
        }
    }
}
