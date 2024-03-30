namespace Student_Hub
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.lblAbout = new System.Windows.Forms.Label();
            this.picAdvento = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picSapitanan = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlAdvento = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblATName = new System.Windows.Forms.Label();
            this.lblATAge = new System.Windows.Forms.Label();
            this.lblAAge = new System.Windows.Forms.Label();
            this.lblATAddress = new System.Windows.Forms.Label();
            this.lblAAddress = new System.Windows.Forms.Label();
            this.lblATProgram = new System.Windows.Forms.Label();
            this.lblAProgram = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSTName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSapitanan)).BeginInit();
            this.pnlAdvento.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(30, 30);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(168, 47);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "ABOUT";
            // 
            // picAdvento
            // 
            this.picAdvento.BackColor = System.Drawing.Color.Transparent;
            this.picAdvento.Image = global::Student_Hub.Properties.Resources.Advento;
            this.picAdvento.ImageRotate = 0F;
            this.picAdvento.Location = new System.Drawing.Point(40, 135);
            this.picAdvento.Margin = new System.Windows.Forms.Padding(0);
            this.picAdvento.Name = "picAdvento";
            this.picAdvento.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAdvento.Size = new System.Drawing.Size(200, 200);
            this.picAdvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvento.TabIndex = 1;
            this.picAdvento.TabStop = false;
            this.picAdvento.UseTransparentBackground = true;
            // 
            // picSapitanan
            // 
            this.picSapitanan.BackColor = System.Drawing.Color.Transparent;
            this.picSapitanan.Image = ((System.Drawing.Image)(resources.GetObject("picSapitanan.Image")));
            this.picSapitanan.ImageRotate = 0F;
            this.picSapitanan.Location = new System.Drawing.Point(40, 385);
            this.picSapitanan.Margin = new System.Windows.Forms.Padding(0);
            this.picSapitanan.Name = "picSapitanan";
            this.picSapitanan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picSapitanan.Size = new System.Drawing.Size(200, 200);
            this.picSapitanan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSapitanan.TabIndex = 2;
            this.picSapitanan.TabStop = false;
            this.picSapitanan.UseTransparentBackground = true;
            // 
            // pnlAdvento
            // 
            this.pnlAdvento.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdvento.BorderColor = System.Drawing.Color.Tan;
            this.pnlAdvento.BorderRadius = 15;
            this.pnlAdvento.BorderThickness = 10;
            this.pnlAdvento.Controls.Add(this.lblAProgram);
            this.pnlAdvento.Controls.Add(this.lblATProgram);
            this.pnlAdvento.Controls.Add(this.lblAAddress);
            this.pnlAdvento.Controls.Add(this.lblATAddress);
            this.pnlAdvento.Controls.Add(this.lblAAge);
            this.pnlAdvento.Controls.Add(this.lblATAge);
            this.pnlAdvento.Controls.Add(this.lblAName);
            this.pnlAdvento.Controls.Add(this.lblATName);
            this.pnlAdvento.FillColor = System.Drawing.Color.White;
            this.pnlAdvento.Location = new System.Drawing.Point(273, 135);
            this.pnlAdvento.Name = "pnlAdvento";
            this.pnlAdvento.Size = new System.Drawing.Size(619, 200);
            this.pnlAdvento.TabIndex = 3;
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.Location = new System.Drawing.Point(100, 40);
            this.lblAName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(212, 21);
            this.lblAName.TabIndex = 1;
            this.lblAName.Text = "Sam Gabriel Q. Advento";
            // 
            // lblATName
            // 
            this.lblATName.AutoSize = true;
            this.lblATName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATName.Location = new System.Drawing.Point(30, 40);
            this.lblATName.Name = "lblATName";
            this.lblATName.Size = new System.Drawing.Size(69, 20);
            this.lblATName.TabIndex = 0;
            this.lblATName.Text = "NAME:";
            // 
            // lblATAge
            // 
            this.lblATAge.AutoSize = true;
            this.lblATAge.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATAge.Location = new System.Drawing.Point(30, 70);
            this.lblATAge.Name = "lblATAge";
            this.lblATAge.Size = new System.Drawing.Size(52, 20);
            this.lblATAge.TabIndex = 2;
            this.lblATAge.Text = "AGE:";
            // 
            // lblAAge
            // 
            this.lblAAge.AutoSize = true;
            this.lblAAge.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAAge.Location = new System.Drawing.Point(80, 70);
            this.lblAAge.Margin = new System.Windows.Forms.Padding(0);
            this.lblAAge.Name = "lblAAge";
            this.lblAAge.Size = new System.Drawing.Size(112, 21);
            this.lblAAge.TabIndex = 3;
            this.lblAAge.Text = "20 years old";
            // 
            // lblATAddress
            // 
            this.lblATAddress.AutoSize = true;
            this.lblATAddress.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATAddress.Location = new System.Drawing.Point(30, 100);
            this.lblATAddress.Name = "lblATAddress";
            this.lblATAddress.Size = new System.Drawing.Size(100, 20);
            this.lblATAddress.TabIndex = 4;
            this.lblATAddress.Text = "ADDRESS:";
            // 
            // lblAAddress
            // 
            this.lblAAddress.AutoSize = true;
            this.lblAAddress.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAAddress.Location = new System.Drawing.Point(135, 100);
            this.lblAAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAAddress.Name = "lblAAddress";
            this.lblAAddress.Size = new System.Drawing.Size(361, 21);
            this.lblAAddress.TabIndex = 5;
            this.lblAAddress.Text = "Brgy. Santisima Cruz, Santa Cruz, Laguna";
            // 
            // lblATProgram
            // 
            this.lblATProgram.AutoSize = true;
            this.lblATProgram.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATProgram.Location = new System.Drawing.Point(30, 130);
            this.lblATProgram.Name = "lblATProgram";
            this.lblATProgram.Size = new System.Drawing.Size(108, 20);
            this.lblATProgram.TabIndex = 6;
            this.lblATProgram.Text = "PROGRAM:";
            // 
            // lblAProgram
            // 
            this.lblAProgram.AutoSize = true;
            this.lblAProgram.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAProgram.Location = new System.Drawing.Point(145, 130);
            this.lblAProgram.Margin = new System.Windows.Forms.Padding(0);
            this.lblAProgram.Name = "lblAProgram";
            this.lblAProgram.Size = new System.Drawing.Size(321, 21);
            this.lblAProgram.TabIndex = 7;
            this.lblAProgram.Text = "BS Computer Science - Data Science";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Tan;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.lblSName);
            this.guna2Panel1.Controls.Add(this.lblSTName);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(273, 385);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(619, 200);
            this.guna2Panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "BS Computer Science - Data Science";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "PROGRAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address mo ante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "ikaw na baka mamali pa ako HAHAHA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "AGE:";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(100, 40);
            this.lblSName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(370, 21);
            this.lblSName.TabIndex = 1;
            this.lblSName.Text = "Krisha Gyle (di ko tanda middle) Sapitanan";
            // 
            // lblSTName
            // 
            this.lblSTName.AutoSize = true;
            this.lblSTName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTName.Location = new System.Drawing.Point(30, 40);
            this.lblSTName.Name = "lblSTName";
            this.lblSTName.Size = new System.Drawing.Size(69, 20);
            this.lblSTName.TabIndex = 0;
            this.lblSTName.Text = "NAME:";
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(945, 695);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlAdvento);
            this.Controls.Add(this.picSapitanan);
            this.Controls.Add(this.picAdvento);
            this.Controls.Add(this.lblAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAbout";
            ((System.ComponentModel.ISupportInitialize)(this.picAdvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSapitanan)).EndInit();
            this.pnlAdvento.ResumeLayout(false);
            this.pnlAdvento.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAdvento;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picSapitanan;
        private Guna.UI2.WinForms.Guna2Panel pnlAdvento;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label lblATName;
        private System.Windows.Forms.Label lblATProgram;
        private System.Windows.Forms.Label lblAAddress;
        private System.Windows.Forms.Label lblATAddress;
        private System.Windows.Forms.Label lblAAge;
        private System.Windows.Forms.Label lblATAge;
        private System.Windows.Forms.Label lblAProgram;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSTName;
    }
}