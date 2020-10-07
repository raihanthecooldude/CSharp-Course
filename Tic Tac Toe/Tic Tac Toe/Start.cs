﻿using System;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartImageClicked(object sender, EventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.Show();
            this.Hide();
        }

        private void StartClicked(object sender, EventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
