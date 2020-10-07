namespace Fool_Game
{
    partial class Fool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fool));
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.FoolLabel = new System.Windows.Forms.Label();
            this.StartAgainLabel = new System.Windows.Forms.Label();
            this.YesLabel = new System.Windows.Forms.Label();
            this.NoLabel = new System.Windows.Forms.Label();
            this.CopyRightLabel = new System.Windows.Forms.Label();
            this.YesFoolLabel = new System.Windows.Forms.Label();
            this.NoFoolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.White;
            this.YesBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.Location = new System.Drawing.Point(207, 358);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(126, 58);
            this.YesBtn.TabIndex = 0;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesClicked);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.White;
            this.NoBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.Location = new System.Drawing.Point(398, 358);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(126, 58);
            this.NoBtn.TabIndex = 1;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoClicked);
            this.NoBtn.MouseEnter += new System.EventHandler(this.MouseEntered);
            // 
            // FoolLabel
            // 
            this.FoolLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoolLabel.Location = new System.Drawing.Point(214, 129);
            this.FoolLabel.Name = "FoolLabel";
            this.FoolLabel.Size = new System.Drawing.Size(310, 56);
            this.FoolLabel.TabIndex = 2;
            this.FoolLabel.Text = "Are You a Fool?";
            this.FoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartAgainLabel
            // 
            this.StartAgainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartAgainLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAgainLabel.Location = new System.Drawing.Point(678, 32);
            this.StartAgainLabel.Name = "StartAgainLabel";
            this.StartAgainLabel.Size = new System.Drawing.Size(100, 23);
            this.StartAgainLabel.TabIndex = 3;
            this.StartAgainLabel.Text = "Start Again";
            this.StartAgainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartAgainLabel.Visible = false;
            this.StartAgainLabel.Click += new System.EventHandler(this.StartAgainClicked);
            // 
            // YesLabel
            // 
            this.YesLabel.Image = global::Fool_Game.Properties.Resources.YesImg;
            this.YesLabel.Location = new System.Drawing.Point(110, 87);
            this.YesLabel.Name = "YesLabel";
            this.YesLabel.Size = new System.Drawing.Size(578, 464);
            this.YesLabel.TabIndex = 4;
            this.YesLabel.Visible = false;
            // 
            // NoLabel
            // 
            this.NoLabel.Image = global::Fool_Game.Properties.Resources.NoImg;
            this.NoLabel.Location = new System.Drawing.Point(120, 97);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(526, 406);
            this.NoLabel.TabIndex = 5;
            this.NoLabel.Visible = false;
            // 
            // CopyRightLabel
            // 
            this.CopyRightLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRightLabel.Location = new System.Drawing.Point(576, 580);
            this.CopyRightLabel.Name = "CopyRightLabel";
            this.CopyRightLabel.Size = new System.Drawing.Size(202, 48);
            this.CopyRightLabel.TabIndex = 6;
            this.CopyRightLabel.Text = "© 2018 The Targaryen Wolf\r\nAll Rights Reserved";
            this.CopyRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YesFoolLabel
            // 
            this.YesFoolLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesFoolLabel.Location = new System.Drawing.Point(214, 473);
            this.YesFoolLabel.Name = "YesFoolLabel";
            this.YesFoolLabel.Size = new System.Drawing.Size(317, 63);
            this.YesFoolLabel.TabIndex = 7;
            this.YesFoolLabel.Text = "Haha! You are a Fool!!";
            this.YesFoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YesFoolLabel.Visible = false;
            // 
            // NoFoolLabel
            // 
            this.NoFoolLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFoolLabel.Location = new System.Drawing.Point(210, 475);
            this.NoFoolLabel.Name = "NoFoolLabel";
            this.NoFoolLabel.Size = new System.Drawing.Size(317, 63);
            this.NoFoolLabel.TabIndex = 8;
            this.NoFoolLabel.Text = "Okay! You are not a Fool!!";
            this.NoFoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NoFoolLabel.Visible = false;
            // 
            // Fool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(790, 637);
            this.Controls.Add(this.YesFoolLabel);
            this.Controls.Add(this.CopyRightLabel);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.StartAgainLabel);
            this.Controls.Add(this.FoolLabel);
            this.Controls.Add(this.NoFoolLabel);
            this.Controls.Add(this.YesLabel);
            this.Controls.Add(this.NoLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fool";
            this.Text = "Fool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Label FoolLabel;
        private System.Windows.Forms.Label StartAgainLabel;
        private System.Windows.Forms.Label YesLabel;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.Label CopyRightLabel;
        private System.Windows.Forms.Label YesFoolLabel;
        private System.Windows.Forms.Label NoFoolLabel;
    }
}

