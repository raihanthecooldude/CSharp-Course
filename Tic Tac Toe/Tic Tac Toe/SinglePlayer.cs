using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class SinglePlayer : Form
    {
        Random r = new Random();

        private bool c = false;
        private bool rs = false;

        private bool one = false;
        private bool two = false;
        private bool three = false;
        private bool four = false;
        private bool five = false;
        private bool six = false;
        private bool seven = false;
        private bool eight = false;
        private bool nine = false;

        int count = 0;
        int clickCount = 0;

        public SinglePlayer()
        {
            InitializeComponent();
        }

        private void OneClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalOneBtn.Visible = false;
            CrossOneBtn.Visible = true;
            one = true;
            //if (count < 4 && rs == false)
            if(rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void TwoClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalTwoBtn.Visible = false;
            CrossTwoBtn.Visible = true;
            two = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void ThreeClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalThreeBtn.Visible = false;
            CrossThreeBtn.Visible = true;
            three = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void FourClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalFourBtn.Visible = false;
            CrossFourBtn.Visible = true;
            four = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void FiveClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalFiveBtn.Visible = false;
            CrossFiveBtn.Visible = true;
            five = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void SixClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalSixBtn.Visible = false;
            CrossSixBtn.Visible = true;
            six = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void SevenClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalSevenBtn.Visible = false;
            CrossSevenBtn.Visible = true;
            seven = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void EightClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalEightBtn.Visible = false;
            CrossEightBtn.Visible = true;
            eight = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void NineClicked(object sender, EventArgs e)
        {
            clickCount++;
            rs = Result();
            NormalNineBtn.Visible = false;
            CrossNineBtn.Visible = true;
            nine = true;
            //if (count < 4 && rs == false)
            if (rs == false)
            {
                Circle(rs);
            }
            count++;
        }

        private void Circle(bool res)
        {
            if (!res)
            {
                int x;
                c = false;

                while (c == false)
                {
                    x = r.Next(9);

                    if (x == 1)
                    {
                        if (one == false)
                        {
                            NormalOneBtn.Visible = false;
                            CircleOneBtn.Visible = true;
                            c = true;
                            one = true;
                        }
                    }
                    else if (x == 2)
                    {
                        if (two == false)
                        {
                            NormalTwoBtn.Visible = false;
                            CircleTwoBtn.Visible = true;
                            c = true;
                            two = true;
                        }
                    }
                    else if (x == 3)
                    {
                        if (three == false)
                        {
                            NormalThreeBtn.Visible = false;
                            CircleThreeBtn.Visible = true;
                            c = true;
                            three = true;
                        }
                    }
                    else if (x == 4)
                    {
                        if (four == false)
                        {
                            NormalFourBtn.Visible = false;
                            CircleFourBtn.Visible = true;
                            c = true;
                            four = true;
                        }
                    }
                    else if (x == 5)
                    {
                        if (five == false)
                        {
                            NormalFiveBtn.Visible = false;
                            CircleFiveBtn.Visible = true;
                            c = true;
                            five = true;
                        }
                    }
                    else if (x == 6)
                    {
                        if (six == false)
                        {
                            NormalSixBtn.Visible = false;
                            CircleSixBtn.Visible = true;
                            c = true;
                            six = true;
                        }
                    }
                    else if (x == 7)
                    {
                        if (seven == false)
                        {
                            NormalSevenBtn.Visible = false;
                            CircleSevenBtn.Visible = true;
                            c = true;
                            seven = true;
                        }
                    }
                    else if (x == 8)
                    {
                        if (eight == false)
                        {
                            NormalEightBtn.Visible = false;
                            CircleEightBtn.Visible = true;
                            c = true;
                            eight = true;
                        }
                    }
                    else if (x == 9)
                    {
                        if (nine == false)
                        {
                            NormalNineBtn.Visible = false;
                            CircleNineBtn.Visible = true;
                            c = true;
                            nine = true;
                        }
                    }

                    DemoLabel.Text = x + " " + count + "\n";
                }

                clickCount++;
                rs = Result();
            }
        }

        public bool Result()
        {
            if ((CrossOneBtn.Visible == true && CrossTwoBtn.Visible == true && CrossThreeBtn.Visible == true) || (CrossFourBtn.Visible == true && CrossFiveBtn.Visible == true && CrossSixBtn.Visible == true) || (CrossSevenBtn.Visible == true && CrossEightBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossOneBtn.Visible == true && CrossFourBtn.Visible == true && CrossSevenBtn.Visible == true) || (CrossTwoBtn.Visible == true && CrossFiveBtn.Visible == true && CrossEightBtn.Visible == true) || (CrossThreeBtn.Visible == true && CrossSixBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossOneBtn.Visible == true && CrossFiveBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossThreeBtn.Visible == true && CrossFiveBtn.Visible == true && CrossSevenBtn.Visible == true))
            {
                ResultLabel.Text = "You Won!";
                rs = true;

                NormalOneBtn.Enabled = false;
                NormalTwoBtn.Enabled = false;
                NormalThreeBtn.Enabled = false;
                NormalFourBtn.Enabled = false;
                NormalFiveBtn.Enabled = false;
                NormalSixBtn.Enabled = false;
                NormalSevenBtn.Enabled = false;
                NormalEightBtn.Enabled = false;
                NormalNineBtn.Enabled = false;
                CrossOneBtn.Enabled = false;
                CrossTwoBtn.Enabled = false;
                CrossThreeBtn.Enabled = false;
                CrossFourBtn.Enabled = false;
                CrossFiveBtn.Enabled = false;
                CrossSixBtn.Enabled = false;
                CrossSevenBtn.Enabled = false;
                CrossEightBtn.Enabled = false;
                CrossNineBtn.Enabled = false;
                CircleOneBtn.Enabled = false;
                CircleTwoBtn.Enabled = false;
                CircleThreeBtn.Enabled = false;
                CircleFourBtn.Enabled = false;
                CircleFiveBtn.Enabled = false;
                CircleSixBtn.Enabled = false;
                CircleSevenBtn.Enabled = false;
                CircleEightBtn.Enabled = false;
                CircleNineBtn.Enabled = false; 
            }
            else if ((CircleOneBtn.Visible == true && CircleTwoBtn.Visible == true && CircleThreeBtn.Visible == true) || (CircleFourBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSixBtn.Visible == true) || (CircleSevenBtn.Visible == true && CircleEightBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFourBtn.Visible == true && CircleSevenBtn.Visible == true) || (CircleTwoBtn.Visible == true && CircleFiveBtn.Visible == true && CircleEightBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleSixBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFiveBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSevenBtn.Visible == true))
            {
                ResultLabel.Text = "Computer Won!";
                rs = true;

                NormalOneBtn.Enabled = false;
                NormalTwoBtn.Enabled = false;
                NormalThreeBtn.Enabled = false;
                NormalFourBtn.Enabled = false;
                NormalFiveBtn.Enabled = false;
                NormalSixBtn.Enabled = false;
                NormalSevenBtn.Enabled = false;
                NormalEightBtn.Enabled = false;
                NormalNineBtn.Enabled = false;
                CrossOneBtn.Enabled = false;
                CrossTwoBtn.Enabled = false;
                CrossThreeBtn.Enabled = false;
                CrossFourBtn.Enabled = false;
                CrossFiveBtn.Enabled = false;
                CrossSixBtn.Enabled = false;
                CrossSevenBtn.Enabled = false;
                CrossEightBtn.Enabled = false;
                CrossNineBtn.Enabled = false;
                CircleOneBtn.Enabled = false;
                CircleTwoBtn.Enabled = false;
                CircleThreeBtn.Enabled = false;
                CircleFourBtn.Enabled = false;
                CircleFiveBtn.Enabled = false;
                CircleSixBtn.Enabled = false;
                CircleSevenBtn.Enabled = false;
                CircleEightBtn.Enabled = false;
                CircleNineBtn.Enabled = false;
            }
            else
            {
                if (clickCount == 9)
                {
                    if ((CrossOneBtn.Visible == true && CrossTwoBtn.Visible == true && CrossThreeBtn.Visible == true) || (CrossFourBtn.Visible == true && CrossFiveBtn.Visible == true && CrossSixBtn.Visible == true) || (CrossSevenBtn.Visible == true && CrossEightBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossOneBtn.Visible == true && CrossFourBtn.Visible == true && CrossSevenBtn.Visible == true) || (CrossTwoBtn.Visible == true && CrossFiveBtn.Visible == true && CrossEightBtn.Visible == true) || (CrossThreeBtn.Visible == true && CrossSixBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossOneBtn.Visible == true && CrossFiveBtn.Visible == true && CrossNineBtn.Visible == true) || (CrossThreeBtn.Visible == true && CrossFiveBtn.Visible == true && CrossSevenBtn.Visible == true))
                    {
                        ResultLabel.Text = "You Won!";
                        rs = true;

                        NormalOneBtn.Enabled = false;
                        NormalTwoBtn.Enabled = false;
                        NormalThreeBtn.Enabled = false;
                        NormalFourBtn.Enabled = false;
                        NormalFiveBtn.Enabled = false;
                        NormalSixBtn.Enabled = false;
                        NormalSevenBtn.Enabled = false;
                        NormalEightBtn.Enabled = false;
                        NormalNineBtn.Enabled = false;
                        CrossOneBtn.Enabled = false;
                        CrossTwoBtn.Enabled = false;
                        CrossThreeBtn.Enabled = false;
                        CrossFourBtn.Enabled = false;
                        CrossFiveBtn.Enabled = false;
                        CrossSixBtn.Enabled = false;
                        CrossSevenBtn.Enabled = false;
                        CrossEightBtn.Enabled = false;
                        CrossNineBtn.Enabled = false;
                        CircleOneBtn.Enabled = false;
                        CircleTwoBtn.Enabled = false;
                        CircleThreeBtn.Enabled = false;
                        CircleFourBtn.Enabled = false;
                        CircleFiveBtn.Enabled = false;
                        CircleSixBtn.Enabled = false;
                        CircleSevenBtn.Enabled = false;
                        CircleEightBtn.Enabled = false;
                        CircleNineBtn.Enabled = false;
                    }
                    else if ((CircleOneBtn.Visible == true && CircleTwoBtn.Visible == true && CircleThreeBtn.Visible == true) || (CircleFourBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSixBtn.Visible == true) || (CircleSevenBtn.Visible == true && CircleEightBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFourBtn.Visible == true && CircleSevenBtn.Visible == true) || (CircleTwoBtn.Visible == true && CircleFiveBtn.Visible == true && CircleEightBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleSixBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFiveBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSevenBtn.Visible == true))
                    {
                        ResultLabel.Text = "Computer Won!";
                        rs = true;

                        NormalOneBtn.Enabled = false;
                        NormalTwoBtn.Enabled = false;
                        NormalThreeBtn.Enabled = false;
                        NormalFourBtn.Enabled = false;
                        NormalFiveBtn.Enabled = false;
                        NormalSixBtn.Enabled = false;
                        NormalSevenBtn.Enabled = false;
                        NormalEightBtn.Enabled = false;
                        NormalNineBtn.Enabled = false;
                        CrossOneBtn.Enabled = false;
                        CrossTwoBtn.Enabled = false;
                        CrossThreeBtn.Enabled = false;
                        CrossFourBtn.Enabled = false;
                        CrossFiveBtn.Enabled = false;
                        CrossSixBtn.Enabled = false;
                        CrossSevenBtn.Enabled = false;
                        CrossEightBtn.Enabled = false;
                        CrossNineBtn.Enabled = false;
                        CircleOneBtn.Enabled = false;
                        CircleTwoBtn.Enabled = false;
                        CircleThreeBtn.Enabled = false;
                        CircleFourBtn.Enabled = false;
                        CircleFiveBtn.Enabled = false;
                        CircleSixBtn.Enabled = false;
                        CircleSevenBtn.Enabled = false;
                        CircleEightBtn.Enabled = false;
                        CircleNineBtn.Enabled = false;
                    }
                    //else if ((CircleOneBtn.Visible == false && CircleTwoBtn.Visible == true && CircleThreeBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleTwoBtn.Visible == false && CircleThreeBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleTwoBtn.Visible == true && CircleThreeBtn.Visible == false) || (CircleFourBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSixBtn.Visible == true) || (CircleFourBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSixBtn.Visible == true) || (CircleFourBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSixBtn.Visible == true) || (CircleSevenBtn.Visible == true && CircleEightBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFourBtn.Visible == true && CircleSevenBtn.Visible == true) || (CircleTwoBtn.Visible == true && CircleFiveBtn.Visible == true && CircleEightBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleSixBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleOneBtn.Visible == true && CircleFiveBtn.Visible == true && CircleNineBtn.Visible == true) || (CircleThreeBtn.Visible == true && CircleFiveBtn.Visible == true && CircleSevenBtn.Visible == true))
                    else
                    {
                        ResultLabel.Text = "Match Draw.";
                        rs = true;

                        NormalOneBtn.Enabled = false;
                        NormalTwoBtn.Enabled = false;
                        NormalThreeBtn.Enabled = false;
                        NormalFourBtn.Enabled = false;
                        NormalFiveBtn.Enabled = false;
                        NormalSixBtn.Enabled = false;
                        NormalSevenBtn.Enabled = false;
                        NormalEightBtn.Enabled = false;
                        NormalNineBtn.Enabled = false;
                        CrossOneBtn.Enabled = false;
                        CrossTwoBtn.Enabled = false;
                        CrossThreeBtn.Enabled = false;
                        CrossFourBtn.Enabled = false;
                        CrossFiveBtn.Enabled = false;
                        CrossSixBtn.Enabled = false;
                        CrossSevenBtn.Enabled = false;
                        CrossEightBtn.Enabled = false;
                        CrossNineBtn.Enabled = false;
                        CircleOneBtn.Enabled = false;
                        CircleTwoBtn.Enabled = false;
                        CircleThreeBtn.Enabled = false;
                        CircleFourBtn.Enabled = false;
                        CircleFiveBtn.Enabled = false;
                        CircleSixBtn.Enabled = false;
                        CircleSevenBtn.Enabled = false;
                        CircleEightBtn.Enabled = false;
                        CircleNineBtn.Enabled = false;
                    }
                }
            }

            return rs;
        }

        private void CloseClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartClicked(object sender, EventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.Show();
            this.Hide();
        }

        private void BackClicked(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }

    }
}
