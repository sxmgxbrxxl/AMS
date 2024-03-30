namespace Student_Hub
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.flwMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.flwStudent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlGrades = new System.Windows.Forms.Panel();
            this.btnGrades = new System.Windows.Forms.Button();
            this.pnlCalculator = new System.Windows.Forms.Panel();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.studentTransition = new System.Windows.Forms.Timer(this.components);
            this.flwMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flwStudent.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.pnlGrades.SuspendLayout();
            this.pnlCalculator.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.pnlLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwMenu
            // 
            this.flwMenu.BackColor = System.Drawing.Color.Tan;
            this.flwMenu.Controls.Add(this.pnlLogo);
            this.flwMenu.Controls.Add(this.flwStudent);
            this.flwMenu.Controls.Add(this.pnlCalculator);
            this.flwMenu.Controls.Add(this.pnlAbout);
            this.flwMenu.Controls.Add(this.pnlLogOut);
            this.flwMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwMenu.Location = new System.Drawing.Point(0, 0);
            this.flwMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flwMenu.Name = "flwMenu";
            this.flwMenu.Size = new System.Drawing.Size(350, 700);
            this.flwMenu.TabIndex = 7;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Tan;
            this.pnlLogo.Controls.Add(this.pnlBorder);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(350, 200);
            this.pnlLogo.TabIndex = 12;
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorder.BorderColor = System.Drawing.Color.Black;
            this.pnlBorder.BorderRadius = 50;
            this.pnlBorder.BorderThickness = 3;
            this.pnlBorder.Controls.Add(this.lblLogo);
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.FillColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBorder.Location = new System.Drawing.Point(25, 25);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(300, 150);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(131, 51);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(147, 56);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ACADEMIC\r\n  MASTERY";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(7, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 110);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click_1);
            // 
            // flwStudent
            // 
            this.flwStudent.BackColor = System.Drawing.Color.Tan;
            this.flwStudent.Controls.Add(this.pnlStudent);
            this.flwStudent.Controls.Add(this.pnlProfile);
            this.flwStudent.Controls.Add(this.pnlGrades);
            this.flwStudent.Location = new System.Drawing.Point(0, 200);
            this.flwStudent.Margin = new System.Windows.Forms.Padding(0);
            this.flwStudent.Name = "flwStudent";
            this.flwStudent.Size = new System.Drawing.Size(350, 90);
            this.flwStudent.TabIndex = 8;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.btnStudent);
            this.pnlStudent.Location = new System.Drawing.Point(3, 3);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(350, 80);
            this.pnlStudent.TabIndex = 9;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Tan;
            this.btnStudent.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Image = global::Student_Hub.Properties.Resources.Student;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(-5, -5);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(360, 90);
            this.btnStudent.TabIndex = 10;
            this.btnStudent.Text = "          STUDENT\r\n";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.btnProfile);
            this.pnlProfile.Location = new System.Drawing.Point(3, 89);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(350, 80);
            this.pnlProfile.TabIndex = 11;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Tan;
            this.btnProfile.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = global::Student_Hub.Properties.Resources.Profile;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-5, -5);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(360, 90);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "          PROFILE";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlGrades
            // 
            this.pnlGrades.Controls.Add(this.btnGrades);
            this.pnlGrades.Location = new System.Drawing.Point(3, 175);
            this.pnlGrades.Name = "pnlGrades";
            this.pnlGrades.Size = new System.Drawing.Size(350, 80);
            this.pnlGrades.TabIndex = 12;
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.Tan;
            this.btnGrades.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.Image = global::Student_Hub.Properties.Resources.Grades;
            this.btnGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.Location = new System.Drawing.Point(-5, -5);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(0);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnGrades.Size = new System.Drawing.Size(360, 90);
            this.btnGrades.TabIndex = 10;
            this.btnGrades.Text = "          GRADES";
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.Controls.Add(this.btnCalculator);
            this.pnlCalculator.Location = new System.Drawing.Point(0, 290);
            this.pnlCalculator.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.Size = new System.Drawing.Size(350, 80);
            this.pnlCalculator.TabIndex = 9;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Tan;
            this.btnCalculator.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Image = global::Student_Hub.Properties.Resources.Calculator;
            this.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculator.Location = new System.Drawing.Point(-5, -5);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnCalculator.Size = new System.Drawing.Size(360, 90);
            this.btnCalculator.TabIndex = 10;
            this.btnCalculator.Text = "          CALCULATOR";
            this.btnCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.btnAbout);
            this.pnlAbout.Location = new System.Drawing.Point(0, 370);
            this.pnlAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(350, 80);
            this.pnlAbout.TabIndex = 11;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Tan;
            this.btnAbout.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::Student_Hub.Properties.Resources.About;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-5, -5);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(360, 90);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "          ABOUT";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlLogOut
            // 
            this.pnlLogOut.Controls.Add(this.btnLogOut);
            this.pnlLogOut.Location = new System.Drawing.Point(0, 450);
            this.pnlLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(350, 80);
            this.pnlLogOut.TabIndex = 11;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Tan;
            this.btnLogOut.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::Student_Hub.Properties.Resources.Log_Out;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-5, -5);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(360, 90);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "          LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // studentTransition
            // 
            this.studentTransition.Interval = 10;
            this.studentTransition.Tick += new System.EventHandler(this.studentTransition_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.flwMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flwMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flwStudent.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlGrades.ResumeLayout(false);
            this.pnlCalculator.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.pnlLogOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flwMenu;
        private System.Windows.Forms.FlowLayoutPanel flwStudent;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlGrades;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Timer studentTransition;
        private System.Windows.Forms.Panel pnlCalculator;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlBorder;
    }
}