namespace Calculator
{
    public partial class Calculator
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
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.RootBtn = new System.Windows.Forms.Button();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.StandardLabel = new System.Windows.Forms.Label();
            this.ScreenRTB = new System.Windows.Forms.RichTextBox();
            this.MPlusLabel = new System.Windows.Forms.Label();
            this.MCLabel = new System.Windows.Forms.Label();
            this.MRLabel = new System.Windows.Forms.Label();
            this.MMinusLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.HistoryBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ZeroBtn.FlatAppearance.BorderSize = 0;
            this.ZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.Location = new System.Drawing.Point(121, 572);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(109, 61);
            this.ZeroBtn.TabIndex = 36;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroClicked);
            // 
            // DotBtn
            // 
            this.DotBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.DotBtn.FlatAppearance.BorderSize = 0;
            this.DotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotBtn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotBtn.Location = new System.Drawing.Point(236, 572);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(109, 61);
            this.DotBtn.TabIndex = 37;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = false;
            this.DotBtn.Click += new System.EventHandler(this.DotClicked);
            // 
            // EqualBtn
            // 
            this.EqualBtn.BackColor = System.Drawing.Color.DarkGray;
            this.EqualBtn.FlatAppearance.BorderSize = 0;
            this.EqualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBtn.Location = new System.Drawing.Point(351, 572);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(109, 61);
            this.EqualBtn.TabIndex = 38;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = false;
            this.EqualBtn.Click += new System.EventHandler(this.EqualClicked);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ThreeBtn.FlatAppearance.BorderSize = 0;
            this.ThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBtn.Location = new System.Drawing.Point(236, 505);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(109, 61);
            this.ThreeBtn.TabIndex = 39;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeClicked);
            // 
            // TwoBtn
            // 
            this.TwoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TwoBtn.FlatAppearance.BorderSize = 0;
            this.TwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBtn.Location = new System.Drawing.Point(121, 505);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(109, 61);
            this.TwoBtn.TabIndex = 40;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = false;
            this.TwoBtn.Click += new System.EventHandler(this.TwoClicked);
            // 
            // OneBtn
            // 
            this.OneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OneBtn.FlatAppearance.BorderSize = 0;
            this.OneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.Location = new System.Drawing.Point(6, 505);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(109, 61);
            this.OneBtn.TabIndex = 41;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = false;
            this.OneBtn.Click += new System.EventHandler(this.OneClicked);
            // 
            // SixBtn
            // 
            this.SixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SixBtn.FlatAppearance.BorderSize = 0;
            this.SixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixBtn.Location = new System.Drawing.Point(236, 438);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(109, 61);
            this.SixBtn.TabIndex = 42;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = false;
            this.SixBtn.Click += new System.EventHandler(this.SixClicked);
            // 
            // FiveBtn
            // 
            this.FiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FiveBtn.FlatAppearance.BorderSize = 0;
            this.FiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveBtn.Location = new System.Drawing.Point(121, 438);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(109, 61);
            this.FiveBtn.TabIndex = 43;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = false;
            this.FiveBtn.Click += new System.EventHandler(this.FiveClicked);
            // 
            // FourBtn
            // 
            this.FourBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FourBtn.FlatAppearance.BorderSize = 0;
            this.FourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBtn.Location = new System.Drawing.Point(6, 438);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(109, 61);
            this.FourBtn.TabIndex = 44;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = false;
            this.FourBtn.Click += new System.EventHandler(this.FourClicked);
            // 
            // SevenBtn
            // 
            this.SevenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SevenBtn.FlatAppearance.BorderSize = 0;
            this.SevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenBtn.Location = new System.Drawing.Point(6, 371);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(109, 61);
            this.SevenBtn.TabIndex = 45;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = false;
            this.SevenBtn.Click += new System.EventHandler(this.SevenClicked);
            // 
            // EightBtn
            // 
            this.EightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.EightBtn.FlatAppearance.BorderSize = 0;
            this.EightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBtn.Location = new System.Drawing.Point(121, 371);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(109, 61);
            this.EightBtn.TabIndex = 46;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = false;
            this.EightBtn.Click += new System.EventHandler(this.EightClicked);
            // 
            // NineBtn
            // 
            this.NineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.NineBtn.FlatAppearance.BorderSize = 0;
            this.NineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineBtn.Location = new System.Drawing.Point(236, 371);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(109, 61);
            this.NineBtn.TabIndex = 47;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = false;
            this.NineBtn.Click += new System.EventHandler(this.NineClicked);
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.PlusBtn.FlatAppearance.BorderSize = 0;
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBtn.Location = new System.Drawing.Point(351, 505);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(109, 61);
            this.PlusBtn.TabIndex = 48;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusClicked);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.DivisionBtn.FlatAppearance.BorderSize = 0;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionBtn.Location = new System.Drawing.Point(351, 304);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(109, 61);
            this.DivisionBtn.TabIndex = 49;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = false;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionClicked);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MultiplicationBtn.FlatAppearance.BorderSize = 0;
            this.MultiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplicationBtn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationBtn.Location = new System.Drawing.Point(351, 371);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(109, 61);
            this.MultiplicationBtn.TabIndex = 50;
            this.MultiplicationBtn.Text = "*";
            this.MultiplicationBtn.UseVisualStyleBackColor = false;
            this.MultiplicationBtn.Click += new System.EventHandler(this.MultiplicationClicked);
            // 
            // MinusBtn
            // 
            this.MinusBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MinusBtn.FlatAppearance.BorderSize = 0;
            this.MinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusBtn.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.Location = new System.Drawing.Point(351, 438);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(109, 61);
            this.MinusBtn.TabIndex = 51;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.MinusClicked);
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.CBtn.FlatAppearance.BorderSize = 0;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.Location = new System.Drawing.Point(121, 304);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(109, 61);
            this.CBtn.TabIndex = 54;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.CClicked);
            // 
            // RootBtn
            // 
            this.RootBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.RootBtn.FlatAppearance.BorderSize = 0;
            this.RootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RootBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootBtn.Location = new System.Drawing.Point(6, 304);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(109, 61);
            this.RootBtn.TabIndex = 58;
            this.RootBtn.Text = "Root";
            this.RootBtn.UseVisualStyleBackColor = false;
            this.RootBtn.Click += new System.EventHandler(this.RootClicked);
            // 
            // PowerBtn
            // 
            this.PowerBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.PowerBtn.FlatAppearance.BorderSize = 0;
            this.PowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerBtn.Location = new System.Drawing.Point(6, 572);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(109, 61);
            this.PowerBtn.TabIndex = 59;
            this.PowerBtn.Text = "^";
            this.PowerBtn.UseVisualStyleBackColor = false;
            this.PowerBtn.Click += new System.EventHandler(this.PowerClicked);
            // 
            // StandardLabel
            // 
            this.StandardLabel.AutoSize = true;
            this.StandardLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StandardLabel.Location = new System.Drawing.Point(12, 8);
            this.StandardLabel.Name = "StandardLabel";
            this.StandardLabel.Size = new System.Drawing.Size(103, 29);
            this.StandardLabel.TabIndex = 60;
            this.StandardLabel.Text = "Standard";
            this.StandardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenRTB
            // 
            this.ScreenRTB.BackColor = System.Drawing.Color.White;
            this.ScreenRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScreenRTB.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenRTB.Location = new System.Drawing.Point(13, 68);
            this.ScreenRTB.Name = "ScreenRTB";
            this.ScreenRTB.ReadOnly = true;
            this.ScreenRTB.Size = new System.Drawing.Size(441, 180);
            this.ScreenRTB.TabIndex = 62;
            this.ScreenRTB.Text = "0";
            // 
            // MPlusLabel
            // 
            this.MPlusLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPlusLabel.Location = new System.Drawing.Point(51, 274);
            this.MPlusLabel.Name = "MPlusLabel";
            this.MPlusLabel.Size = new System.Drawing.Size(44, 23);
            this.MPlusLabel.TabIndex = 63;
            this.MPlusLabel.Text = "M+";
            this.MPlusLabel.Click += new System.EventHandler(this.MPlusClicked);
            // 
            // MCLabel
            // 
            this.MCLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCLabel.Location = new System.Drawing.Point(395, 274);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(44, 23);
            this.MCLabel.TabIndex = 64;
            this.MCLabel.Text = "MC";
            this.MCLabel.Click += new System.EventHandler(this.MCClicked);
            // 
            // MRLabel
            // 
            this.MRLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRLabel.Location = new System.Drawing.Point(275, 274);
            this.MRLabel.Name = "MRLabel";
            this.MRLabel.Size = new System.Drawing.Size(44, 23);
            this.MRLabel.TabIndex = 65;
            this.MRLabel.Text = "MR";
            this.MRLabel.Click += new System.EventHandler(this.MRClicked);
            // 
            // MMinusLabel
            // 
            this.MMinusLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMinusLabel.Location = new System.Drawing.Point(167, 274);
            this.MMinusLabel.Name = "MMinusLabel";
            this.MMinusLabel.Size = new System.Drawing.Size(44, 23);
            this.MMinusLabel.TabIndex = 66;
            this.MMinusLabel.Text = "M-";
            this.MMinusLabel.Click += new System.EventHandler(this.MMinusClicked);
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Image = global::Calculator.Properties.Resources._11143_200;
            this.HistoryLabel.Location = new System.Drawing.Point(407, 8);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(53, 23);
            this.HistoryLabel.TabIndex = 67;
            this.HistoryLabel.Click += new System.EventHandler(this.HistoryClicked);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Image = global::Calculator.Properties.Resources._344330_2003;
            this.BackBtn.Location = new System.Drawing.Point(236, 304);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 61);
            this.BackBtn.TabIndex = 53;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackClicked);
            // 
            // HistoryBoxLabel
            // 
            this.HistoryBoxLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBoxLabel.Location = new System.Drawing.Point(6, 68);
            this.HistoryBoxLabel.Name = "HistoryBoxLabel";
            this.HistoryBoxLabel.Size = new System.Drawing.Size(454, 565);
            this.HistoryBoxLabel.TabIndex = 68;
            this.HistoryBoxLabel.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 644);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.MMinusLabel);
            this.Controls.Add(this.MRLabel);
            this.Controls.Add(this.MCLabel);
            this.Controls.Add(this.MPlusLabel);
            this.Controls.Add(this.ScreenRTB);
            this.Controls.Add(this.StandardLabel);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.RootBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MultiplicationBtn);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.HistoryBoxLabel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button RootBtn;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.Label StandardLabel;
        private System.Windows.Forms.RichTextBox ScreenRTB;
        private System.Windows.Forms.Label MPlusLabel;
        private System.Windows.Forms.Label MCLabel;
        private System.Windows.Forms.Label MRLabel;
        private System.Windows.Forms.Label MMinusLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label HistoryBoxLabel;
    }
}

