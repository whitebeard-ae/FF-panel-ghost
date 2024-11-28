﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using FXX;

namespace External
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }
        public static api KeyAuthApp = new api(
      name: "Ptgamers911's Application",
      ownerid: "NUxTcZueiN", 
      secret: "03743d0340a9ac68579ca8bd1a5a6073d83578e233f28cf4e5abd183c7c06c50",
      version: "1.0");

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.6;
            Particles.Setup(this, 60, Color.Blue, 90, Color.Red);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(user.Text, pass.Text);
            if (KeyAuthApp.response.success)
            {
                timer1.Start();
            }
            else
            {
                sta.Text = KeyAuthApp.response.message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.guna2ProgressBar1.Increment(35);
            if (guna2ProgressBar1.Value >= guna2ProgressBar1.Maximum)
            {
                FXMAIN HM = new FXMAIN();
                HM.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Particles._Instance.Invalidate();
            Particles.MoveCircles(Particles._Particles);
        }
    }
}
