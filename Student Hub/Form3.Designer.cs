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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.flwStudent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrades = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.studentTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.form3Transition = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.form3Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.flwMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flwStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwMenu
            // 
            this.flwMenu.BackColor = System.Drawing.Color.Tan;
            this.flwMenu.Controls.Add(this.pnlLogo);
            this.flwMenu.Controls.Add(this.btnHome);
            this.flwMenu.Controls.Add(this.flwStudent);
            this.flwMenu.Controls.Add(this.btnRecords);
            this.flwMenu.Controls.Add(this.btnAbout);
            this.flwMenu.Controls.Add(this.btnLogOut);
            this.flwMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwMenu.Location = new System.Drawing.Point(0, 0);
            this.flwMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flwMenu.Name = "flwMenu";
            this.flwMenu.Size = new System.Drawing.Size(225, 788);
            this.flwMenu.TabIndex = 7;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(225, 195);
            this.pnlLogo.TabIndex = 9;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Image = global::Student_Hub.Properties.Resources.Academic_Mastery;
            this.picLogo.Location = new System.Drawing.Point(15, 24);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(191, 154);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Tan;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::Student_Hub.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.Location = new System.Drawing.Point(0, 195);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnHome.PressedColor = System.Drawing.Color.PapayaWhip;
            this.btnHome.Size = new System.Drawing.Size(225, 65);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 3);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // flwStudent
            // 
            this.flwStudent.BackColor = System.Drawing.Color.Tan;
            this.flwStudent.Controls.Add(this.btnStudent);
            this.flwStudent.Controls.Add(this.btnProfile);
            this.flwStudent.Controls.Add(this.btnGrades);
            this.flwStudent.Location = new System.Drawing.Point(0, 260);
            this.flwStudent.Margin = new System.Windows.Forms.Padding(0);
            this.flwStudent.Name = "flwStudent";
            this.flwStudent.Size = new System.Drawing.Size(225, 65);
            this.flwStudent.TabIndex = 8;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStudent.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnStudent.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudent.FillColor = System.Drawing.Color.Tan;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Black;
            this.btnStudent.Image = global::Student_Hub.Properties.Resources.Student;
            this.btnStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnStudent.PressedColor = System.Drawing.Color.PapayaWhip;
            this.btnStudent.Size = new System.Drawing.Size(225, 65);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.TextOffset = new System.Drawing.Point(20, 3);
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnProfile.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.Tan;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Image = global::Student_Hub.Properties.Resources.Profile;
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.ImageOffset = new System.Drawing.Point(55, 0);
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(0, 65);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnProfile.PressedColor = System.Drawing.Color.Transparent;
            this.btnProfile.Size = new System.Drawing.Size(225, 65);
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.TextOffset = new System.Drawing.Point(20, 3);
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.Transparent;
            this.btnGrades.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGrades.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnGrades.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrades.FillColor = System.Drawing.Color.Tan;
            this.btnGrades.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.ForeColor = System.Drawing.Color.Black;
            this.btnGrades.Image = global::Student_Hub.Properties.Resources.Grades;
            this.btnGrades.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGrades.ImageOffset = new System.Drawing.Point(55, 0);
            this.btnGrades.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGrades.Location = new System.Drawing.Point(0, 130);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(0);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnGrades.PressedColor = System.Drawing.Color.Transparent;
            this.btnGrades.Size = new System.Drawing.Size(225, 65);
            this.btnGrades.TabIndex = 19;
            this.btnGrades.Text = "Grades";
            this.btnGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGrades.TextOffset = new System.Drawing.Point(20, 3);
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnRecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRecords.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnRecords.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecords.FillColor = System.Drawing.Color.Tan;
            this.btnRecords.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.Black;
            this.btnRecords.Image = global::Student_Hub.Properties.Resources.Records;
            this.btnRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecords.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnRecords.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRecords.Location = new System.Drawing.Point(0, 325);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnRecords.PressedColor = System.Drawing.Color.PapayaWhip;
            this.btnRecords.Size = new System.Drawing.Size(225, 65);
            this.btnRecords.TabIndex = 15;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecords.TextOffset = new System.Drawing.Point(20, 3);
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAbout.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAbout.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.Tan;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Image = global::Student_Hub.Properties.Resources.About;
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnAbout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAbout.Location = new System.Drawing.Point(0, 390);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnAbout.PressedColor = System.Drawing.Color.PapayaWhip;
            this.btnAbout.Size = new System.Drawing.Size(225, 65);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.TextOffset = new System.Drawing.Point(20, 3);
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.CheckedState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Tan;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::Student_Hub.Properties.Resources.Log_Out;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(35, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOut.Location = new System.Drawing.Point(0, 455);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnLogOut.PressedColor = System.Drawing.Color.PapayaWhip;
            this.btnLogOut.Size = new System.Drawing.Size(225, 65);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.TextOffset = new System.Drawing.Point(20, 3);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // studentTransition
            // 
            this.studentTransition.Interval = 10;
            this.studentTransition.Tick += new System.EventHandler(this.studentTransition_Tick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Tan;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(225, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1161, 50);
            this.pnlHeader.TabIndex = 10;
            // 
            // form3Transition
            // 
            this.form3Transition.AnimateWindow = true;
            this.form3Transition.BorderRadius = 10;
            this.form3Transition.ContainerControl = this;
            this.form3Transition.DockIndicatorTransparencyValue = 0.6D;
            this.form3Transition.TransparentWhileDrag = true;
            // 
            // form3Drag
            // 
            this.form3Drag.DockIndicatorTransparencyValue = 0.6D;
            this.form3Drag.TargetControl = this.pnlHeader;
            this.form3Drag.UseTransparentDrag = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.flwMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.flwMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flwStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flwMenu;
        private System.Windows.Forms.FlowLayoutPanel flwStudent;
        private System.Windows.Forms.Timer studentTransition;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnStudent;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnGrades;
        private Guna.UI2.WinForms.Guna2Button btnRecords;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2BorderlessForm form3Transition;
        private Guna.UI2.WinForms.Guna2DragControl form3Drag;
    }
}