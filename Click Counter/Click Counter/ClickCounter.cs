using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class ClickCounter : Form
    {
        private Timer t;
        private Timer time;
        private Random r;
        private int s = 100;
        private int sum;
        private int count = 60;

        public ClickCounter()
        {
            InitializeComponent();
            r = new Random();

            t = new Timer();
            t.Enabled = true;
            t.Interval = 1500;
            t.Tick += ColourChange;

            time = new Timer();
            time.Enabled = true;
            time.Interval = 1000;
            time.Tick += TimeCount;
     
        }

        private void InitializeComponent()
        {
            this.OneBtn = new System.Windows.Forms.Button();
            this.TenBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OneBtn
            // 
            this.OneBtn.BackColor = System.Drawing.Color.Red;
            this.OneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OneBtn.Location = new System.Drawing.Point(207, 154);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(101, 50);
            this.OneBtn.TabIndex = 0;
            this.OneBtn.Text = "One";
            this.OneBtn.UseVisualStyleBackColor = false;
            this.OneBtn.Click += new System.EventHandler(this.OneClicked);
            // 
            // TenBtn
            // 
            this.TenBtn.BackColor = System.Drawing.Color.Red;
            this.TenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBtn.Location = new System.Drawing.Point(402, 501);
            this.TenBtn.Name = "TenBtn";
            this.TenBtn.Size = new System.Drawing.Size(101, 50);
            this.TenBtn.TabIndex = 1;
            this.TenBtn.Text = "Ten";
            this.TenBtn.UseVisualStyleBackColor = false;
            this.TenBtn.Click += new System.EventHandler(this.TenClicked);
            // 
            // NineBtn
            // 
            this.NineBtn.BackColor = System.Drawing.Color.Red;
            this.NineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineBtn.Location = new System.Drawing.Point(402, 413);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(101, 50);
            this.NineBtn.TabIndex = 2;
            this.NineBtn.Text = "Nine";
            this.NineBtn.UseVisualStyleBackColor = false;
            this.NineBtn.Click += new System.EventHandler(this.NineClicked);
            // 
            // EightBtn
            // 
            this.EightBtn.BackColor = System.Drawing.Color.Red;
            this.EightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBtn.Location = new System.Drawing.Point(402, 326);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(101, 50);
            this.EightBtn.TabIndex = 5;
            this.EightBtn.Text = "Eight";
            this.EightBtn.UseVisualStyleBackColor = false;
            this.EightBtn.Click += new System.EventHandler(this.EightClicked);
            // 
            // SevenBtn
            // 
            this.SevenBtn.BackColor = System.Drawing.Color.Red;
            this.SevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenBtn.Location = new System.Drawing.Point(402, 241);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(101, 50);
            this.SevenBtn.TabIndex = 6;
            this.SevenBtn.Text = "Seven";
            this.SevenBtn.UseVisualStyleBackColor = false;
            this.SevenBtn.Click += new System.EventHandler(this.SevenClicked);
            // 
            // SixBtn
            // 
            this.SixBtn.BackColor = System.Drawing.Color.Red;
            this.SixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixBtn.Location = new System.Drawing.Point(402, 154);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(101, 50);
            this.SixBtn.TabIndex = 7;
            this.SixBtn.Text = "Six";
            this.SixBtn.UseVisualStyleBackColor = false;
            this.SixBtn.Click += new System.EventHandler(this.SixClicked);
            // 
            // FiveBtn
            // 
            this.FiveBtn.BackColor = System.Drawing.Color.Red;
            this.FiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveBtn.Location = new System.Drawing.Point(207, 501);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(101, 50);
            this.FiveBtn.TabIndex = 8;
            this.FiveBtn.Text = "Five";
            this.FiveBtn.UseVisualStyleBackColor = false;
            this.FiveBtn.Click += new System.EventHandler(this.FiveClicked);
            // 
            // FourBtn
            // 
            this.FourBtn.BackColor = System.Drawing.Color.Red;
            this.FourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBtn.Location = new System.Drawing.Point(207, 413);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(101, 50);
            this.FourBtn.TabIndex = 9;
            this.FourBtn.Text = "Four";
            this.FourBtn.UseVisualStyleBackColor = false;
            this.FourBtn.Click += new System.EventHandler(this.FourClicked);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.BackColor = System.Drawing.Color.Red;
            this.ThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBtn.Location = new System.Drawing.Point(207, 326);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(101, 50);
            this.ThreeBtn.TabIndex = 10;
            this.ThreeBtn.Text = "Three";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeClicked);
            // 
            // TwoBtn
            // 
            this.TwoBtn.BackColor = System.Drawing.Color.Red;
            this.TwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoBtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBtn.Location = new System.Drawing.Point(207, 241);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(101, 50);
            this.TwoBtn.TabIndex = 11;
            this.TwoBtn.Text = "Two";
            this.TwoBtn.UseVisualStyleBackColor = false;
            this.TwoBtn.Click += new System.EventHandler(this.TwoClicked);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Gray;
            this.ScoreLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(265, 27);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(179, 63);
            this.ScoreLabel.TabIndex = 12;
            this.ScoreLabel.Text = "Score: ";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(163, 256);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(379, 90);
            this.ResultLabel.TabIndex = 13;
            this.ResultLabel.Text = "Your Total Score is: ";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLabel.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(680, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(72, 60);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 630);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.TenBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.ResultLabel);
            this.Name = "ClickCounter";
            this.Text = "Click Counter";
            this.ResumeLayout(false);

        }


        public void ColourChange(object sender, EventArgs e)
        {
            sum = r.Next(10);

            if (sum == 1)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Lime;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 2)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Lime;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 3)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Lime;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 4)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Lime;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 5)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Lime;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 6)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Lime;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 7)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Lime;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 8)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Lime;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 9)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Lime;
                this.TenBtn.BackColor = System.Drawing.Color.Red;
            }
            else if (sum == 10)
            {
                this.OneBtn.BackColor = System.Drawing.Color.Red;
                this.TwoBtn.BackColor = System.Drawing.Color.Red;
                this.ThreeBtn.BackColor = System.Drawing.Color.Red;
                this.FourBtn.BackColor = System.Drawing.Color.Red;
                this.FiveBtn.BackColor = System.Drawing.Color.Red;
                this.SixBtn.BackColor = System.Drawing.Color.Red;
                this.SevenBtn.BackColor = System.Drawing.Color.Red;
                this.EightBtn.BackColor = System.Drawing.Color.Red;
                this.NineBtn.BackColor = System.Drawing.Color.Red;
                this.TenBtn.BackColor = System.Drawing.Color.Lime;
            }

            this.ScoreLabel.Text = "Score: " + s;

            if (s == 0)
            {
                this.OneBtn.Visible = false;
                this.TwoBtn.Visible = false;
                this.ThreeBtn.Visible = false;
                this.FourBtn.Visible = false;
                this.FiveBtn.Visible = false;
                this.SixBtn.Visible = false;
                this.SevenBtn.Visible = false;
                this.EightBtn.Visible = false;
                this.NineBtn.Visible = false;
                this.TenBtn.Visible = false;

                this.ScoreLabel.Visible = false;
                this.TimeLabel.Visible = false;

                this.ResultLabel.Text += s;
                this.ResultLabel.Visible = true;
                t.Enabled = false;
            }

            //count--;
            //this.TimeLabel.Text = count.ToString();
        }

        public void TimeCount(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                this.TimeLabel.Text = count.ToString();
            }
            else
            {
                time.Enabled = false;

                this.OneBtn.Visible = false;
                this.TwoBtn.Visible = false;
                this.ThreeBtn.Visible = false;
                this.FourBtn.Visible = false;
                this.FiveBtn.Visible = false;
                this.SixBtn.Visible = false;
                this.SevenBtn.Visible = false;
                this.EightBtn.Visible = false;
                this.NineBtn.Visible = false;
                this.TenBtn.Visible = false;

                this.ScoreLabel.Visible = false;
                this.TimeLabel.Visible = false;

                this.ResultLabel.Text += s;
                this.ResultLabel.Visible = true;
                t.Enabled = false;
            }
        }

        private void OneClicked(object sender, EventArgs e)
        {
            if (sum == 1)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }

        }

        private void TwoClicked(object sender, EventArgs e)
        {
            if (sum == 2)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void ThreeClicked(object sender, EventArgs e)
        {
            if (sum == 3)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void FourClicked(object sender, EventArgs e)
        {
            if (sum == 4)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void FiveClicked(object sender, EventArgs e)
        {
            if (sum == 5)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void SixClicked(object sender, EventArgs e)
        {
            if (sum == 6)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void SevenClicked(object sender, EventArgs e)
        {
            if (sum == 7)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void EightClicked(object sender, EventArgs e)
        {
            if (sum == 8)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void NineClicked(object sender, EventArgs e)
        {
            if (sum == 9)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }

        private void TenClicked(object sender, EventArgs e)
        {
            if (sum == 10)
            {
                s += 10;
            }
            else
            {
                s -= 10;
            }
        }




    }
}
