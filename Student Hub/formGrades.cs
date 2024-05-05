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
        string[] term = { "Prelim", "Midterm", "Finals" };
        string[] course = {"Introduction to Computing", "Computer Programming 1 (Fundamentals of Programming)", "Understanding the Self",
                            "Readings in Philippine History", "Mathematics in the Modern World", "Purposive Communication", "Environmental Science",
                            "Civic Welfare Training Service 1", "Reserve Officers Training Corps 1", "Self-Testing Activities"};
        public formGrades()
        {
            InitializeComponent();
            cboTerm.Items.AddRange(term);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            formCalculator frmCalc1 = new formCalculator();
            frmCalc1.Show();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btnDelete = (Guna.UI2.WinForms.Guna2Button)sender;
            int counter = int.Parse(btnDelete.Name.Replace("btnDelete", ""));

            Control[] controlsToDelete = pnlCourse.Controls.Find("cboCourse" + counter, true);
            foreach (Control control in controlsToDelete)
            {
                pnlCourse.Controls.Remove(control);
                control.Dispose();
            }

            controlsToDelete = pnlCourse.Controls.Find("txtGrade" + counter, true);
            foreach (Control control in controlsToDelete)
            {
                pnlCourse.Controls.Remove(control);
                control.Dispose(); 
            }

            controlsToDelete = pnlCourse.Controls.Find("btnDelete" + counter, true);
            foreach (Control control in controlsToDelete)
            {
                pnlCourse.Controls.Remove(control);
                control.Dispose();
            }

            controlsToDelete = pnlCourse.Controls.Find("btnCalc" + counter, true);
            foreach (Control control in controlsToDelete)
            {
                pnlCourse.Controls.Remove(control);
                control.Dispose(); 
            }
        }

        private int courseCounter = 1;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourse();
        }

        private void AddCourse()
        {
            Guna.UI2.WinForms.Guna2ComboBox cboCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            cboCourse.ItemHeight = 34;
            cboCourse.Dock = DockStyle.Top;
            cboCourse.Name = "cboCourse" + courseCounter;
            cboCourse.BorderRadius = 17;
            cboCourse.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            cboCourse.Size = new Size(350, 40);
            cboCourse.Items.AddRange(course);
            pnlCourseContainer.Controls.Add(cboCourse);

            Guna.UI2.WinForms.Guna2TextBox txtGrade = new Guna.UI2.WinForms.Guna2TextBox();
            txtGrade.Dock = DockStyle.Top;
            txtGrade.Name = "txtGrade" + courseCounter;
            txtGrade.BorderRadius = 17;
            txtGrade.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            txtGrade.Size = new Size(187, 40);
            pnlGradeContainer.Controls.Add(txtGrade);

            Guna.UI2.WinForms.Guna2Button btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Name = "btnDelete" + courseCounter;
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Size = new Size(38, 40);
            btnDelete.Image = Properties.Resources.Square_Minus;
            btnDelete.Click += DeleteButton_Click;
            pnlDeleteContainer.Controls.Add(btnDelete);

            Guna.UI2.WinForms.Guna2Button btnCalc = new Guna.UI2.WinForms.Guna2Button();
            btnCalc.Dock = DockStyle.Top;
            btnCalc.Name = "btnCalc" + courseCounter;
            btnCalc.FillColor = Color.Transparent;
            btnCalc.Size = new Size(38, 40);
            btnCalc.Image = Properties.Resources.calculator;
            btnCalc.Click += btnCalc_Click;
            pnlCalculatorContainer.Controls.Add(btnCalc);

            courseCounter++;
        }
    }
}
