namespace Tic_Tac_Toe
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StartImageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Image = global::Tic_Tac_Toe.Properties.Resources.download1;
            this.CloseBtn.Location = new System.Drawing.Point(607, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 38);
            this.CloseBtn.TabIndex = 31;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseClicked);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.White;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Image = global::Tic_Tac_Toe.Properties.Resources.enter_png_enter_icon_1600;
            this.StartBtn.Location = new System.Drawing.Point(559, -6);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(42, 53);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartClicked);
            // 
            // StartImageLabel
            // 
            this.StartImageLabel.Image = global::Tic_Tac_Toe.Properties.Resources.tic_tac_toe_1_1;
            this.StartImageLabel.Location = new System.Drawing.Point(12, 195);
            this.StartImageLabel.Name = "StartImageLabel";
            this.StartImageLabel.Size = new System.Drawing.Size(657, 297);
            this.StartImageLabel.TabIndex = 0;
            this.StartImageLabel.Click += new System.EventHandler(this.StartImageClicked);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(681, 576);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StartImageLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StartImageLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}