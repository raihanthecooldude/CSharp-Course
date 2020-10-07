using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Matching
{
    public partial class PuzzleMatching : Form
    {
        //private Random x;
        private Random place;

        private int c11 = 0, c12 = 0, c21 = 0, c22 = 0, c31 = 0, c32 = 0, c41 = 0, c42 = 0, c51 = 0, c52 = 0, c61 = 0, c62 = 0, c71 = 0, c72 = 0, c81 = 0, c82 = 0, c91 = 0, c92 = 0, c101 = 0, c102 = 0, c111 = 0, c112 = 0, c121 = 0, c122 = 0, c131 = 0, c132 = 0, c141 = 0, c142 = 0, c151 = 0, c152 = 0;


        public PuzzleMatching()
        {
            InitializeComponent();
            Location();
        }

        

        private void InitializeComponent()
        {
            place = new Random();

            this.One1Btn = new System.Windows.Forms.Button();
            this.Two2Btn = new System.Windows.Forms.Button();
            this.One2Btn = new System.Windows.Forms.Button();
            this.Eleven1Btn = new System.Windows.Forms.Button();
            this.Two1Btn = new System.Windows.Forms.Button();
            this.Four2Btn = new System.Windows.Forms.Button();
            this.Three2Btn = new System.Windows.Forms.Button();
            this.Three1Btn = new System.Windows.Forms.Button();
            this.Nine2Btn = new System.Windows.Forms.Button();
            this.Nine1Btn = new System.Windows.Forms.Button();
            this.Seven2Btn = new System.Windows.Forms.Button();
            this.Five2Btn = new System.Windows.Forms.Button();
            this.Five1Btn = new System.Windows.Forms.Button();
            this.Eleven2Btn = new System.Windows.Forms.Button();
            this.Seven1Btn = new System.Windows.Forms.Button();
            this.Twelve1Btn = new System.Windows.Forms.Button();
            this.Thirteen2Btn = new System.Windows.Forms.Button();
            this.Twelve2Btn = new System.Windows.Forms.Button();
            this.Forteen2Btn = new System.Windows.Forms.Button();
            this.Forteen1Btn = new System.Windows.Forms.Button();
            this.Eight1Btn = new System.Windows.Forms.Button();
            this.Eight2Btn = new System.Windows.Forms.Button();
            this.Thirteen1Btn = new System.Windows.Forms.Button();
            this.Four1Btn = new System.Windows.Forms.Button();
            this.Fifteen1Btn = new System.Windows.Forms.Button();
            this.Fifteen2Btn = new System.Windows.Forms.Button();
            this.Six2Btn = new System.Windows.Forms.Button();
            this.Six1Btn = new System.Windows.Forms.Button();
            this.Ten2Btn = new System.Windows.Forms.Button();
            this.Ten1Btn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // One1Btn
            // 
            this.One1Btn.BackColor = System.Drawing.Color.White;
            this.One1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.One1Btn.Name = "One1Btn";
            this.One1Btn.Size = new System.Drawing.Size(73, 61);
            this.One1Btn.TabIndex = 0;
            this.One1Btn.UseVisualStyleBackColor = false;
            this.One1Btn.Click += new System.EventHandler(this.One1Clicked);
            // 
            // Two2Btn
            // 
            this.Two2Btn.BackColor = System.Drawing.Color.White;
            this.Two2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Two2Btn.Name = "Two2Btn";
            this.Two2Btn.Size = new System.Drawing.Size(73, 61);
            this.Two2Btn.TabIndex = 1;
            this.Two2Btn.UseVisualStyleBackColor = false;
            this.Two2Btn.Click += new System.EventHandler(this.Two2Clicked);
            // 
            // One2Btn
            // 
            this.One2Btn.BackColor = System.Drawing.Color.White;
            this.One2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.One2Btn.Name = "One2Btn";
            this.One2Btn.Size = new System.Drawing.Size(73, 61);
            this.One2Btn.TabIndex = 2;
            this.One2Btn.UseVisualStyleBackColor = false;
            this.One2Btn.Click += new System.EventHandler(this.One2Clicked);
            // 
            // Eleven1Btn
            // 
            this.Eleven1Btn.BackColor = System.Drawing.Color.White;
            this.Eleven1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eleven1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Eleven1Btn.Name = "Eleven1Btn";
            this.Eleven1Btn.Size = new System.Drawing.Size(73, 61);
            this.Eleven1Btn.TabIndex = 3;
            this.Eleven1Btn.UseVisualStyleBackColor = false;
            this.Eleven1Btn.Click += new System.EventHandler(this.Eleven1Clicked);
            // 
            // Two1Btn
            // 
            this.Two1Btn.BackColor = System.Drawing.Color.White;
            this.Two1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Two1Btn.Name = "Two1Btn";
            this.Two1Btn.Size = new System.Drawing.Size(73, 61);
            this.Two1Btn.TabIndex = 6;
            this.Two1Btn.UseVisualStyleBackColor = false;
            this.Two1Btn.Click += new System.EventHandler(this.Two1Clicked);
            // 
            // Four2Btn
            // 
            this.Four2Btn.BackColor = System.Drawing.Color.White;
            this.Four2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Four2Btn.Name = "Four2Btn";
            this.Four2Btn.Size = new System.Drawing.Size(73, 61);
            this.Four2Btn.TabIndex = 7;
            this.Four2Btn.UseVisualStyleBackColor = false;
            this.Four2Btn.Click += new System.EventHandler(this.Four2Clicked);
            // 
            // Three2Btn
            // 
            this.Three2Btn.BackColor = System.Drawing.Color.White;
            this.Three2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Three2Btn.Name = "Three2Btn";
            this.Three2Btn.Size = new System.Drawing.Size(73, 61);
            this.Three2Btn.TabIndex = 9;
            this.Three2Btn.UseVisualStyleBackColor = false;
            this.Three2Btn.Click += new System.EventHandler(this.Three2Clicked);
            // 
            // Three1Btn
            // 
            this.Three1Btn.BackColor = System.Drawing.Color.White;
            this.Three1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Three1Btn.Name = "Three1Btn";
            this.Three1Btn.Size = new System.Drawing.Size(73, 61);
            this.Three1Btn.TabIndex = 10;
            this.Three1Btn.UseVisualStyleBackColor = false;
            this.Three1Btn.Click += new System.EventHandler(this.Three1Clicked);
            // 
            // Nine2Btn
            // 
            this.Nine2Btn.BackColor = System.Drawing.Color.White;
            this.Nine2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Nine2Btn.Name = "Nine2Btn";
            this.Nine2Btn.Size = new System.Drawing.Size(73, 61);
            this.Nine2Btn.TabIndex = 11;
            this.Nine2Btn.UseVisualStyleBackColor = false;
            this.Nine2Btn.Click += new System.EventHandler(this.Nine2Clicked);
            // 
            // Nine1Btn
            // 
            this.Nine1Btn.BackColor = System.Drawing.Color.White;
            this.Nine1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Nine1Btn.Name = "Nine1Btn";
            this.Nine1Btn.Size = new System.Drawing.Size(73, 61);
            this.Nine1Btn.TabIndex = 12;
            this.Nine1Btn.UseVisualStyleBackColor = false;
            this.Nine1Btn.Click += new System.EventHandler(this.Nine1Clicked);
            // 
            // Seven2Btn
            // 
            this.Seven2Btn.BackColor = System.Drawing.Color.White;
            this.Seven2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Seven2Btn.Name = "Seven2Btn";
            this.Seven2Btn.Size = new System.Drawing.Size(73, 61);
            this.Seven2Btn.TabIndex = 13;
            this.Seven2Btn.UseVisualStyleBackColor = false;
            this.Seven2Btn.Click += new System.EventHandler(this.Seven2Clicked);
            // 
            // Five2Btn
            // 
            this.Five2Btn.BackColor = System.Drawing.Color.White;
            this.Five2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Five2Btn.Name = "Five2Btn";
            this.Five2Btn.Size = new System.Drawing.Size(73, 61);
            this.Five2Btn.TabIndex = 14;
            this.Five2Btn.UseVisualStyleBackColor = false;
            this.Five2Btn.Click += new System.EventHandler(this.Five2Clicked);
            // 
            // Five1Btn
            // 
            this.Five1Btn.BackColor = System.Drawing.Color.White;
            this.Five1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Five1Btn.Name = "Five1Btn";
            this.Five1Btn.Size = new System.Drawing.Size(73, 61);
            this.Five1Btn.TabIndex = 15;
            this.Five1Btn.UseVisualStyleBackColor = false;
            this.Five1Btn.Click += new System.EventHandler(this.Five1Clicked);
            // 
            // Eleven2Btn
            // 
            this.Eleven2Btn.BackColor = System.Drawing.Color.White;
            this.Eleven2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eleven2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Eleven2Btn.Name = "Eleven2Btn";
            this.Eleven2Btn.Size = new System.Drawing.Size(73, 61);
            this.Eleven2Btn.TabIndex = 16;
            this.Eleven2Btn.UseVisualStyleBackColor = false;
            this.Eleven2Btn.Click += new System.EventHandler(this.Eleven2Clicked);
            // 
            // Seven1Btn
            // 
            this.Seven1Btn.BackColor = System.Drawing.Color.White;
            this.Seven1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Seven1Btn.Name = "Seven1Btn";
            this.Seven1Btn.Size = new System.Drawing.Size(73, 61);
            this.Seven1Btn.TabIndex = 17;
            this.Seven1Btn.UseVisualStyleBackColor = false;
            this.Seven1Btn.Click += new System.EventHandler(this.Seven1Clicked);
            // 
            // Twelve1Btn
            // 
            this.Twelve1Btn.BackColor = System.Drawing.Color.White;
            this.Twelve1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Twelve1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Twelve1Btn.Name = "Twelve1Btn";
            this.Twelve1Btn.Size = new System.Drawing.Size(73, 61);
            this.Twelve1Btn.TabIndex = 18;
            this.Twelve1Btn.UseVisualStyleBackColor = false;
            this.Twelve1Btn.Click += new System.EventHandler(this.Twelve1Clicked);
            // 
            // Thirteen2Btn
            // 
            this.Thirteen2Btn.BackColor = System.Drawing.Color.White;
            this.Thirteen2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thirteen2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Thirteen2Btn.Name = "Thirteen2Btn";
            this.Thirteen2Btn.Size = new System.Drawing.Size(73, 61);
            this.Thirteen2Btn.TabIndex = 19;
            this.Thirteen2Btn.UseVisualStyleBackColor = false;
            this.Thirteen2Btn.Click += new System.EventHandler(this.Thirteen2Clicked);
            // 
            // Twelve2Btn
            // 
            this.Twelve2Btn.BackColor = System.Drawing.Color.White;
            this.Twelve2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Twelve2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Twelve2Btn.Name = "Twelve2Btn";
            this.Twelve2Btn.Size = new System.Drawing.Size(73, 61);
            this.Twelve2Btn.TabIndex = 20;
            this.Twelve2Btn.UseVisualStyleBackColor = false;
            this.Twelve2Btn.Click += new System.EventHandler(this.Twelve2Clicked);
            // 
            // Forteen2Btn
            // 
            this.Forteen2Btn.BackColor = System.Drawing.Color.White;
            this.Forteen2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forteen2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Forteen2Btn.Name = "Forteen2Btn";
            this.Forteen2Btn.Size = new System.Drawing.Size(73, 61);
            this.Forteen2Btn.TabIndex = 21;
            this.Forteen2Btn.UseVisualStyleBackColor = false;
            this.Forteen2Btn.Click += new System.EventHandler(this.Forteen2Clicked);
            // 
            // Forteen1Btn
            // 
            this.Forteen1Btn.BackColor = System.Drawing.Color.White;
            this.Forteen1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forteen1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Forteen1Btn.Name = "Forteen1Btn";
            this.Forteen1Btn.Size = new System.Drawing.Size(73, 61);
            this.Forteen1Btn.TabIndex = 22;
            this.Forteen1Btn.UseVisualStyleBackColor = false;
            this.Forteen1Btn.Click += new System.EventHandler(this.Forteen1Clicked);
            // 
            // Eight1Btn
            // 
            this.Eight1Btn.BackColor = System.Drawing.Color.White;
            this.Eight1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Eight1Btn.Name = "Eight1Btn";
            this.Eight1Btn.Size = new System.Drawing.Size(73, 61);
            this.Eight1Btn.TabIndex = 23;
            this.Eight1Btn.UseVisualStyleBackColor = false;
            this.Eight1Btn.Click += new System.EventHandler(this.Eight1Clicked);
            // 
            // Eight2Btn
            // 
            this.Eight2Btn.BackColor = System.Drawing.Color.White;
            this.Eight2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Eight2Btn.Name = "Eight2Btn";
            this.Eight2Btn.Size = new System.Drawing.Size(73, 61);
            this.Eight2Btn.TabIndex = 24;
            this.Eight2Btn.UseVisualStyleBackColor = false;
            this.Eight2Btn.Click += new System.EventHandler(this.Eight2Clicked);
            // 
            // Thirteen1Btn
            // 
            this.Thirteen1Btn.BackColor = System.Drawing.Color.White;
            this.Thirteen1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thirteen1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Thirteen1Btn.Name = "Thirteen1Btn";
            this.Thirteen1Btn.Size = new System.Drawing.Size(73, 61);
            this.Thirteen1Btn.TabIndex = 25;
            this.Thirteen1Btn.UseVisualStyleBackColor = false;
            this.Thirteen1Btn.Click += new System.EventHandler(this.Thirteen1Clicked);
            // 
            // Four1Btn
            // 
            this.Four1Btn.BackColor = System.Drawing.Color.White;
            this.Four1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Four1Btn.Name = "Four1Btn";
            this.Four1Btn.Size = new System.Drawing.Size(73, 61);
            this.Four1Btn.TabIndex = 26;
            this.Four1Btn.UseVisualStyleBackColor = false;
            this.Four1Btn.Click += new System.EventHandler(this.Four1Clicked);
            // 
            // Fifteen1Btn
            // 
            this.Fifteen1Btn.BackColor = System.Drawing.Color.White;
            this.Fifteen1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fifteen1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Fifteen1Btn.Name = "Fifteen1Btn";
            this.Fifteen1Btn.Size = new System.Drawing.Size(73, 61);
            this.Fifteen1Btn.TabIndex = 29;
            this.Fifteen1Btn.UseVisualStyleBackColor = false;
            this.Fifteen1Btn.Click += new System.EventHandler(this.Fifteen1Clicked);
            // 
            // Fifteen2Btn
            // 
            this.Fifteen2Btn.BackColor = System.Drawing.Color.White;
            this.Fifteen2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fifteen2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Fifteen2Btn.Name = "Fifteen2Btn";
            this.Fifteen2Btn.Size = new System.Drawing.Size(73, 61);
            this.Fifteen2Btn.TabIndex = 30;
            this.Fifteen2Btn.UseVisualStyleBackColor = false;
            this.Fifteen2Btn.Click += new System.EventHandler(this.Fifteen2Clicked);
            // 
            // Six2Btn
            // 
            this.Six2Btn.BackColor = System.Drawing.Color.White;
            this.Six2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Six2Btn.Name = "Six2Btn";
            this.Six2Btn.Size = new System.Drawing.Size(73, 61);
            this.Six2Btn.TabIndex = 31;
            this.Six2Btn.UseVisualStyleBackColor = false;
            this.Six2Btn.Click += new System.EventHandler(this.Six2Clicked);
            // 
            // Six1Btn
            // 
            this.Six1Btn.BackColor = System.Drawing.Color.White;
            this.Six1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Six1Btn.Name = "Six1Btn";
            this.Six1Btn.Size = new System.Drawing.Size(73, 61);
            this.Six1Btn.TabIndex = 32;
            this.Six1Btn.UseVisualStyleBackColor = false;
            this.Six1Btn.Click += new System.EventHandler(this.Six1Clicked);
            // 
            // Ten2Btn
            // 
            this.Ten2Btn.BackColor = System.Drawing.Color.White;
            this.Ten2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ten2Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Ten2Btn.Name = "Ten2Btn";
            this.Ten2Btn.Size = new System.Drawing.Size(73, 61);
            this.Ten2Btn.TabIndex = 33;
            this.Ten2Btn.UseVisualStyleBackColor = false;
            this.Ten2Btn.Click += new System.EventHandler(this.Ten2Clicked);
            // 
            // Ten1Btn
            // 
            this.Ten1Btn.BackColor = System.Drawing.Color.White;
            this.Ten1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ten1Btn.Location = new System.Drawing.Point(place.Next(900), place.Next(490));
            this.Ten1Btn.Name = "Ten1Btn";
            this.Ten1Btn.Size = new System.Drawing.Size(73, 61);
            this.Ten1Btn.TabIndex = 34;
            this.Ten1Btn.UseVisualStyleBackColor = false;
            this.Ten1Btn.Click += new System.EventHandler(this.Ten1Clicked);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.White;
            this.ScoreLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.ScoreLabel.Location = new System.Drawing.Point(259, 270);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(609, 232);
            this.ScoreLabel.TabIndex = 35;
            this.ScoreLabel.Text = "Congrats! You have finished the game.";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScoreLabel.Visible = false;
            // 
            // PuzzleMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1125, 653);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Ten1Btn);
            this.Controls.Add(this.Ten2Btn);
            this.Controls.Add(this.Six1Btn);
            this.Controls.Add(this.Six2Btn);
            this.Controls.Add(this.Fifteen2Btn);
            this.Controls.Add(this.Fifteen1Btn);
            this.Controls.Add(this.Four1Btn);
            this.Controls.Add(this.Thirteen1Btn);
            this.Controls.Add(this.Eight2Btn);
            this.Controls.Add(this.Eight1Btn);
            this.Controls.Add(this.Forteen1Btn);
            this.Controls.Add(this.Forteen2Btn);
            this.Controls.Add(this.Twelve2Btn);
            this.Controls.Add(this.Thirteen2Btn);
            this.Controls.Add(this.Twelve1Btn);
            this.Controls.Add(this.Seven1Btn);
            this.Controls.Add(this.Eleven2Btn);
            this.Controls.Add(this.Five1Btn);
            this.Controls.Add(this.Five2Btn);
            this.Controls.Add(this.Seven2Btn);
            this.Controls.Add(this.Nine1Btn);
            this.Controls.Add(this.Nine2Btn);
            this.Controls.Add(this.Three1Btn);
            this.Controls.Add(this.Three2Btn);
            this.Controls.Add(this.Four2Btn);
            this.Controls.Add(this.Two1Btn);
            this.Controls.Add(this.Eleven1Btn);
            this.Controls.Add(this.One2Btn);
            this.Controls.Add(this.Two2Btn);
            this.Controls.Add(this.One1Btn);
            this.Name = "PuzzleMatching";
            this.Text = "Puzzle Matching";
            this.ResumeLayout(false);

        }

        private void One1Clicked(object sender, EventArgs e)
        {
            c11 = 1;
            if (c12 == 0)
            {
                Zero();

                c11 = 1;
                this.One1Btn.Image = global::Puzzle_Matching.Properties.Resources.DareDevil1;
            }
            else if (c12 == 1 && c11 == 1)
            {
                this.One1Btn.Visible = false;
                this.One2Btn.Visible = false;
            }

            Score();

            this.One2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;



            //this.One1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void One2Clicked(object sender, EventArgs e)
        {
            c12 = 1;
            if (c11 == 0)
            {
                Zero();

                c12 = 1;
                this.One2Btn.Image = global::Puzzle_Matching.Properties.Resources.DareDevil1;
            }
            else if (c12 == 1 && c11 == 1)
            {
                this.One1Btn.Visible = false;
                this.One2Btn.Visible = false;
            }

            Score();

            

            this.One1Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.One2Btn.Enabled = false;

            //this.One1Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;

        }

        private void Two1Clicked(object sender, EventArgs e)
        {
            c21 = 1;
            if (c22 == 0)
            {
                Zero();

                c21 = 1;
                this.Two1Btn.Image = global::Puzzle_Matching.Properties.Resources.BlackWidow1;
            }
            else if (c22 == 1 && c21 == 1)
            {
                this.Two1Btn.Visible = false;
                this.Two2Btn.Visible = false;
            }

            Score();

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;

            //this.Two1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;

        }

        private void Two2Clicked(object sender, EventArgs e)
        {
            c22 = 1;
            if (c21 == 0)
            {
                Zero();

                c22 = 1;
                this.Two2Btn.Image = global::Puzzle_Matching.Properties.Resources.BlackWidow1;
            }
            else if (c22 == 1 && c21 == 1)
            {
                this.Two1Btn.Visible = false;
                this.Two2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Two2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Three1Clicked(object sender, EventArgs e)
        {
            c31 = 1;
            if (c32 == 0)
            {
                Zero();

                c31 = 1;
                this.Three1Btn.Image = global::Puzzle_Matching.Properties.Resources.Thor1;
            }
            else if (c31 == 1 && c32 == 1)
            {

                this.Three1Btn.Visible = false;
                this.Three2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Three1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Three2Clicked(object sender, EventArgs e)
        {
            c32 = 1;
            if (c31 == 0)
            {
                Zero();

                c32 = 1;
                this.Three2Btn.Image = global::Puzzle_Matching.Properties.Resources.Thor1;
            }
            else if (c31 == 1 && c32 == 1)
            {

                this.Three1Btn.Visible = false;
                this.Three2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Three2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Four1Clicked(object sender, EventArgs e)
        {
            c41 = 1;
            if (c42 == 0)
            {
                Zero();

                c41 = 1;
                this.Four1Btn.Image = global::Puzzle_Matching.Properties.Resources.Spidey1;
            }
            else if (c41 == 1 && c42 == 1)
            {

                this.Four1Btn.Visible = false;
                this.Four2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Four1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Four2Clicked(object sender, EventArgs e)
        {
            c42 = 1;
            if (c41 == 0)
            {
                Zero();

                c42 = 1;
                this.Four2Btn.Image = global::Puzzle_Matching.Properties.Resources.Spidey1;
            }
            else if (c41 == 1 && c42 == 1)
            {

                this.Four1Btn.Visible = false;
                this.Four2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Four2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Five1Clicked(object sender, EventArgs e)
        {
            c51 = 1;
            if (c52 == 0)
            {
                Zero();

                c51 = 1;
                this.Five1Btn.Image = global::Puzzle_Matching.Properties.Resources.Cap1;
            }
            else if (c51 == 1 && c52 == 1)
            {

                this.Five1Btn.Visible = false;
                this.Five2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Five1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Five2Clicked(object sender, EventArgs e)
        {
            c52 = 1;
            if (c51 == 0)
            {
                Zero();

                c52 = 1;
                this.Five2Btn.Image = global::Puzzle_Matching.Properties.Resources.Cap1;
            }
            else if (c51 == 1 && c52 == 1)
            {

                this.Five1Btn.Visible = false;
                this.Five2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Five2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Six1Clicked(object sender, EventArgs e)
        {
            c61 = 1;
            if (c62 == 0)
            {
                Zero();

                c61 = 1;
                this.Six1Btn.Image = global::Puzzle_Matching.Properties.Resources.IronMan1;
            }
            else if (c61 == 1 && c62 == 1)
            {

                this.Six1Btn.Visible = false;
                this.Six2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Six1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Six2Clicked(object sender, EventArgs e)
        {
            c62 = 1;
            if (c61 == 0)
            {
                Zero();

                c61 = 1;
                this.Six2Btn.Image = global::Puzzle_Matching.Properties.Resources.IronMan1;
            }
            else if (c61 == 1 && c62 == 1)
            {

                this.Six1Btn.Visible = false;
                this.Six2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Six2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;

        }

        private void Seven1Clicked(object sender, EventArgs e)
        {
            c71 = 1;
            if (c72 == 0)
            {
                Zero();

                c71 = 1;
                this.Seven1Btn.Image = global::Puzzle_Matching.Properties.Resources.Shield1;
            }
            else if (c71 == 1 && c72 == 1)
            {

                this.Seven1Btn.Visible = false;
                this.Seven2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Seven1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Seven2Clicked(object sender, EventArgs e)
        {
            c72 = 1;
            if (c71 == 0)
            {
                Zero();

                c72 = 1;
                this.Seven2Btn.Image = global::Puzzle_Matching.Properties.Resources.Shield1;
            }
            else if (c71 == 1 && c72 == 1)
            {

                this.Seven1Btn.Visible = false;
                this.Seven2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Seven2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Eight1Clicked(object sender, EventArgs e)
        {
            c81 = 1;
            if (c82 == 0)
            {
                Zero();

                c81 = 1;
                this.Eight1Btn.Image = global::Puzzle_Matching.Properties.Resources.Avengers1;
            }
            else if (c81 == 1 && c82 == 1)
            {

                this.Eight1Btn.Visible = false;
                this.Eight2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Eight1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Eight2Clicked(object sender, EventArgs e)
        {
            c82 = 1;
            if (c81 == 0)
            {
                Zero();

                c82 = 1;
                this.Eight2Btn.Image = global::Puzzle_Matching.Properties.Resources.Avengers1;
            }
            else if (c81 == 1 && c82 == 1)
            {

                this.Eight1Btn.Visible = false;
                this.Eight2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Eight2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Nine1Clicked(object sender, EventArgs e)
        {
            c91 = 1;
            if (c92 == 0)
            {
                Zero();

                c91 = 1;
                this.Nine1Btn.Image = global::Puzzle_Matching.Properties.Resources.AntMan1;
            }
            else if (c91 == 1 && c92 == 1)
            {

                this.Nine1Btn.Visible = false;
                this.Nine2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Nine1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Nine2Clicked(object sender, EventArgs e)
        {
            c92 = 1;
            if (c91 == 0)
            {
                Zero();

                c92 = 1;
                this.Nine2Btn.Image = global::Puzzle_Matching.Properties.Resources.AntMan1;
            }
            else if (c91 == 1 && c92 == 1)
            {

                this.Nine1Btn.Visible = false;
                this.Nine2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Nine2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Ten1Clicked(object sender, EventArgs e)
        {
            c101 = 1;
            if (c102 == 0)
            {
                Zero();

                c101 = 1;
                this.Ten1Btn.Image = global::Puzzle_Matching.Properties.Resources.SpaceStone1;
            }
            else if (c101 == 1 && c102 == 1)
            {

                this.Ten1Btn.Visible = false;
                this.Ten2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Ten1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Ten2Clicked(object sender, EventArgs e)
        {
            c102 = 1;
            if (c101 == 0)
            {
                Zero();

                c102 = 1;
                this.Ten2Btn.Image = global::Puzzle_Matching.Properties.Resources.SpaceStone1;
            }
            else if (c101 == 1 && c102 == 1)
            {

                this.Ten1Btn.Visible = false;
                this.Ten2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Ten2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Eleven1Clicked(object sender, EventArgs e)
        {
            c111 = 1;
            if (c112 == 0)
            {
                Zero();

                c111 = 1;
                this.Eleven1Btn.Image = global::Puzzle_Matching.Properties.Resources.MindStone1;
            }
            else if (c111 == 1 && c112 == 1)
            {

                this.Eleven1Btn.Visible = false;
                this.Eleven2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Eleven1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Eleven2Clicked(object sender, EventArgs e)
        {
            c112 = 1;
            if (c111 == 0)
            {
                Zero();

                c112 = 1;
                this.Eleven2Btn.Image = global::Puzzle_Matching.Properties.Resources.MindStone1;
            }
            else if (c111 == 1 && c112 == 1)
            {

                this.Eleven1Btn.Visible = false;
                this.Eleven2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Eleven2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Twelve1Clicked(object sender, EventArgs e)
        {
            c121 = 1;
            if (c122 == 0)
            {
                Zero();

                c121 = 1;
                this.Twelve1Btn.Image = global::Puzzle_Matching.Properties.Resources.RealityStone1;
            }
            else if (c121 == 1 && c122 == 1)
            {

                this.Twelve1Btn.Visible = false;
                this.Twelve2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Twelve1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Twelve2Clicked(object sender, EventArgs e)
        {
            c122 = 1;
            if (c121 == 0)
            {
                Zero();

                c122 = 1;
                this.Twelve2Btn.Image = global::Puzzle_Matching.Properties.Resources.RealityStone1;
            }
            else if (c121 == 1 && c122 == 1)
            {

                this.Twelve1Btn.Visible = false;
                this.Twelve2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Twelve2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Thirteen1Clicked(object sender, EventArgs e)
        {
            c131 = 1;
            if (c132 == 0)
            {
                Zero();

                c131 = 1;
                this.Thirteen1Btn.Image = global::Puzzle_Matching.Properties.Resources.PowerStone1;
            }
            else if (c131 == 1 && c132 == 1)
            {

                this.Thirteen1Btn.Visible = false;
                this.Thirteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Thirteen1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Thirteen2Clicked(object sender, EventArgs e)
        {
            c132 = 1;
            if (c131 == 0)
            {
                Zero();

                c132 = 1;
                this.Thirteen2Btn.Image = global::Puzzle_Matching.Properties.Resources.PowerStone1;
            }
            else if (c131 == 1 && c132 == 1)
            {

                this.Thirteen1Btn.Visible = false;
                this.Thirteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Thirteen2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Forteen1Clicked(object sender, EventArgs e)
        {
            c141 = 1;
            if (c142 == 0)
            {
                Zero();

                c141 = 1;
                this.Forteen1Btn.Image = global::Puzzle_Matching.Properties.Resources.TimeStone1;
            }
            else if (c141 == 1 && c142 == 1)
            {

                this.Forteen1Btn.Visible = false;
                this.Forteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Forteen1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Forteen2Clicked(object sender, EventArgs e)
        {
            c142 = 1;
            if (c141 == 0)
            {
                Zero();

                c142 = 1;
                this.Forteen2Btn.Image = global::Puzzle_Matching.Properties.Resources.TimeStone1;
            }
            else if (c141 == 1 && c142 == 1)
            {

                this.Forteen1Btn.Visible = false;
                this.Forteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Fifteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Forteen2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Fifteen1Clicked(object sender, EventArgs e)
        {
            c151 = 1;
            if (c152 == 0)
            {
                Zero();

                c151 = 1;
                this.Fifteen1Btn.Image = global::Puzzle_Matching.Properties.Resources.SoulStone1;
            }
            else if (c151 == 1 && c152 == 1)
            {

                this.Fifteen1Btn.Visible = false;
                this.Fifteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Fifteen2Btn.Image = null;


            //this.Fifteen1Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
            //this.Fifteen2Btn.Enabled = true;
        }

        private void Fifteen2Clicked(object sender, EventArgs e)
        {
            c152 = 1;
            if (c151 == 0)
            {
                Zero();

                c152 = 1;
                this.Fifteen2Btn.Image = global::Puzzle_Matching.Properties.Resources.SoulStone1;
            }
            else if (c151 == 1 && c152 == 1)
            {

                this.Fifteen1Btn.Visible = false;
                this.Fifteen2Btn.Visible = false;
            }

            Score();

            

            this.One2Btn.Image = null;
            this.One1Btn.Image = null;
            this.Two2Btn.Image = null;
            this.Two1Btn.Image = null;
            this.Three2Btn.Image = null;
            this.Three1Btn.Image = null;
            this.Four2Btn.Image = null;
            this.Four1Btn.Image = null;
            this.Five2Btn.Image = null;
            this.Five1Btn.Image = null;
            this.Six2Btn.Image = null;
            this.Six1Btn.Image = null;
            this.Seven2Btn.Image = null;
            this.Seven1Btn.Image = null;
            this.Eight2Btn.Image = null;
            this.Eight1Btn.Image = null;
            this.Nine2Btn.Image = null;
            this.Nine1Btn.Image = null;
            this.Ten2Btn.Image = null;
            this.Ten1Btn.Image = null;
            this.Eleven2Btn.Image = null;
            this.Eleven1Btn.Image = null;
            this.Twelve2Btn.Image = null;
            this.Twelve1Btn.Image = null;
            this.Thirteen2Btn.Image = null;
            this.Thirteen1Btn.Image = null;
            this.Forteen2Btn.Image = null;
            this.Forteen1Btn.Image = null;
            this.Fifteen1Btn.Image = null;


            //this.Fifteen2Btn.Enabled = false;

            //this.One2Btn.Enabled = true;
            //this.Two1Btn.Enabled = true;
            //this.Two2Btn.Enabled = true;
            //this.Three1Btn.Enabled = true;
            //this.Three2Btn.Enabled = true;
            //this.Four1Btn.Enabled = true;
            //this.Four2Btn.Enabled = true;
            //this.Five1Btn.Enabled = true;
            //this.Five2Btn.Enabled = true;
            //this.Six1Btn.Enabled = true;
            //this.Six2Btn.Enabled = true;
            //this.Seven1Btn.Enabled = true;
            //this.Seven2Btn.Enabled = true;
            //this.Eight1Btn.Enabled = true;
            //this.Eight2Btn.Enabled = true;
            //this.Nine1Btn.Enabled = true;
            //this.Nine2Btn.Enabled = true;
            //this.Ten1Btn.Enabled = true;
            //this.Ten2Btn.Enabled = true;
            //this.Eleven1Btn.Enabled = true;
            //this.Eleven2Btn.Enabled = true;
            //this.Twelve1Btn.Enabled = true;
            //this.Twelve2Btn.Enabled = true;
            //this.Thirteen1Btn.Enabled = true;
            //this.Thirteen2Btn.Enabled = true;
            //this.Forteen1Btn.Enabled = true;
            //this.Forteen2Btn.Enabled = true;
            //this.Fifteen1Btn.Enabled = true;
            //this.One1Btn.Enabled = true;
        }

        public void Score()
        {
            //if (count1 == 2 && count2 == 2 && count3 == 2 && count4 == 2 && count5 == 2 && count6 == 2 && count7 == 2 && count8 == 2 && count9 == 2 && count10 == 2 && count11 == 2 && count12 == 2 && count13 == 2 && count14 == 2 && count15 == 2)
            //{
            //    this.BackColor = System.Drawing.Color.White;

            //    this.ScoreLabel.Visible = true;
            //}

            if (One1Btn.Visible == false && One2Btn.Visible == false && Two1Btn.Visible == false && Two2Btn.Visible == false && Three1Btn.Visible == false && Three2Btn.Visible == false && Four1Btn.Visible == false && Four2Btn.Visible == false && Five1Btn.Visible == false && Five2Btn.Visible == false && Six1Btn.Visible == false && Six2Btn.Visible == false && Seven1Btn.Visible == false && Seven2Btn.Visible == false && Eight1Btn.Visible == false && Eight2Btn.Visible == false && Nine1Btn.Visible == false && Nine2Btn.Visible == false && Ten1Btn.Visible == false && Ten2Btn.Visible == false && Eleven1Btn.Visible == false && Eleven2Btn.Visible == false && Twelve1Btn.Visible == false && Twelve2Btn.Visible == false && Thirteen1Btn.Visible == false && Thirteen2Btn.Visible == false && Forteen1Btn.Visible == false && Forteen2Btn.Visible == false && Fifteen1Btn.Visible == false && Fifteen2Btn.Visible == false)
            {
                //this.BackUpLabel.Visible = true;
                this.BackColor = System.Drawing.Color.White;
                this.ScoreLabel.Visible = true;
            }
        }


        public new void Location()
        {
            place = new Random();

            this.One2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.One1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Two2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Two1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Three2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Three1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Four2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Four1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Five2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Five1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Six2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Six1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Seven2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Seven1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Eight2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Eight1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Nine2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Nine1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Ten2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Ten1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Eleven2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Eleven1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Twelve2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Twelve1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Thirteen2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Thirteen1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Forteen2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Forteen1Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Fifteen2Btn.Location = new Point(place.Next(750), place.Next(450));
            this.Fifteen1Btn.Location = new Point(place.Next(750), place.Next(450));
        }

        public void Zero()
        {
            c11 = 0;
            c12 = 0;
            c21 = 0;
            c22 = 0;
            c31 = 0;
            c32 = 0;
            c41 = 0;
            c42 = 0;
            c51 = 0;
            c52 = 0;
            c61 = 0;
            c62 = 0;
            c71 = 0;
            c72 = 0;
            c81 = 0;
            c82 = 0;
            c91 = 0;
            c92 = 0;
            c101 = 0;
            c102 = 0;
            c111 = 0;
            c112 = 0;
            c121 = 0;
            c122 = 0;
            c131 = 0;
            c132 = 0;
            c141 = 0;
            c142 = 0;
            c151 = 0;
            c152 = 0;
        }

    }
}
