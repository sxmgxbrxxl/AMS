namespace Student_Hub
{
    partial class formRecords
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
            this.lblNavigation = new System.Windows.Forms.Label();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblTrueNavigation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.BackColor = System.Drawing.Color.Transparent;
            this.lblNavigation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.ForeColor = System.Drawing.Color.DimGray;
            this.lblNavigation.Location = new System.Drawing.Point(25, 20);
            this.lblNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(72, 19);
            this.lblNavigation.TabIndex = 2;
            this.lblNavigation.Text = "Home /";
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.Transparent;
            this.lblGreetings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(25, 50);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(134, 37);
            this.lblGreetings.TabIndex = 4;
            this.lblGreetings.Text = "Records";
            // 
            // lblTrueNavigation
            // 
            this.lblTrueNavigation.AutoSize = true;
            this.lblTrueNavigation.BackColor = System.Drawing.Color.Transparent;
            this.lblTrueNavigation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueNavigation.ForeColor = System.Drawing.Color.Black;
            this.lblTrueNavigation.Location = new System.Drawing.Point(103, 20);
            this.lblTrueNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrueNavigation.Name = "lblTrueNavigation";
            this.lblTrueNavigation.Size = new System.Drawing.Size(76, 19);
            this.lblTrueNavigation.TabIndex = 5;
            this.lblTrueNavigation.Text = "Records";
            // 
            // formRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Dashboard;
            this.ClientSize = new System.Drawing.Size(1095, 745);
            this.Controls.Add(this.lblTrueNavigation);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.lblNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRecords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblTrueNavigation;
    }
}