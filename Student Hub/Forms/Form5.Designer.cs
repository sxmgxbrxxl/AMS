namespace Student_Hub
{
    partial class frmReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReset));
            this.pnlWelcome = new Guna.UI2.WinForms.Guna2Panel();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtVerifyPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
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
            this.pnlWelcome.Controls.Add(this.btnChange);
            this.pnlWelcome.Controls.Add(this.lblPassword);
            this.pnlWelcome.Controls.Add(this.txtVerifyPassword);
            this.pnlWelcome.Controls.Add(this.txtNewPassword);
            this.pnlWelcome.Controls.Add(this.lblNewPassword);
            this.pnlWelcome.Controls.Add(this.lblTitle);
            this.pnlWelcome.Controls.Add(this.lblReset);
            this.pnlWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlWelcome.FillColor = System.Drawing.Color.White;
            this.pnlWelcome.Location = new System.Drawing.Point(260, 70);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(490, 470);
            this.pnlWelcome.TabIndex = 3;
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
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BorderRadius = 25;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.Tan;
            this.btnChange.FocusedColor = System.Drawing.Color.Transparent;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(180, 350);
            this.btnChange.Margin = new System.Windows.Forms.Padding(0);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 50);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.lblPassword.Size = new System.Drawing.Size(185, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "VERIFY PASSWORD:";
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.AcceptsTab = true;
            this.txtVerifyPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerifyPassword.BorderRadius = 10;
            this.txtVerifyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerifyPassword.DefaultText = "";
            this.txtVerifyPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerifyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerifyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerifyPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerifyPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtVerifyPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerifyPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerifyPassword.Location = new System.Drawing.Point(40, 250);
            this.txtVerifyPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '*';
            this.txtVerifyPassword.PlaceholderText = "";
            this.txtVerifyPassword.SelectedText = "";
            this.txtVerifyPassword.Size = new System.Drawing.Size(400, 40);
            this.txtVerifyPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AcceptsTab = true;
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(40, 170);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(400, 40);
            this.txtNewPassword.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewPassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(40, 140);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(161, 19);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "NEW PASSWORD:";
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
            // lblReset
            // 
            this.lblReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReset.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(130, 50);
            this.lblReset.Margin = new System.Windows.Forms.Padding(0);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(232, 32);
            this.lblReset.TabIndex = 0;
            this.lblReset.Text = "Reset Password";
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
            // frmReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ctrMinimize);
            this.Controls.Add(this.ctrMaximize);
            this.Controls.Add(this.ctrClose);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReset_Load);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlWelcome;
        private System.Windows.Forms.CheckBox chkShowPass;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtVerifyPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReset;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrClose;
    }
}