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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
 




        private void button2_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
