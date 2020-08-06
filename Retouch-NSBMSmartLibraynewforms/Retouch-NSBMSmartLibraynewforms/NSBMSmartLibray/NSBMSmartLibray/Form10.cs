﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBMSmartLibray
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            panel16.BackColor = Color.FromArgb(150, 242, 38, 19);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            panel17.BackColor = Color.FromArgb(150, 0, 13, 250);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }
    }
}
