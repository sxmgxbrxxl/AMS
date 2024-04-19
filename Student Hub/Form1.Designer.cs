namespace Student_Hub
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlWelcome = new Guna.UI2.WinForms.Guna2Panel();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.lnkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStudentNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ctrMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnlWelcome.BorderColor = System.Drawing.Color.Black;
            this.pnlWelcome.BorderRadius = 20;
            this.pnlWelcome.BorderThickness = 2;
            this.pnlWelcome.Controls.Add(this.chkShowPass);
            this.pnlWelcome.Controls.Add(this.lnkSignUp);
            this.pnlWelcome.Controls.Add(this.lblQuestion);
            this.pnlWelcome.Controls.Add(this.btnLogin);
            this.pnlWelcome.Controls.Add(this.lblPassword);
            this.pnlWelcome.Controls.Add(this.txtPassword);
            this.pnlWelcome.Controls.Add(this.txtStudentNumber);
            this.pnlWelcome.Controls.Add(this.lblStudentNumber);
            this.pnlWelcome.Controls.Add(this.lblTitle);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlWelcome.FillColor = System.Drawing.Color.White;
            this.pnlWelcome.Location = new System.Drawing.Point(255, 60);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(531, 490);
            this.pnlWelcome.TabIndex = 2;
            // 
            // chkShowPass
            // 
            this.chkShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.Location = new System.Drawing.Point(44, 332);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(146, 23);
            this.chkShowPass.TabIndex = 2;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSignUp.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSignUp.Location = new System.Drawing.Point(229, 450);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(67, 19);
            this.lnkSignUp.TabIndex = 4;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Sign Up";
            this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestion.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(40, 450);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(184, 19);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Don\'t have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Tan;
            this.btnLogin.FocusedColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(200, 370);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 245);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 274);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(451, 50);
            this.txtPassword.TabIndex = 1;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.AcceptsTab = true;
            this.txtStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentNumber.BorderRadius = 10;
            this.txtStudentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNumber.DefaultText = "";
            this.txtStudentNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.Location = new System.Drawing.Point(40, 180);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.PlaceholderText = "0000000";
            this.txtStudentNumber.SelectedText = "";
            this.txtStudentNumber.Size = new System.Drawing.Size(451, 50);
            this.txtStudentNumber.TabIndex = 0;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStudentNumber.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(40, 145);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(187, 20);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "STUDENT NUMBER:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(132, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Academic Mastery System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(140, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(251, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // ctrMinimize
            // 
            this.ctrMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ctrMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ctrMinimize.IconColor = System.Drawing.Color.Black;
            this.ctrMinimize.Location = new System.Drawing.Point(835, 0);
            this.ctrMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMinimize.Name = "ctrMinimize";
            this.ctrMinimize.Size = new System.Drawing.Size(55, 46);
            this.ctrMinimize.TabIndex = 9;
            // 
            // ctrMaximize
            // 
            this.ctrMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.IconColor = System.Drawing.Color.Black;
            this.ctrMaximize.Location = new System.Drawing.Point(890, 0);
            this.ctrMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMaximize.Name = "ctrMaximize";
            this.ctrMaximize.Size = new System.Drawing.Size(55, 46);
            this.ctrMaximize.TabIndex = 8;
            // 
            // ctrClose
            // 
            this.ctrClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrClose.BackColor = System.Drawing.Color.Transparent;
            this.ctrClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrClose.IconColor = System.Drawing.Color.Black;
            this.ctrClose.Location = new System.Drawing.Point(945, 0);
            this.ctrClose.Margin = new System.Windows.Forms.Padding(0);
            this.ctrClose.Name = "ctrClose";
            this.ctrClose.Size = new System.Drawing.Size(55, 46);
            this.ctrClose.TabIndex = 7;
            this.ctrClose.Click += new System.EventHandler(this.ctrClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ctrMinimize);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.ctrMaximize);
            this.Controls.Add(this.ctrClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkSignUp;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckBox chkShowPass;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrClose;
    }
}

