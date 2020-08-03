using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nsbm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            Visible = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Form7 openForm = new Form7();
            openForm.Show();
            Visible = false;
        }
    }
}
