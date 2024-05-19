namespace Student_Hub
{
    partial class UCGrades
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.cboSem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cboYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblTrueNavigation = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.lblCourseGrade = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.pnlCourse = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEntries = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCalculator = new Guna.UI2.WinForms.Guna2Button();
            this.txtGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCategory.SuspendLayout();
            this.pnlCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.pnlEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.BorderColor = System.Drawing.Color.Black;
            this.pnlCategory.BorderRadius = 10;
            this.pnlCategory.Controls.Add(this.cboSem);
            this.pnlCategory.Controls.Add(this.lblSemester);
            this.pnlCategory.Controls.Add(this.cboYear);
            this.pnlCategory.Controls.Add(this.lblTerm);
            this.pnlCategory.Controls.Add(this.lblYear);
            this.pnlCategory.Controls.Add(this.cboTerm);
            this.pnlCategory.FillColor = System.Drawing.Color.White;
            this.pnlCategory.Location = new System.Drawing.Point(30, 130);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.ShadowDecoration.BorderRadius = 15;
            this.pnlCategory.ShadowDecoration.Depth = 15;
            this.pnlCategory.ShadowDecoration.Enabled = true;
            this.pnlCategory.Size = new System.Drawing.Size(350, 307);
            this.pnlCategory.TabIndex = 72;
            // 
            // cboSem
            // 
            this.cboSem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSem.BackColor = System.Drawing.Color.Transparent;
            this.cboSem.BorderRadius = 17;
            this.cboSem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSem.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboSem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSem.ItemHeight = 30;
            this.cboSem.Location = new System.Drawing.Point(20, 145);
            this.cboSem.Margin = new System.Windows.Forms.Padding(0);
            this.cboSem.MaxDropDownItems = 6;
            this.cboSem.Name = "cboSem";
            this.cboSem.Size = new System.Drawing.Size(310, 36);
            this.cboSem.TabIndex = 8;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.Transparent;
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSemester.Location = new System.Drawing.Point(20, 115);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(95, 22);
            this.lblSemester.TabIndex = 7;
            this.lblSemester.Text = "SEMESTER";
            // 
            // cboYear
            // 
            this.cboYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboYear.BackColor = System.Drawing.Color.Transparent;
            this.cboYear.BorderRadius = 17;
            this.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboYear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboYear.ItemHeight = 30;
            this.cboYear.Location = new System.Drawing.Point(20, 60);
            this.cboYear.Margin = new System.Windows.Forms.Padding(0);
            this.cboYear.MaxDropDownItems = 6;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(310, 36);
            this.cboYear.TabIndex = 6;
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTerm.AutoSize = true;
            this.lblTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblTerm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTerm.Location = new System.Drawing.Point(20, 200);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(57, 22);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "TERM";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblYear.Location = new System.Drawing.Point(20, 30);
            this.lblYear.Margin = new System.Windows.Forms.Padding(0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 22);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "YEAR";
            // 
            // cboTerm
            // 
            this.cboTerm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTerm.BackColor = System.Drawing.Color.Transparent;
            this.cboTerm.BorderRadius = 17;
            this.cboTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTerm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTerm.ItemHeight = 30;
            this.cboTerm.Location = new System.Drawing.Point(20, 230);
            this.cboTerm.Margin = new System.Windows.Forms.Padding(0);
            this.cboTerm.MaxDropDownItems = 6;
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(310, 36);
            this.cboTerm.TabIndex = 4;
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
            this.lblGrades.TabIndex = 71;
            this.lblGrades.Text = "Grades";
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
            this.lblTrueNavigation.TabIndex = 70;
            this.lblTrueNavigation.Text = "Grades";
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
            this.lblNavigation.TabIndex = 69;
            this.lblNavigation.Text = "Home / Student /";
            // 
            // lblCourseGrade
            // 
            this.lblCourseGrade.AutoSize = true;
            this.lblCourseGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseGrade.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseGrade.Location = new System.Drawing.Point(384, 25);
            this.lblCourseGrade.Margin = new System.Windows.Forms.Padding(0);
            this.lblCourseGrade.Name = "lblCourseGrade";
            this.lblCourseGrade.Size = new System.Drawing.Size(192, 28);
            this.lblCourseGrade.TabIndex = 7;
            this.lblCourseGrade.Text = "COURSE GRADE";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(25, 25);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(181, 28);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "COURSE NAME";
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.Color.Transparent;
            this.pnlCourse.BorderColor = System.Drawing.Color.Black;
            this.pnlCourse.BorderRadius = 10;
            this.pnlCourse.Controls.Add(this.dgvGrades);
            this.pnlCourse.FillColor = System.Drawing.Color.White;
            this.pnlCourse.Location = new System.Drawing.Point(420, 300);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.ShadowDecoration.BorderRadius = 15;
            this.pnlCourse.ShadowDecoration.Depth = 15;
            this.pnlCourse.ShadowDecoration.Enabled = true;
            this.pnlCourse.Size = new System.Drawing.Size(802, 491);
            this.pnlCourse.TabIndex = 73;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrades.Location = new System.Drawing.Point(30, 35);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(745, 430);
            this.dgvGrades.TabIndex = 0;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Term";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Course Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Grade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.btnAdd.Location = new System.Drawing.Point(634, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.Size = new System.Drawing.Size(118, 40);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.TextOffset = new System.Drawing.Point(15, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlEntries
            // 
            this.pnlEntries.BackColor = System.Drawing.Color.Transparent;
            this.pnlEntries.BorderColor = System.Drawing.Color.Black;
            this.pnlEntries.BorderRadius = 10;
            this.pnlEntries.Controls.Add(this.btnCalculator);
            this.pnlEntries.Controls.Add(this.txtGrade);
            this.pnlEntries.Controls.Add(this.lblCourseGrade);
            this.pnlEntries.Controls.Add(this.cboCourse);
            this.pnlEntries.Controls.Add(this.lblCourseName);
            this.pnlEntries.Controls.Add(this.btnAdd);
            this.pnlEntries.FillColor = System.Drawing.Color.White;
            this.pnlEntries.Location = new System.Drawing.Point(420, 130);
            this.pnlEntries.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEntries.Name = "pnlEntries";
            this.pnlEntries.ShadowDecoration.BorderRadius = 15;
            this.pnlEntries.ShadowDecoration.Depth = 15;
            this.pnlEntries.ShadowDecoration.Enabled = true;
            this.pnlEntries.Size = new System.Drawing.Size(802, 133);
            this.pnlEntries.TabIndex = 73;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculator.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculator.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculator.FillColor = System.Drawing.Color.Transparent;
            this.btnCalculator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCalculator.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCalculator.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCalculator.Image = global::Student_Hub.Properties.Resources.calculator;
            this.btnCalculator.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCalculator.Location = new System.Drawing.Point(596, 60);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.PressedColor = System.Drawing.Color.Transparent;
            this.btnCalculator.Size = new System.Drawing.Size(38, 40);
            this.btnCalculator.TabIndex = 75;
            this.btnCalculator.TextOffset = new System.Drawing.Point(15, 0);
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.AcceptsReturn = true;
            this.txtGrade.BorderRadius = 17;
            this.txtGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrade.DefaultText = "";
            this.txtGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.Location = new System.Drawing.Point(389, 60);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PasswordChar = '\0';
            this.txtGrade.PlaceholderText = "";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.SelectedText = "";
            this.txtGrade.Size = new System.Drawing.Size(187, 36);
            this.txtGrade.TabIndex = 8;
            // 
            // cboCourse
            // 
            this.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCourse.BackColor = System.Drawing.Color.Transparent;
            this.cboCourse.BorderRadius = 17;
            this.cboCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCourse.ItemHeight = 30;
            this.cboCourse.Location = new System.Drawing.Point(30, 60);
            this.cboCourse.Margin = new System.Windows.Forms.Padding(0);
            this.cboCourse.MaxDropDownItems = 9;
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(310, 36);
            this.cboCourse.TabIndex = 4;
            // 
            // UCGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Dashboard;
            this.Controls.Add(this.pnlEntries);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lblTrueNavigation);
            this.Controls.Add(this.lblNavigation);
            this.Controls.Add(this.pnlCourse);
            this.Name = "UCGrades";
            this.Size = new System.Drawing.Size(1275, 850);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.pnlEntries.ResumeLayout(false);
            this.pnlEntries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cboTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Label lblTrueNavigation;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label lblCourseGrade;
        private System.Windows.Forms.Label lblCourseName;
        private Guna.UI2.WinForms.Guna2Panel pnlCourse;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel pnlEntries;
        private Guna.UI2.WinForms.Guna2ComboBox cboCourse;
        private Guna.UI2.WinForms.Guna2Button btnCalculator;
        private System.Windows.Forms.DataGridView dgvGrades;
        private Guna.UI2.WinForms.Guna2ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
        private Guna.UI2.WinForms.Guna2ComboBox cboSem;
        private System.Windows.Forms.Label lblSemester;
        internal Guna.UI2.WinForms.Guna2TextBox txtGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
