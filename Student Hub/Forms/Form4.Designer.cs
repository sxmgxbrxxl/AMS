namespace Student_Hub
{
    partial class frmForgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgot));
            this.pnlWelcome = new Guna.UI2.WinForms.Guna2Panel();
            this.lnkSendCode = new System.Windows.Forms.LinkLabel();
            this.lnkLogIn = new System.Windows.Forms.LinkLabel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
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
            this.pnlWelcome.Controls.Add(this.lnkSendCode);
            this.pnlWelcome.Controls.Add(this.lnkLogIn);
            this.pnlWelcome.Controls.Add(this.lblQuestion);
            this.pnlWelcome.Controls.Add(this.btnVerify);
            this.pnlWelcome.Controls.Add(this.lblCode);
            this.pnlWelcome.Controls.Add(this.txtCode);
            this.pnlWelcome.Controls.Add(this.txtEmail);
            this.pnlWelcome.Controls.Add(this.lblEmail);
            this.pnlWelcome.Controls.Add(this.lblTip);
            this.pnlWelcome.Controls.Add(this.lblForgotPassword);
            this.pnlWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlWelcome.FillColor = System.Drawing.Color.White;
            this.pnlWelcome.Location = new System.Drawing.Point(260, 70);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(490, 470);
            this.pnlWelcome.TabIndex = 3;
            // 
            // lnkSendCode
            // 
            this.lnkSendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkSendCode.AutoSize = true;
            this.lnkSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSendCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSendCode.Location = new System.Drawing.Point(360, 240);
            this.lnkSendCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkSendCode.Name = "lnkSendCode";
            this.lnkSendCode.Size = new System.Drawing.Size(80, 17);
            this.lnkSendCode.TabIndex = 5;
            this.lnkSendCode.TabStop = true;
            this.lnkSendCode.Text = "Send Code";
            this.lnkSendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSendCode_LinkClicked);
            // 
            // lnkLogIn
            // 
            this.lnkLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLogIn.AutoSize = true;
            this.lnkLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLogIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogIn.Location = new System.Drawing.Point(240, 420);
            this.lnkLogIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLogIn.Name = "lnkLogIn";
            this.lnkLogIn.Size = new System.Drawing.Size(47, 17);
            this.lnkLogIn.TabIndex = 4;
            this.lnkLogIn.TabStop = true;
            this.lnkLogIn.Text = "Log In";
            this.lnkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogIn_LinkClicked);
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
            this.lblQuestion.Size = new System.Drawing.Size(201, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "You remember your account?";
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerify.BorderRadius = 25;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerify.FillColor = System.Drawing.Color.Tan;
            this.btnVerify.FocusedColor = System.Drawing.Color.Transparent;
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(177, 343);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(120, 50);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCode.AutoSize = true;
            this.lblCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCode.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(40, 238);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(58, 19);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "CODE";
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.BorderRadius = 10;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Location = new System.Drawing.Point(40, 268);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(400, 40);
            this.txtCode.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "someone@gmail.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(400, 40);
            this.txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblTip
            // 
            this.lblTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTip.AutoSize = true;
            this.lblTip.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTip.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(126, 90);
            this.lblTip.Margin = new System.Windows.Forms.Padding(0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(231, 21);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Enter your linked email";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblForgotPassword.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.Location = new System.Drawing.Point(115, 50);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(263, 32);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "Forgot Password?";
            // 
            // ctrMinimize
            // 
            this.ctrMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ctrMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ctrMinimize.IconColor = System.Drawing.Color.Black;
            this.ctrMinimize.Location = new System.Drawing.Point(877, -1);
            this.ctrMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMinimize.Name = "ctrMinimize";
            this.ctrMinimize.Size = new System.Drawing.Size(41, 37);
            this.ctrMinimize.TabIndex = 12;
            // 
            // ctrMaximize
            // 
            this.ctrMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ctrMaximize.IconColor = System.Drawing.Color.Black;
            this.ctrMaximize.Location = new System.Drawing.Point(919, -1);
            this.ctrMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ctrMaximize.Name = "ctrMaximize";
            this.ctrMaximize.Size = new System.Drawing.Size(41, 37);
            this.ctrMaximize.TabIndex = 11;
            // 
            // ctrClose
            // 
            this.ctrClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrClose.BackColor = System.Drawing.Color.Transparent;
            this.ctrClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrClose.IconColor = System.Drawing.Color.Black;
            this.ctrClose.Location = new System.Drawing.Point(960, -1);
            this.ctrClose.Margin = new System.Windows.Forms.Padding(0);
            this.ctrClose.Name = "ctrClose";
            this.ctrClose.Size = new System.Drawing.Size(41, 37);
            this.ctrClose.TabIndex = 10;
            this.ctrClose.Click += new System.EventHandler(this.ctrClose_Click);
            // 
            // frmForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ctrMinimize);
            this.Controls.Add(this.ctrMaximize);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.ctrClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmForgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmForgot_Load);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlWelcome;
        private System.Windows.Forms.LinkLabel lnkLogIn;
        private System.Windows.Forms.Label lblQuestion;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.LinkLabel lnkSendCode;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrClose;
    }
}