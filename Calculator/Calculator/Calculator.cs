using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private bool equal;
        private int hcount=0, fcount=0;
        private string fs;
        private double mr=0, res=0, re=0, po=0, sqr=0;
        private bool plus = false, minus = false, multi = false, div = false, power = false; /*root = false; /*dot = false;*/


        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "0";
        }

        private void OneClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "1";
        }

        private void TwoClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "2";
        }

        private void ThreeClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "3";
        }

        private void FourClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "4";
        }

        private void FiveClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "5";
        }

        private void SixClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "6";
        }

        private void SevenClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "7";
        }

        private void EightClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "8";
        }

        private void NineClicked(object sender, EventArgs e)
        {
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                equal = false;
            }
            if (this.ScreenRTB.Text.ToString() == "0")
            {
                this.ScreenRTB.Text = "";
            }
            this.ScreenRTB.Text += "9";
        }





        private void EqualClicked(object sender, EventArgs e)
        {
            try
            {
                if (equal == false)
                {
                    if (this.ScreenRTB.Text.Contains("+") || this.ScreenRTB.Text.Contains("-") || this.ScreenRTB.Text.Contains("*") || this.ScreenRTB.Text.Contains("/") || this.ScreenRTB.Text.Contains("^"))
                    {
                        int j = this.ScreenRTB.Text.Length;
                        string c = "", d = "";
                        for (int i = j - 1; i > 0; i--)
                        {
                            if (this.ScreenRTB.Text[i] == '+' || this.ScreenRTB.Text[i] == '-' || this.ScreenRTB.Text[i] == '*' || this.ScreenRTB.Text[i] == '/' || this.ScreenRTB.Text[i] == '^')
                            {
                                break;
                            }
                            else
                            {
                                c += this.ScreenRTB.Text[i];
                            }
                        }

                        j = c.Length;
                        for (int i = 0; i < j; i++)
                        {
                            d += c[j - 1 - i];
                        }

                        re = Convert.ToDouble(d);
                    }

                    equal = true;
                    if (power == true)
                    {
                        res = Math.Pow(po, re);
                    }
                    else
                    {
                        res = Convert.ToDouble(new DataTable().Compute(this.ScreenRTB.Text, null));
                    }
                    fs += ScreenRTB.Text + " = " + res.ToString() + "\r\n";
                    WriteFile(fs);
                    fcount++;
                    //this.ScreenRTB.Text = res.ToString() + re.ToString() + equal.ToString();
                    this.ScreenRTB.Text = res.ToString();
                }
                else
                {
                    if (this.ScreenRTB.Text.Contains("+") || this.ScreenRTB.Text.Contains("-") || this.ScreenRTB.Text.Contains("*") || this.ScreenRTB.Text.Contains("/") || this.ScreenRTB.Text.Contains("^"))
                    {
                        int j = this.ScreenRTB.Text.Length;
                        string c = "", d = "";
                        for (int i = j - 1; i > 0; i--)
                        {
                            if (this.ScreenRTB.Text[i] == '+' || this.ScreenRTB.Text[i] == '-' || this.ScreenRTB.Text[i] == '*' || this.ScreenRTB.Text[i] == '/' || this.ScreenRTB.Text[i] == '^')
                            {
                                break;
                            }
                            else
                            {
                                c += this.ScreenRTB.Text[i];
                            }
                        }

                        j = c.Length;
                        for (int i = 0; i < j; i++)
                        {
                            d += c[j - 1 - i];
                        }

                        re = Convert.ToDouble(d);
                    }

                    if (plus == true)
                    {
                        fs += res + " + " + re + " = ";
                        res = res + re;
                        fs += res + "\r\n";
                    }
                    else if (minus == true)
                    {
                        fs += res + " - " + re + " = ";
                        res = res - re;
                        fs += res + "\r\n";
                    }
                    else if (multi == true)
                    {
                        fs += res + " * " + re + " = ";
                        res = res * re;
                        fs += res + "\r\n";
                    }
                    else if (div == true)
                    {
                        fs += res + " / " + re + " = ";
                        res = res / re;
                        fs += res + "\r\n";
                    }
                    else if (power == true)
                    {
                        fs += res + " ^ " + re + " = ";
                        res = Math.Pow(po, re);
                        po = res;
                        fs += res + "\r\n";
                    }
                    
                    WriteFile(fs);
                    fcount++;
                    this.ScreenRTB.Text = res.ToString();
                    //this.ScreenRTB.Text = "YOLO";
                }

            }
            catch
            {
                this.ScreenRTB.Text = "Syntax Error / Math Error";
                WriteFile(fs + "\r\n" + ScreenRTB.Text + "\r\n");
                fcount++;
            }


        }


        private void PlusClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text += "+";
            SetFalse();
            plus = true;
        }

        private void MinusClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text += "-";
            SetFalse();
            minus = true;
        }

        private void MultiplicationClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text += "*";
            SetFalse();
            multi = true;
        }

        private void DivisionClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text += "/";
            SetFalse();
            div = true;
        }

        private void DotClicked(object sender, EventArgs e)
        {
            //if (dot == false)
            //{
            if (equal && !this.ScreenRTB.Text.Contains("+") && !this.ScreenRTB.Text.Contains("-") && !this.ScreenRTB.Text.Contains("*") && !this.ScreenRTB.Text.Contains("/") && !this.ScreenRTB.Text.Contains("^"))
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            if (equal && this.ScreenRTB.Text[0] == '-')
            {
                this.ScreenRTB.Text = "";
                equal = false;
            }
            this.ScreenRTB.Text += ".";
            //}
            //dot = true;
        }

        private void BackClicked(object sender, EventArgs e)
        {
            if (this.ScreenRTB.Text != "")
            {
                this.ScreenRTB.Text = this.ScreenRTB.Text.Remove(this.ScreenRTB.Text.Length - 1);
            }
        }

        private void CClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text = "0";
        }

        private void MRClicked(object sender, EventArgs e)
        {
            this.ScreenRTB.Text = mr.ToString();
        }

        private void MCClicked(object sender, EventArgs e)
        {
            mr = 0;
        }

        private void MMinusClicked(object sender, EventArgs e)
        {
            mr -= Convert.ToDouble(this.ScreenRTB.Text);
        }

        private void MPlusClicked(object sender, EventArgs e)
        {
            mr += Convert.ToDouble(this.ScreenRTB.Text);
        }

        private void HistoryClicked(object sender, EventArgs e)
        {
            if (hcount % 2 == 0)
            {
                hcount++;

                this.HistoryBoxLabel.Visible = true;

                this.OneBtn.Visible = false;
                this.TwoBtn.Visible = false;
                this.ThreeBtn.Visible = false;
                this.FourBtn.Visible = false;
                this.FiveBtn.Visible = false;
                this.SixBtn.Visible = false;
                this.SevenBtn.Visible = false;
                this.EightBtn.Visible = false;
                this.NineBtn.Visible = false;
                this.ZeroBtn.Visible = false;
                this.DotBtn.Visible = false;
                this.EqualBtn.Visible = false;
                this.PlusBtn.Visible = false;
                this.MinusBtn.Visible = false;
                this.MultiplicationBtn.Visible = false;
                this.DivisionBtn.Visible = false;
                this.RootBtn.Visible = false;
                this.PowerBtn.Visible = false;
                this.BackBtn.Visible = false;
                this.CBtn.Visible = false;
                this.MPlusLabel.Visible = false;
                this.MMinusLabel.Visible = false;
                this.MRLabel.Visible = false;
                this.MCLabel.Visible = false;
                this.ScreenRTB.Visible = false;

                this.HistoryBoxLabel.Text = ReadFile();
            }
            else
            {
                hcount++;

                this.HistoryBoxLabel.Visible = false;

                this.OneBtn.Visible = true;
                this.TwoBtn.Visible = true;
                this.ThreeBtn.Visible = true;
                this.FourBtn.Visible = true;
                this.FiveBtn.Visible = true;
                this.SixBtn.Visible = true;
                this.SevenBtn.Visible = true;
                this.EightBtn.Visible = true;
                this.NineBtn.Visible = true;
                this.ZeroBtn.Visible = true;
                this.DotBtn.Visible = true;
                this.EqualBtn.Visible = true;
                this.PlusBtn.Visible = true;
                this.MinusBtn.Visible = true;
                this.MultiplicationBtn.Visible = true;
                this.DivisionBtn.Visible = true;
                this.RootBtn.Visible = true;
                this.PowerBtn.Visible = true;
                this.BackBtn.Visible = true;
                this.CBtn.Visible = true;
                this.MPlusLabel.Visible = true;
                this.MMinusLabel.Visible = true;
                this.MRLabel.Visible = true;
                this.MCLabel.Visible = true;
                this.ScreenRTB.Visible = true;
            }
        }

        public void WriteFile(string filecontent)
        {
            try
            {
                StreamWriter file = new StreamWriter("File.txt");
                file.WriteLine(filecontent);
                file.Flush();
                file.Close();
            }
            catch
            {
                this.HistoryBoxLabel.Text = "Unavoidable Error.\nPlease close the Calculator";
                this.HistoryBoxLabel.Visible = true;
            }
        }

        public string ReadFile()
        {
            try
            {
                StreamReader file = new StreamReader("File.txt");
                string fl = file.ReadToEnd();
                return fl;
            }
            catch
            {
                this.HistoryBoxLabel.Text = "Unavoidable Error.\nPlease close the Calculator";
                this.HistoryBoxLabel.Visible = true;
                string fl = "Unavoidable Error.\nPlease close the Calculator";
                return fl;
            }
        }

        public void SetFalse()
        {
            plus = false;
            minus = false;
            multi = false;
            div = false;
            power = false;
        }

        private void PowerClicked(object sender, EventArgs e)
        {
            try
            {
                po = Convert.ToDouble(this.ScreenRTB.Text);
                this.ScreenRTB.Text += "^";
                SetFalse();
                power = true;
            }
            catch
            {
                this.ScreenRTB.Text = "Please Press the button C";
            }
        }

        private void RootClicked(object sender, EventArgs e)
        {
            sqr = Convert.ToDouble(this.ScreenRTB.Text);
            sqr = Math.Sqrt(sqr);
            fs += "Square Root of (" + this.ScreenRTB.Text + ") = " + sqr.ToString() + "\r\n";
            WriteFile(fs);
            fcount++;
            //this.ScreenRTB.Text = res.ToString() + re.ToString() + equal.ToString();
            this.ScreenRTB.Text = sqr.ToString();
        }
    }
}
