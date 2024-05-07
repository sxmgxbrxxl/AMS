namespace Student_Hub
{
    partial class UCRecords
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
            this.cboSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTrueNavigation = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.pnlRecords = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblPrelim = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCategory.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.BorderColor = System.Drawing.Color.Black;
            this.pnlCategory.BorderRadius = 10;
            this.pnlCategory.Controls.Add(this.cboSemester);
            this.pnlCategory.Controls.Add(this.lblSemester);
            this.pnlCategory.Controls.Add(this.lblYear);
            this.pnlCategory.Controls.Add(this.cboYear);
            this.pnlCategory.FillColor = System.Drawing.Color.White;
            this.pnlCategory.Location = new System.Drawing.Point(30, 130);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.ShadowDecoration.BorderRadius = 15;
            this.pnlCategory.ShadowDecoration.Depth = 15;
            this.pnlCategory.ShadowDecoration.Enabled = true;
            this.pnlCategory.Size = new System.Drawing.Size(350, 250);
            this.pnlCategory.TabIndex = 22;
            // 
            // cboSemester
            // 
            this.cboSemester.BackColor = System.Drawing.Color.Transparent;
            this.cboSemester.BorderRadius = 17;
            this.cboSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSemester.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSemester.ItemHeight = 30;
            this.cboSemester.Location = new System.Drawing.Point(20, 140);
            this.cboSemester.Margin = new System.Windows.Forms.Padding(0);
            this.cboSemester.MaxDropDownItems = 4;
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(310, 36);
            this.cboSemester.TabIndex = 5;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.Transparent;
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(20, 110);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(100, 22);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "SEMESTER:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(20, 30);
            this.lblYear.Margin = new System.Windows.Forms.Padding(0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(63, 22);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "YEAR:";
            // 
            // cboYear
            // 
            this.cboYear.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cboYear.TabIndex = 0;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(20, 50);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(213, 56);
            this.lblRecords.TabIndex = 21;
            this.lblRecords.Text = "Records";
            // 
            // lblTrueNavigation
            // 
            this.lblTrueNavigation.AutoSize = true;
            this.lblTrueNavigation.BackColor = System.Drawing.Color.Transparent;
            this.lblTrueNavigation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueNavigation.ForeColor = System.Drawing.Color.Black;
            this.lblTrueNavigation.Location = new System.Drawing.Point(105, 20);
            this.lblTrueNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrueNavigation.Name = "lblTrueNavigation";
            this.lblTrueNavigation.Size = new System.Drawing.Size(84, 23);
            this.lblTrueNavigation.TabIndex = 20;
            this.lblTrueNavigation.Text = "Records";
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
            this.lblNavigation.Size = new System.Drawing.Size(79, 23);
            this.lblNavigation.TabIndex = 19;
            this.lblNavigation.Text = "Home /";
            // 
            // pnlRecords
            // 
            this.pnlRecords.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecords.BorderColor = System.Drawing.Color.Black;
            this.pnlRecords.BorderRadius = 10;
            this.pnlRecords.Controls.Add(this.lblFinal);
            this.pnlRecords.Controls.Add(this.lblMidterm);
            this.pnlRecords.Controls.Add(this.lblPrelim);
            this.pnlRecords.FillColor = System.Drawing.Color.White;
            this.pnlRecords.Location = new System.Drawing.Point(400, 130);
            this.pnlRecords.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.ShadowDecoration.BorderRadius = 15;
            this.pnlRecords.ShadowDecoration.Depth = 15;
            this.pnlRecords.ShadowDecoration.Enabled = true;
            this.pnlRecords.Size = new System.Drawing.Size(840, 614);
            this.pnlRecords.TabIndex = 23;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(650, 50);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(87, 32);
            this.lblFinal.TabIndex = 6;
            this.lblFinal.Text = "FINAL";
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.BackColor = System.Drawing.Color.Transparent;
            this.lblMidterm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(340, 50);
            this.lblMidterm.Margin = new System.Windows.Forms.Padding(0);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(130, 32);
            this.lblMidterm.TabIndex = 5;
            this.lblMidterm.Text = "MIDTERM";
            // 
            // lblPrelim
            // 
            this.lblPrelim.AutoSize = true;
            this.lblPrelim.BackColor = System.Drawing.Color.Transparent;
            this.lblPrelim.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrelim.Location = new System.Drawing.Point(50, 50);
            this.lblPrelim.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrelim.Name = "lblPrelim";
            this.lblPrelim.Size = new System.Drawing.Size(103, 32);
            this.lblPrelim.TabIndex = 4;
            this.lblPrelim.Text = "PRELIM";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 25;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Tan;
            this.btnPrint.FocusedColor = System.Drawing.Color.Transparent;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1090, 770);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 50);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            // 
            // UCRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Dashboard;
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTrueNavigation);
            this.Controls.Add(this.lblNavigation);
            this.Controls.Add(this.pnlRecords);
            this.Controls.Add(this.btnPrint);
            this.Name = "UCRecords";
            this.Size = new System.Drawing.Size(1275, 850);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cboSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblYear;
        private Guna.UI2.WinForms.Guna2ComboBox cboYear;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblTrueNavigation;
        private System.Windows.Forms.Label lblNavigation;
        private Guna.UI2.WinForms.Guna2Panel pnlRecords;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblPrelim;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}
