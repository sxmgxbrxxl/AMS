namespace Student_Hub
{
    partial class formGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNavigation = new System.Windows.Forms.Label();
            this.lblTrueNavigation = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.pnlCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.cboTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseGrade = new System.Windows.Forms.Label();
            this.pnlCourse = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCourseContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGradeContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDeleteContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCalculatorContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCategory.SuspendLayout();
            this.pnlCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.BackColor = System.Drawing.Color.Transparent;
            this.lblNavigation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.ForeColor = System.Drawing.Color.DimGray;
            this.lblNavigation.Location = new System.Drawing.Point(30, 20);
            this.lblNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(167, 23);
            this.lblNavigation.TabIndex = 43;
            this.lblNavigation.Text = "Home / Student /";
            // 
            // lblTrueNavigation
            // 
            this.lblTrueNavigation.AutoSize = true;
            this.lblTrueNavigation.BackColor = System.Drawing.Color.Transparent;
            this.lblTrueNavigation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueNavigation.ForeColor = System.Drawing.Color.Black;
            this.lblTrueNavigation.Location = new System.Drawing.Point(190, 20);
            this.lblTrueNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrueNavigation.Name = "lblTrueNavigation";
            this.lblTrueNavigation.Size = new System.Drawing.Size(78, 23);
            this.lblTrueNavigation.TabIndex = 44;
            this.lblTrueNavigation.Text = "Grades";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.BackColor = System.Drawing.Color.Transparent;
            this.lblGrades.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(20, 50);
            this.lblGrades.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(195, 56);
            this.lblGrades.TabIndex = 45;
            this.lblGrades.Text = "Grades";
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.BorderColor = System.Drawing.Color.Black;
            this.pnlCategory.BorderRadius = 10;
            this.pnlCategory.Controls.Add(this.cboTerm);
            this.pnlCategory.Controls.Add(this.lblTerm);
            this.pnlCategory.FillColor = System.Drawing.Color.White;
            this.pnlCategory.Location = new System.Drawing.Point(30, 130);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.ShadowDecoration.BorderRadius = 15;
            this.pnlCategory.ShadowDecoration.Depth = 15;
            this.pnlCategory.ShadowDecoration.Enabled = true;
            this.pnlCategory.Size = new System.Drawing.Size(350, 133);
            this.pnlCategory.TabIndex = 46;
            // 
            // cboTerm
            // 
            this.cboTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTerm.BackColor = System.Drawing.Color.Transparent;
            this.cboTerm.BorderRadius = 17;
            this.cboTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTerm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTerm.ItemHeight = 30;
            this.cboTerm.Location = new System.Drawing.Point(20, 60);
            this.cboTerm.Margin = new System.Windows.Forms.Padding(0);
            this.cboTerm.MaxDropDownItems = 6;
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(310, 36);
            this.cboTerm.TabIndex = 4;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblTerm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTerm.Location = new System.Drawing.Point(20, 30);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(57, 22);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "TERM";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(50, 50);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(181, 28);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "COURSE NAME";
            // 
            // lblCourseGrade
            // 
            this.lblCourseGrade.AutoSize = true;
            this.lblCourseGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseGrade.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseGrade.Location = new System.Drawing.Point(480, 50);
            this.lblCourseGrade.Margin = new System.Windows.Forms.Padding(0);
            this.lblCourseGrade.Name = "lblCourseGrade";
            this.lblCourseGrade.Size = new System.Drawing.Size(192, 28);
            this.lblCourseGrade.TabIndex = 7;
            this.lblCourseGrade.Text = "COURSE GRADE";
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.Color.Transparent;
            this.pnlCourse.BorderColor = System.Drawing.Color.Black;
            this.pnlCourse.BorderRadius = 10;
            this.pnlCourse.Controls.Add(this.pnlCalculatorContainer);
            this.pnlCourse.Controls.Add(this.pnlDeleteContainer);
            this.pnlCourse.Controls.Add(this.pnlGradeContainer);
            this.pnlCourse.Controls.Add(this.pnlCourseContainer);
            this.pnlCourse.Controls.Add(this.lblCourseGrade);
            this.pnlCourse.Controls.Add(this.lblCourseName);
            this.pnlCourse.FillColor = System.Drawing.Color.White;
            this.pnlCourse.Location = new System.Drawing.Point(424, 80);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.ShadowDecoration.BorderRadius = 15;
            this.pnlCourse.ShadowDecoration.Depth = 15;
            this.pnlCourse.ShadowDecoration.Enabled = true;
            this.pnlCourse.Size = new System.Drawing.Size(802, 712);
            this.pnlCourse.TabIndex = 47;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = global::Student_Hub.Properties.Resources.Square_Plus;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(1108, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.Size = new System.Drawing.Size(118, 40);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Add Course";
            this.btnAdd.TextOffset = new System.Drawing.Point(15, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlCourseContainer
            // 
            this.pnlCourseContainer.Location = new System.Drawing.Point(55, 93);
            this.pnlCourseContainer.Name = "pnlCourseContainer";
            this.pnlCourseContainer.Size = new System.Drawing.Size(352, 577);
            this.pnlCourseContainer.TabIndex = 8;
            // 
            // pnlGradeContainer
            // 
            this.pnlGradeContainer.Location = new System.Drawing.Point(485, 93);
            this.pnlGradeContainer.Name = "pnlGradeContainer";
            this.pnlGradeContainer.Size = new System.Drawing.Size(187, 577);
            this.pnlGradeContainer.TabIndex = 9;
            // 
            // pnlDeleteContainer
            // 
            this.pnlDeleteContainer.Location = new System.Drawing.Point(672, 93);
            this.pnlDeleteContainer.Name = "pnlDeleteContainer";
            this.pnlDeleteContainer.Size = new System.Drawing.Size(47, 577);
            this.pnlDeleteContainer.TabIndex = 10;
            // 
            // pnlCalculatorContainer
            // 
            this.pnlCalculatorContainer.Location = new System.Drawing.Point(719, 93);
            this.pnlCalculatorContainer.Name = "pnlCalculatorContainer";
            this.pnlCalculatorContainer.Size = new System.Drawing.Size(47, 577);
            this.pnlCalculatorContainer.TabIndex = 11;
            // 
            // formGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Dashboard;
            this.ClientSize = new System.Drawing.Size(1270, 845);
            this.Controls.Add(this.pnlCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lblTrueNavigation);
            this.Controls.Add(this.lblNavigation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGrades";
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label lblTrueNavigation;
        private System.Windows.Forms.Label lblGrades;
        private Guna.UI2.WinForms.Guna2Panel pnlCategory;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseGrade;
        private Guna.UI2.WinForms.Guna2Panel pnlCourse;
        private Guna.UI2.WinForms.Guna2ComboBox cboTerm;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel pnlCourseContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlCalculatorContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlDeleteContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlGradeContainer;
    }
}