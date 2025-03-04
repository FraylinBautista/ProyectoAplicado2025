﻿using SistemaReservaRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashManagementSystem
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 2;
            progressBar1.Value = start;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                FrmMenu menu = new FrmMenu();
                this.Hide();
                menu.ShowDialog();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

         
    }
}
