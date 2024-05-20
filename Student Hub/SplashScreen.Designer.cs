namespace Student_Hub
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.picLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cpbLogo = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SplashScreenDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.cpbLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.FillColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Student_Hub.Properties.Resources.New_Logo;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(10, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLogo.Size = new System.Drawing.Size(279, 281);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.UseTransparentBackground = true;
            // 
            // cpbLogo
            // 
            this.cpbLogo.BackColor = System.Drawing.Color.Transparent;
            this.cpbLogo.Controls.Add(this.picLogo);
            this.cpbLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cpbLogo.FillThickness = 10;
            this.cpbLogo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbLogo.ForeColor = System.Drawing.Color.White;
            this.cpbLogo.Location = new System.Drawing.Point(200, 50);
            this.cpbLogo.Minimum = 0;
            this.cpbLogo.Name = "cpbLogo";
            this.cpbLogo.ProgressColor = System.Drawing.Color.SandyBrown;
            this.cpbLogo.ProgressColor2 = System.Drawing.Color.Peru;
            this.cpbLogo.ShadowDecoration.Enabled = true;
            this.cpbLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbLogo.Size = new System.Drawing.Size(300, 300);
            this.cpbLogo.TabIndex = 1;
            this.cpbLogo.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreenDesign
            // 
            this.SplashScreenDesign.AnimateWindow = true;
            this.SplashScreenDesign.BorderRadius = 25;
            this.SplashScreenDesign.ContainerControl = this;
            this.SplashScreenDesign.DockIndicatorTransparencyValue = 0.6D;
            this.SplashScreenDesign.TransparentWhileDrag = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.SplashScreenBG;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.cpbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.cpbLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picLogo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbLogo;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2BorderlessForm SplashScreenDesign;
    }
}