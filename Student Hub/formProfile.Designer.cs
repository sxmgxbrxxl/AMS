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
            this.lblProfile.Location = new System.Drawing.Point(40, 40);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(207, 47);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "PROFILE";
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.Image = global::Student_Hub.Properties.Resources.Profile_Placeholder;
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(85, 130);
            this.picProfile.Margin = new System.Windows.Forms.Padding(0);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.Size = new System.Drawing.Size(210, 210);
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
            this.lblTName.Location = new System.Drawing.Point(25, 70);
            this.lblTName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(94, 28);
            this.lblTName.TabIndex = 2;
            this.lblTName.Text = "NAME:";
            // 
            // lblTAge
            // 
            this.lblTAge.AutoSize = true;
            this.lblTAge.BackColor = System.Drawing.Color.Transparent;
            this.lblTAge.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAge.Location = new System.Drawing.Point(25, 100);
            this.lblTAge.Margin = new System.Windows.Forms.Padding(0);
            this.lblTAge.Name = "lblTAge";
            this.lblTAge.Size = new System.Drawing.Size(72, 28);
            this.lblTAge.TabIndex = 3;
            this.lblTAge.Text = "AGE:";
            // 
            // lblTProgram
            // 
            this.lblTProgram.AutoSize = true;
            this.lblTProgram.BackColor = System.Drawing.Color.Transparent;
            this.lblTProgram.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTProgram.Location = new System.Drawing.Point(22, 174);
            this.lblTProgram.Margin = new System.Windows.Forms.Padding(0);
            this.lblTProgram.Name = "lblTProgram";
            this.lblTProgram.Size = new System.Drawing.Size(146, 28);
            this.lblTProgram.TabIndex = 4;
            this.lblTProgram.Text = "PROGRAM:";
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPersonalInfo.BorderColor = System.Drawing.Color.Black;
            this.pnlPersonalInfo.BorderRadius = 20;
            this.pnlPersonalInfo.BorderThickness = 5;
            this.pnlPersonalInfo.Controls.Add(this.lblTPersonalInfo);
            this.pnlPersonalInfo.Controls.Add(this.lblTName);
            this.pnlPersonalInfo.Controls.Add(this.lblTAge);
            this.pnlPersonalInfo.FillColor = System.Drawing.Color.White;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(345, 60);
            this.pnlPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(552, 327);
            this.pnlPersonalInfo.TabIndex = 0;
            // 
            // lblTPersonalInfo
            // 
            this.lblTPersonalInfo.AutoSize = true;
            this.lblTPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTPersonalInfo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPersonalInfo.Location = new System.Drawing.Point(120, 25);
            this.lblTPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTPersonalInfo.Name = "lblTPersonalInfo";
            this.lblTPersonalInfo.Size = new System.Drawing.Size(322, 32);
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
            this.pnlEducationalBackground.Location = new System.Drawing.Point(40, 410);
            this.pnlEducationalBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEducationalBackground.Name = "pnlEducationalBackground";
            this.pnlEducationalBackground.Size = new System.Drawing.Size(860, 230);
            this.pnlEducationalBackground.TabIndex = 1;
            // 
            // lblTEducationalBackground
            // 
            this.lblTEducationalBackground.AutoSize = true;
            this.lblTEducationalBackground.BackColor = System.Drawing.Color.Transparent;
            this.lblTEducationalBackground.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEducationalBackground.Location = new System.Drawing.Point(250, 25);
            this.lblTEducationalBackground.Margin = new System.Windows.Forms.Padding(0);
            this.lblTEducationalBackground.Name = "lblTEducationalBackground";
            this.lblTEducationalBackground.Size = new System.Drawing.Size(368, 32);
            this.lblTEducationalBackground.TabIndex = 5;
            this.lblTEducationalBackground.Text = "Educational Background";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Student_Hub.Properties.Resources.Backdrop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // formProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 875);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.pnlEducationalBackground);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.pnlPersonalInfo);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}