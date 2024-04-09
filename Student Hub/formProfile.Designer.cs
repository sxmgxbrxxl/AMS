namespace Student_Hub
{
    partial class formProfile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblTAge = new System.Windows.Forms.Label();
            this.lblTProgram = new System.Windows.Forms.Label();
            this.pnlPersonalInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTPersonalInfo = new System.Windows.Forms.Label();
            this.pnlEducationalBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTEducationalBackground = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrelim = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblFinals = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrelim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMidterm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFinals = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAverageGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlEducationalBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(30, 32);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(167, 38);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "PROFILE";
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.Image = global::Student_Hub.Properties.Resources.Profile_Placeholder;
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(64, 106);
            this.picProfile.Margin = new System.Windows.Forms.Padding(0);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.Size = new System.Drawing.Size(158, 171);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 1;
            this.picProfile.TabStop = false;
            this.picProfile.UseTransparentBackground = true;
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.BackColor = System.Drawing.Color.Transparent;
            this.lblTName.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.Location = new System.Drawing.Point(19, 57);
            this.lblTName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(75, 22);
            this.lblTName.TabIndex = 2;
            this.lblTName.Text = "NAME:";
            // 
            // lblTAge
            // 
            this.lblTAge.AutoSize = true;
            this.lblTAge.BackColor = System.Drawing.Color.Transparent;
            this.lblTAge.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAge.Location = new System.Drawing.Point(19, 87);
            this.lblTAge.Margin = new System.Windows.Forms.Padding(0);
            this.lblTAge.Name = "lblTAge";
            this.lblTAge.Size = new System.Drawing.Size(59, 22);
            this.lblTAge.TabIndex = 3;
            this.lblTAge.Text = "AGE:";
            // 
            // lblTProgram
            // 
            this.lblTProgram.AutoSize = true;
            this.lblTProgram.BackColor = System.Drawing.Color.Transparent;
            this.lblTProgram.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTProgram.Location = new System.Drawing.Point(16, 141);
            this.lblTProgram.Margin = new System.Windows.Forms.Padding(0);
            this.lblTProgram.Name = "lblTProgram";
            this.lblTProgram.Size = new System.Drawing.Size(123, 22);
            this.lblTProgram.TabIndex = 4;
            this.lblTProgram.Text = "PROGRAM:";
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPersonalInfo.BorderColor = System.Drawing.Color.Black;
            this.pnlPersonalInfo.BorderRadius = 20;
            this.pnlPersonalInfo.BorderThickness = 5;
            this.pnlPersonalInfo.Controls.Add(this.txtAverageGrade);
            this.pnlPersonalInfo.Controls.Add(this.txtFinals);
            this.pnlPersonalInfo.Controls.Add(this.txtMidterm);
            this.pnlPersonalInfo.Controls.Add(this.txtPrelim);
            this.pnlPersonalInfo.Controls.Add(this.txtAge);
            this.pnlPersonalInfo.Controls.Add(this.txtFullName);
            this.pnlPersonalInfo.Controls.Add(this.lblAverage);
            this.pnlPersonalInfo.Controls.Add(this.lblFinals);
            this.pnlPersonalInfo.Controls.Add(this.lblMidterm);
            this.pnlPersonalInfo.Controls.Add(this.lblPrelim);
            this.pnlPersonalInfo.Controls.Add(this.lblTPersonalInfo);
            this.pnlPersonalInfo.Controls.Add(this.lblTName);
            this.pnlPersonalInfo.Controls.Add(this.lblTAge);
            this.pnlPersonalInfo.FillColor = System.Drawing.Color.White;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(259, 49);
            this.pnlPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(414, 266);
            this.pnlPersonalInfo.TabIndex = 0;
            this.pnlPersonalInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPersonalInfo_Paint);
            // 
            // lblTPersonalInfo
            // 
            this.lblTPersonalInfo.AutoSize = true;
            this.lblTPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTPersonalInfo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPersonalInfo.Location = new System.Drawing.Point(90, 20);
            this.lblTPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTPersonalInfo.Name = "lblTPersonalInfo";
            this.lblTPersonalInfo.Size = new System.Drawing.Size(255, 25);
            this.lblTPersonalInfo.TabIndex = 4;
            this.lblTPersonalInfo.Text = "Personal Information";
            // 
            // pnlEducationalBackground
            // 
            this.pnlEducationalBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlEducationalBackground.BorderColor = System.Drawing.Color.Black;
            this.pnlEducationalBackground.BorderRadius = 20;
            this.pnlEducationalBackground.BorderThickness = 5;
            this.pnlEducationalBackground.Controls.Add(this.lblTEducationalBackground);
            this.pnlEducationalBackground.Controls.Add(this.lblTProgram);
            this.pnlEducationalBackground.FillColor = System.Drawing.Color.White;
            this.pnlEducationalBackground.Location = new System.Drawing.Point(30, 333);
            this.pnlEducationalBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEducationalBackground.Name = "pnlEducationalBackground";
            this.pnlEducationalBackground.Size = new System.Drawing.Size(645, 187);
            this.pnlEducationalBackground.TabIndex = 1;
            // 
            // lblTEducationalBackground
            // 
            this.lblTEducationalBackground.AutoSize = true;
            this.lblTEducationalBackground.BackColor = System.Drawing.Color.Transparent;
            this.lblTEducationalBackground.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEducationalBackground.Location = new System.Drawing.Point(188, 20);
            this.lblTEducationalBackground.Margin = new System.Windows.Forms.Padding(0);
            this.lblTEducationalBackground.Name = "lblTEducationalBackground";
            this.lblTEducationalBackground.Size = new System.Drawing.Size(295, 25);
            this.lblTEducationalBackground.TabIndex = 5;
            this.lblTEducationalBackground.Text = "Educational Background";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Student_Hub.Properties.Resources.Backdrop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 244);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrelim
            // 
            this.lblPrelim.AutoSize = true;
            this.lblPrelim.BackColor = System.Drawing.Color.Transparent;
            this.lblPrelim.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrelim.Location = new System.Drawing.Point(19, 117);
            this.lblPrelim.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrelim.Name = "lblPrelim";
            this.lblPrelim.Size = new System.Drawing.Size(184, 22);
            this.lblPrelim.TabIndex = 5;
            this.lblPrelim.Text = "PRELIM GRADE: ";
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.BackColor = System.Drawing.Color.Transparent;
            this.lblMidterm.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(19, 149);
            this.lblMidterm.Margin = new System.Windows.Forms.Padding(0);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(196, 22);
            this.lblMidterm.TabIndex = 6;
            this.lblMidterm.Text = "MIDTERM GRADE:";
            // 
            // lblFinals
            // 
            this.lblFinals.AutoSize = true;
            this.lblFinals.BackColor = System.Drawing.Color.Transparent;
            this.lblFinals.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinals.Location = new System.Drawing.Point(19, 181);
            this.lblFinals.Margin = new System.Windows.Forms.Padding(0);
            this.lblFinals.Name = "lblFinals";
            this.lblFinals.Size = new System.Drawing.Size(171, 22);
            this.lblFinals.TabIndex = 7;
            this.lblFinals.Text = "FINALS GRADE:";
            this.lblFinals.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.Color.Transparent;
            this.lblAverage.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(19, 213);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(117, 22);
            this.lblAverage.TabIndex = 8;
            this.lblAverage.Text = "AVERAGE:";
            // 
            // txtFullName
            // 
            this.txtFullName.AcceptsTab = true;
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.BorderThickness = 2;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(104, 47);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(277, 32);
            this.txtFullName.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.AcceptsTab = true;
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.BorderRadius = 10;
            this.txtAge.BorderThickness = 2;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Location = new System.Drawing.Point(104, 82);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderText = "";
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(99, 32);
            this.txtAge.TabIndex = 10;
            // 
            // txtPrelim
            // 
            this.txtPrelim.AcceptsTab = true;
            this.txtPrelim.BackColor = System.Drawing.Color.Transparent;
            this.txtPrelim.BorderRadius = 10;
            this.txtPrelim.BorderThickness = 2;
            this.txtPrelim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrelim.DefaultText = "";
            this.txtPrelim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrelim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrelim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrelim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrelim.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrelim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrelim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrelim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrelim.Location = new System.Drawing.Point(217, 107);
            this.txtPrelim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrelim.Name = "txtPrelim";
            this.txtPrelim.PasswordChar = '\0';
            this.txtPrelim.PlaceholderText = "";
            this.txtPrelim.ReadOnly = true;
            this.txtPrelim.SelectedText = "";
            this.txtPrelim.Size = new System.Drawing.Size(99, 32);
            this.txtPrelim.TabIndex = 11;
            // 
            // txtMidterm
            // 
            this.txtMidterm.AcceptsTab = true;
            this.txtMidterm.BackColor = System.Drawing.Color.Transparent;
            this.txtMidterm.BorderRadius = 10;
            this.txtMidterm.BorderThickness = 2;
            this.txtMidterm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMidterm.DefaultText = "";
            this.txtMidterm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMidterm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMidterm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMidterm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMidterm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMidterm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMidterm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMidterm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMidterm.Location = new System.Drawing.Point(217, 139);
            this.txtMidterm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.PasswordChar = '\0';
            this.txtMidterm.PlaceholderText = "";
            this.txtMidterm.ReadOnly = true;
            this.txtMidterm.SelectedText = "";
            this.txtMidterm.Size = new System.Drawing.Size(99, 32);
            this.txtMidterm.TabIndex = 12;
            // 
            // txtFinals
            // 
            this.txtFinals.AcceptsTab = true;
            this.txtFinals.BackColor = System.Drawing.Color.Transparent;
            this.txtFinals.BorderRadius = 10;
            this.txtFinals.BorderThickness = 2;
            this.txtFinals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinals.DefaultText = "";
            this.txtFinals.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinals.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinals.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFinals.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFinals.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinals.Location = new System.Drawing.Point(217, 171);
            this.txtFinals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFinals.Name = "txtFinals";
            this.txtFinals.PasswordChar = '\0';
            this.txtFinals.PlaceholderText = "";
            this.txtFinals.ReadOnly = true;
            this.txtFinals.SelectedText = "";
            this.txtFinals.Size = new System.Drawing.Size(99, 32);
            this.txtFinals.TabIndex = 13;
            // 
            // txtAverageGrade
            // 
            this.txtAverageGrade.AcceptsTab = true;
            this.txtAverageGrade.BackColor = System.Drawing.Color.Transparent;
            this.txtAverageGrade.BorderRadius = 10;
            this.txtAverageGrade.BorderThickness = 2;
            this.txtAverageGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAverageGrade.DefaultText = "";
            this.txtAverageGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAverageGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAverageGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAverageGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAverageGrade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAverageGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAverageGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAverageGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAverageGrade.Location = new System.Drawing.Point(217, 203);
            this.txtAverageGrade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAverageGrade.Name = "txtAverageGrade";
            this.txtAverageGrade.PasswordChar = '\0';
            this.txtAverageGrade.PlaceholderText = "";
            this.txtAverageGrade.ReadOnly = true;
            this.txtAverageGrade.SelectedText = "";
            this.txtAverageGrade.Size = new System.Drawing.Size(99, 32);
            this.txtAverageGrade.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(488, 13);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // formProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 640);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.pnlEducationalBackground);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.pnlPersonalInfo);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProfile";
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            this.pnlEducationalBackground.ResumeLayout(false);
            this.pnlEducationalBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblTAge;
        private System.Windows.Forms.Label lblTProgram;
        private Guna.UI2.WinForms.Guna2Panel pnlPersonalInfo;
        private System.Windows.Forms.Label lblTPersonalInfo;
        private Guna.UI2.WinForms.Guna2Panel pnlEducationalBackground;
        private System.Windows.Forms.Label lblTEducationalBackground;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinals;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblPrelim;
        private System.Windows.Forms.Label lblAverage;
        private Guna.UI2.WinForms.Guna2TextBox txtMidterm;
        private Guna.UI2.WinForms.Guna2TextBox txtPrelim;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtAverageGrade;
        private Guna.UI2.WinForms.Guna2TextBox txtFinals;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}