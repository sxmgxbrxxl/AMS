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
    public partial class UCRecords : UserControl
    {
        public UCRecords()
        {
            InitializeComponent();
            Category();
        }

        private void Category()
        {
            string[] year = { "1st", "2nd", "3rd", "4th" };
            string[] sem = { "1st Sem", "2nd Sem" };

            cboYear.Items.AddRange(year);
            cboSemester.Items.AddRange(sem);
        }
    }
}
