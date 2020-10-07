using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//using WMPLib;

namespace Fool_Game
{
    public partial class Fool : Form
    {
        SoundPlayer yesPlayer = new SoundPlayer();
        SoundPlayer noPlayer = new SoundPlayer();
        public Fool()
        {
            InitializeComponent();
        }

        private void MouseEntered(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(500);
            int y = r.Next(450);
            NoBtn.Location = new Point(x, y);
        }

        private void YesClicked(object sender, EventArgs e)
        {
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            FoolLabel.Visible = false;
            NoLabel.Visible = false;
            StartAgainLabel.Visible = true;
            YesLabel.Visible = true;
            YesFoolLabel.Visible = true;
            NoFoolLabel.Visible = false;


            for (int i = 0; i < 10; i++)
            {
                yesPlayer = new SoundPlayer(global::Fool_Game.Sound.YesSound);
                yesPlayer.Play();
            }

            /*WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"F:\Study\Codes\6th Sem Mohaimen Sir - C#\C#\Fool Game\Fool GameNoSound.wav";
            wplayer.controls.play();*/
        }

        private void StartAgainClicked(object sender, EventArgs e)
        {
            YesBtn.Visible = true;
            NoBtn.Visible = true;
            FoolLabel.Visible = true;
            YesLabel.Visible = false;
            NoLabel.Visible = false;
            StartAgainLabel.Visible = false;
            YesFoolLabel.Visible = false;
            NoFoolLabel.Visible = false;
            yesPlayer.Stop();
            noPlayer.Stop();
        }

        private void NoClicked(object sender, EventArgs e)
        {
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            FoolLabel.Visible = false;
            NoLabel.Visible = true;
            StartAgainLabel.Visible = true;
            YesLabel.Visible = false;
            NoFoolLabel.Visible = true;
            YesFoolLabel.Visible = false;


            for (int i = 0; i < 10; i++)
            {
                noPlayer = new SoundPlayer(global::Fool_Game.Sound.NoSound);
                noPlayer.Play();
            }
            
        }


    }
}
