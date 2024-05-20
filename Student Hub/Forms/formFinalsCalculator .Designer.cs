namespace Student_Hub
{
    partial class formFinalsCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFinalsCalculator));
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.txtScore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPercentScore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalRecit = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCompute = new Guna.UI2.WinForms.Guna2Button();
            this.txtOverScore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalExam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPercentMidterm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPreviousGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveFin = new Guna.UI2.WinForms.Guna2Button();
            this.pnlScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.pnlCalculator = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lblGrades = new System.Windows.Forms.Label();
            this.btnOverScore = new System.Windows.Forms.Button();
            this.lblClassStanding = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.formCalculatorTransition = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripTerms = new System.Windows.Forms.ToolStripMenuItem();
            this.pRELIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINALSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInstructions = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCLose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlScreen.SuspendLayout();
            this.pnlCalculator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.BackColor = System.Drawing.Color.Tan;
            this.btnSaveScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.Location = new System.Drawing.Point(380, 323);
            this.btnSaveScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(112, 31);
            this.btnSaveScore.TabIndex = 16;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = false;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveRecit_Click);
            // 
            // txtScore
            // 
            this.txtScore.AcceptsReturn = true;
            this.txtScore.AcceptsTab = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.BorderRadius = 10;
            this.txtScore.BorderThickness = 2;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore.DefaultText = "";
            this.txtScore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScore.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScore.Location = new System.Drawing.Point(636, 252);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScore.Name = "txtScore";
            this.txtScore.PasswordChar = '\0';
            this.txtScore.PlaceholderText = "";
            this.txtScore.ReadOnly = true;
            this.txtScore.SelectedText = "";
            this.txtScore.Size = new System.Drawing.Size(60, 60);
            this.txtScore.TabIndex = 18;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPercentScore
            // 
            this.txtPercentScore.AcceptsReturn = true;
            this.txtPercentScore.AcceptsTab = true;
            this.txtPercentScore.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentScore.BorderRadius = 10;
            this.txtPercentScore.BorderThickness = 2;
            this.txtPercentScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercentScore.DefaultText = "70%";
            this.txtPercentScore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPercentScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPercentScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentScore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentScore.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPercentScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentScore.Location = new System.Drawing.Point(849, 252);
            this.txtPercentScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPercentScore.Name = "txtPercentScore";
            this.txtPercentScore.PasswordChar = '\0';
            this.txtPercentScore.PlaceholderText = "";
            this.txtPercentScore.SelectedText = "";
            this.txtPercentScore.Size = new System.Drawing.Size(60, 60);
            this.txtPercentScore.TabIndex = 27;
            this.txtPercentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalRecit
            // 
            this.txtTotalRecit.AcceptsReturn = true;
            this.txtTotalRecit.AcceptsTab = true;
            this.txtTotalRecit.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalRecit.BorderRadius = 10;
            this.txtTotalRecit.BorderThickness = 2;
            this.txtTotalRecit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRecit.DefaultText = "";
            this.txtTotalRecit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalRecit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalRecit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRecit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRecit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalRecit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRecit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRecit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRecit.Location = new System.Drawing.Point(959, 252);
            this.txtTotalRecit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalRecit.Name = "txtTotalRecit";
            this.txtTotalRecit.PasswordChar = '\0';
            this.txtTotalRecit.PlaceholderText = "";
            this.txtTotalRecit.ReadOnly = true;
            this.txtTotalRecit.SelectedText = "";
            this.txtTotalRecit.Size = new System.Drawing.Size(80, 60);
            this.txtTotalRecit.TabIndex = 30;
            this.txtTotalRecit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Transparent;
            this.btnCompute.BorderColor = System.Drawing.Color.Transparent;
            this.btnCompute.BorderRadius = 20;
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompute.FillColor = System.Drawing.Color.Tan;
            this.btnCompute.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(759, 568);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(150, 37);
            this.btnCompute.TabIndex = 43;
            this.btnCompute.Text = "Compute";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtOverScore
            // 
            this.txtOverScore.AcceptsReturn = true;
            this.txtOverScore.AcceptsTab = true;
            this.txtOverScore.BackColor = System.Drawing.Color.Transparent;
            this.txtOverScore.BorderRadius = 10;
            this.txtOverScore.BorderThickness = 2;
            this.txtOverScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOverScore.DefaultText = "";
            this.txtOverScore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOverScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOverScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOverScore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOverScore.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtOverScore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOverScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOverScore.Location = new System.Drawing.Point(738, 252);
            this.txtOverScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOverScore.Name = "txtOverScore";
            this.txtOverScore.PasswordChar = '\0';
            this.txtOverScore.PlaceholderText = "";
            this.txtOverScore.SelectedText = "";
            this.txtOverScore.Size = new System.Drawing.Size(60, 60);
            this.txtOverScore.TabIndex = 45;
            this.txtOverScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalExam
            // 
            this.txtTotalExam.AcceptsReturn = true;
            this.txtTotalExam.AcceptsTab = true;
            this.txtTotalExam.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalExam.BorderRadius = 10;
            this.txtTotalExam.BorderThickness = 2;
            this.txtTotalExam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalExam.DefaultText = "";
            this.txtTotalExam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExam.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalExam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExam.Location = new System.Drawing.Point(959, 380);
            this.txtTotalExam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalExam.Name = "txtTotalExam";
            this.txtTotalExam.PasswordChar = '\0';
            this.txtTotalExam.PlaceholderText = "";
            this.txtTotalExam.ReadOnly = true;
            this.txtTotalExam.SelectedText = "";
            this.txtTotalExam.Size = new System.Drawing.Size(80, 60);
            this.txtTotalExam.TabIndex = 46;
            this.txtTotalExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPercentMidterm
            // 
            this.txtPercentMidterm.AcceptsReturn = true;
            this.txtPercentMidterm.AcceptsTab = true;
            this.txtPercentMidterm.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentMidterm.BorderRadius = 10;
            this.txtPercentMidterm.BorderThickness = 2;
            this.txtPercentMidterm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercentMidterm.DefaultText = "30%";
            this.txtPercentMidterm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPercentMidterm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPercentMidterm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentMidterm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentMidterm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPercentMidterm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentMidterm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentMidterm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentMidterm.Location = new System.Drawing.Point(849, 380);
            this.txtPercentMidterm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPercentMidterm.Name = "txtPercentMidterm";
            this.txtPercentMidterm.PasswordChar = '\0';
            this.txtPercentMidterm.PlaceholderText = "";
            this.txtPercentMidterm.SelectedText = "";
            this.txtPercentMidterm.Size = new System.Drawing.Size(60, 60);
            this.txtPercentMidterm.TabIndex = 51;
            this.txtPercentMidterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreviousGrade
            // 
            this.txtPreviousGrade.AcceptsReturn = true;
            this.txtPreviousGrade.AcceptsTab = true;
            this.txtPreviousGrade.BackColor = System.Drawing.Color.Transparent;
            this.txtPreviousGrade.BorderRadius = 10;
            this.txtPreviousGrade.BorderThickness = 2;
            this.txtPreviousGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreviousGrade.DefaultText = "";
            this.txtPreviousGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreviousGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreviousGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreviousGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreviousGrade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPreviousGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreviousGrade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreviousGrade.Location = new System.Drawing.Point(738, 380);
            this.txtPreviousGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreviousGrade.Name = "txtPreviousGrade";
            this.txtPreviousGrade.PasswordChar = '\0';
            this.txtPreviousGrade.PlaceholderText = "";
            this.txtPreviousGrade.SelectedText = "";
            this.txtPreviousGrade.Size = new System.Drawing.Size(60, 60);
            this.txtPreviousGrade.TabIndex = 50;
            this.txtPreviousGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade
            // 
            this.txtGrade.AcceptsReturn = true;
            this.txtGrade.AcceptsTab = true;
            this.txtGrade.BackColor = System.Drawing.Color.Transparent;
            this.txtGrade.BorderRadius = 10;
            this.txtGrade.BorderThickness = 2;
            this.txtGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrade.DefaultText = "";
            this.txtGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.Location = new System.Drawing.Point(917, 563);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PasswordChar = '\0';
            this.txtGrade.PlaceholderText = "";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.SelectedText = "";
            this.txtGrade.Size = new System.Drawing.Size(122, 83);
            this.txtGrade.TabIndex = 47;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // btnSaveFin
            // 
            this.btnSaveFin.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFin.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSaveFin.BorderRadius = 10;
            this.btnSaveFin.BorderThickness = 2;
            this.btnSaveFin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveFin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveFin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveFin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveFin.FillColor = System.Drawing.Color.Tan;
            this.btnSaveFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFin.ForeColor = System.Drawing.Color.White;
            this.btnSaveFin.Location = new System.Drawing.Point(738, 610);
            this.btnSaveFin.Name = "btnSaveFin";
            this.btnSaveFin.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveFin.Size = new System.Drawing.Size(171, 44);
            this.btnSaveFin.TabIndex = 55;
            this.btnSaveFin.Text = "Save Grade";
            this.btnSaveFin.DoubleClick += new System.EventHandler(this.btnSaveFin_Click);
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.BorderColor = System.Drawing.Color.White;
            this.pnlScreen.BorderRadius = 20;
            this.pnlScreen.BorderThickness = 10;
            this.pnlScreen.Controls.Add(this.txtPreview);
            this.pnlScreen.Controls.Add(this.lblPreview);
            this.pnlScreen.Controls.Add(this.txtResult);
            this.pnlScreen.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlScreen.Location = new System.Drawing.Point(19, 20);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(279, 96);
            this.pnlScreen.TabIndex = 0;
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(22, 18);
            this.txtPreview.Margin = new System.Windows.Forms.Padding(0);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(239, 19);
            this.txtPreview.TabIndex = 1;
            this.txtPreview.TabStop = false;
            this.txtPreview.Text = "Preview";
            this.txtPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPreview.Location = new System.Drawing.Point(22, 28);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(0, 19);
            this.lblPreview.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Century Gothic", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(22, 37);
            this.txtResult.Margin = new System.Windows.Forms.Padding(0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(239, 41);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.LightGray;
            this.btnTwo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(90, 342);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(68, 65);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.LightGray;
            this.btnThree.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(162, 342);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(68, 65);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.LightGray;
            this.btnFour.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(19, 272);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(68, 65);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.LightGray;
            this.btnFive.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(90, 272);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(68, 65);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.LightGray;
            this.btnSix.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(162, 272);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(68, 65);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.LightGray;
            this.btnZero.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(19, 412);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(211, 65);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tan;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(19, 126);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 65);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.LightGray;
            this.btnSeven.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(19, 201);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(68, 65);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tan;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Student_Hub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(162, 126);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 65);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.LightGray;
            this.btnEight.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(90, 201);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(68, 65);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.LightGray;
            this.btnOne.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(19, 342);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(68, 65);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.LightGray;
            this.btnNine.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(162, 201);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(68, 65);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.BackColor = System.Drawing.Color.Transparent;
            this.pnlCalculator.BorderRadius = 25;
            this.pnlCalculator.Controls.Add(this.btnDivide);
            this.pnlCalculator.Controls.Add(this.btnMinus);
            this.pnlCalculator.Controls.Add(this.btnAdd);
            this.pnlCalculator.Controls.Add(this.btnEquals);
            this.pnlCalculator.Controls.Add(this.btnMultiply);
            this.pnlCalculator.Controls.Add(this.pnlScreen);
            this.pnlCalculator.Controls.Add(this.btnNine);
            this.pnlCalculator.Controls.Add(this.btnTwo);
            this.pnlCalculator.Controls.Add(this.btnThree);
            this.pnlCalculator.Controls.Add(this.btnOne);
            this.pnlCalculator.Controls.Add(this.btnFour);
            this.pnlCalculator.Controls.Add(this.btnFive);
            this.pnlCalculator.Controls.Add(this.btnEight);
            this.pnlCalculator.Controls.Add(this.btnSix);
            this.pnlCalculator.Controls.Add(this.btnZero);
            this.pnlCalculator.Controls.Add(this.btnDelete);
            this.pnlCalculator.Controls.Add(this.btnClear);
            this.pnlCalculator.Controls.Add(this.btnSeven);
            this.pnlCalculator.FillColor = System.Drawing.Color.Black;
            this.pnlCalculator.Location = new System.Drawing.Point(53, 177);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.Size = new System.Drawing.Size(324, 508);
            this.pnlCalculator.TabIndex = 56;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Tan;
            this.btnDivide.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(230, 413);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(68, 65);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Tan;
            this.btnMinus.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(230, 272);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(68, 65);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "−";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tan;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(230, 201);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 65);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Tan;
            this.btnEquals.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(230, 126);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(68, 65);
            this.btnEquals.TabIndex = 16;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Tan;
            this.btnMultiply.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(230, 343);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(68, 65);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.BackColor = System.Drawing.Color.Transparent;
            this.lblGrades.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(43, 93);
            this.lblGrades.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(269, 56);
            this.lblGrades.TabIndex = 57;
            this.lblGrades.Text = "Calculator";
            // 
            // btnOverScore
            // 
            this.btnOverScore.BackColor = System.Drawing.Color.Tan;
            this.btnOverScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverScore.Location = new System.Drawing.Point(380, 354);
            this.btnOverScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnOverScore.Name = "btnOverScore";
            this.btnOverScore.Size = new System.Drawing.Size(112, 47);
            this.btnOverScore.TabIndex = 58;
            this.btnOverScore.Text = "Overall Points";
            this.btnOverScore.UseVisualStyleBackColor = false;
            this.btnOverScore.Click += new System.EventHandler(this.btnOverRecit_Click);
            // 
            // lblClassStanding
            // 
            this.lblClassStanding.AutoSize = true;
            this.lblClassStanding.BackColor = System.Drawing.Color.Transparent;
            this.lblClassStanding.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassStanding.Location = new System.Drawing.Point(631, 145);
            this.lblClassStanding.Margin = new System.Windows.Forms.Padding(0);
            this.lblClassStanding.Name = "lblClassStanding";
            this.lblClassStanding.Size = new System.Drawing.Size(268, 28);
            this.lblClassStanding.TabIndex = 64;
            this.lblClassStanding.Text = "FINALS Class Standing";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.BackColor = System.Drawing.Color.Transparent;
            this.lblExam.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(631, 325);
            this.lblExam.Margin = new System.Windows.Forms.Padding(0);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(250, 28);
            this.lblExam.TabIndex = 70;
            this.lblExam.Text = "Your Midterm Grade";
            // 
            // formCalculatorTransition
            // 
            this.formCalculatorTransition.AnimateWindow = true;
            this.formCalculatorTransition.BorderRadius = 50;
            this.formCalculatorTransition.ContainerControl = this;
            this.formCalculatorTransition.DockIndicatorTransparencyValue = 0.6D;
            this.formCalculatorTransition.TransparentWhileDrag = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripTerms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 31);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripTerms
            // 
            this.MenuStripTerms.BackColor = System.Drawing.Color.Tan;
            this.MenuStripTerms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRELIMToolStripMenuItem,
            this.fINALSToolStripMenuItem});
            this.MenuStripTerms.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripTerms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuStripTerms.Name = "MenuStripTerms";
            this.MenuStripTerms.Size = new System.Drawing.Size(82, 27);
            this.MenuStripTerms.Text = "FINALS";
            this.MenuStripTerms.ToolTipText = "Click for the other terms";
            this.MenuStripTerms.Click += new System.EventHandler(this.termsToolStripMenuItem_Click);
            // 
            // pRELIMToolStripMenuItem
            // 
            this.pRELIMToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.pRELIMToolStripMenuItem.Name = "pRELIMToolStripMenuItem";
            this.pRELIMToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.pRELIMToolStripMenuItem.Text = "PRELIM";
            this.pRELIMToolStripMenuItem.Click += new System.EventHandler(this.pRELIMToolStripMenuItem_Click);
            // 
            // fINALSToolStripMenuItem
            // 
            this.fINALSToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.fINALSToolStripMenuItem.Name = "fINALSToolStripMenuItem";
            this.fINALSToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.fINALSToolStripMenuItem.Text = "MIDTERM";
            this.fINALSToolStripMenuItem.Click += new System.EventHandler(this.fINALSToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(727, 186);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 73;
            this.guna2HtmlLabel1.Text = null;
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = false;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(636, 175);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(412, 70);
            this.lblInstructions.TabIndex = 74;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnCLose.BorderRadius = 10;
            this.btnCLose.BorderThickness = 2;
            this.btnCLose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCLose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCLose.FillColor = System.Drawing.Color.White;
            this.btnCLose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Image = global::Student_Hub.Properties.Resources.Back;
            this.btnCLose.Location = new System.Drawing.Point(1011, 93);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(37, 42);
            this.btnCLose.TabIndex = 76;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // formFinalsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Student_Hub.Properties.Resources.New_Calculator_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.lblClassStanding);
            this.Controls.Add(this.btnOverScore);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.pnlCalculator);
            this.Controls.Add(this.btnSaveFin);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtPercentMidterm);
            this.Controls.Add(this.txtPreviousGrade);
            this.Controls.Add(this.txtTotalExam);
            this.Controls.Add(this.txtOverScore);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtTotalRecit);
            this.Controls.Add(this.txtPercentScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formFinalsCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.pnlCalculator.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveScore;
        private Guna.UI2.WinForms.Guna2TextBox txtScore;
        private Guna.UI2.WinForms.Guna2TextBox txtPercentScore;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalRecit;
        private Guna.UI2.WinForms.Guna2Button btnCompute;
        private Guna.UI2.WinForms.Guna2TextBox txtOverScore;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalExam;
        private Guna.UI2.WinForms.Guna2TextBox txtPercentMidterm;
        private Guna.UI2.WinForms.Guna2TextBox txtPreviousGrade;
        private Guna.UI2.WinForms.Guna2Button btnSaveFin;
        private Guna.UI2.WinForms.Guna2Panel pnlScreen;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnNine;
        private Guna.UI2.WinForms.Guna2Panel pnlCalculator;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Button btnOverScore;
        private System.Windows.Forms.Label lblClassStanding;
        private System.Windows.Forms.Label lblExam;
        private Guna.UI2.WinForms.Guna2BorderlessForm formCalculatorTransition;
        internal Guna.UI2.WinForms.Guna2TextBox txtGrade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTerms;
        private System.Windows.Forms.ToolStripMenuItem pRELIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINALSToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInstructions;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnCLose;
    }
}