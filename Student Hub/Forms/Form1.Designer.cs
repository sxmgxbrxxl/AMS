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
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
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
            this.pnlWelcome.Controls.Add(this.lnkForgot);
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
            this.pnlWelcome.Location = new System.Drawing.Point(260, 70);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(490, 470);
            this.pnlWelcome.TabIndex = 2;
            // 
            // lnkForgot
            // 
            this.lnkForgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkForgot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgot.Location = new System.Drawing.Point(325, 301);
            this.lnkForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(115, 17);
            this.lnkForgot.TabIndex = 5;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot Password";
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);
            // 
            // chkShowPass
            // 
            this.chkShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.Location = new System.Drawing.Point(40, 300);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(127, 21);
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
            this.lnkSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSignUp.Location = new System.Drawing.Point(210, 420);
            this.lnkSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(55, 17);
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
            this.lblQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(40, 420);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(168, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Don\'t have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Tan;
            this.btnLogin.FocusedColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(180, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 220);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 19);
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
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(400, 40);
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
            this.txtStudentNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.Location = new System.Drawing.Point(40, 170);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.PlaceholderText = "0000000";
            this.txtStudentNumber.SelectedText = "";
            this.txtStudentNumber.Size = new System.Drawing.Size(400, 40);
            this.txtStudentNumber.TabIndex = 0;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStudentNumber.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(40, 140);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(178, 19);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "STUDENT NUMBER:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 90);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Academic Mastery System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(130, 50);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(229, 32);
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
            this.ctrMinimize.Location = new System.Drawing.Point(876, 0);
            this.ctrMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMinimize.Name = "ctrMinimize";
            this.ctrMinimize.Size = new System.Drawing.Size(41, 37);
            this.ctrMinimize.TabIndex = 9;
            // 
            // ctrMaximize
            // 
            this.ctrMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.IconColor = System.Drawing.Color.Black;
            this.ctrMaximize.Location = new System.Drawing.Point(918, 0);
            this.ctrMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMaximize.Name = "ctrMaximize";
            this.ctrMaximize.Size = new System.Drawing.Size(41, 37);
            this.ctrMaximize.TabIndex = 8;
            // 
            // ctrClose
            // 
            this.ctrClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrClose.BackColor = System.Drawing.Color.Transparent;
            this.ctrClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrClose.IconColor = System.Drawing.Color.Black;
            this.ctrClose.Location = new System.Drawing.Point(959, 0);
            this.ctrClose.Margin = new System.Windows.Forms.Padding(0);
            this.ctrClose.Name = "ctrClose";
            this.ctrClose.Size = new System.Drawing.Size(41, 37);
            this.ctrClose.TabIndex = 7;
            this.ctrClose.Click += new System.EventHandler(this.ctrClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
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
        private Guna.UI2.WinForms.Guna2TextBox txtStudentNumber;
        private System.Windows.Forms.LinkLabel lnkForgot;
    }
}

