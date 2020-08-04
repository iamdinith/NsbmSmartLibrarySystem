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

        private void Translation_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
            Visible = false;
        }

        private void Novels_Click(object sender, EventArgs e)
        {
            Form11 openForm = new Form11();
            openForm.Show();
            Visible = false;
        }

        private void ShortStories_Click(object sender, EventArgs e)
        {
            Form12 openForm = new Form12();
            openForm.Show();
            Visible = false;
        }

        private void Business_Click(object sender, EventArgs e)
        {
            Form13 openForm = new Form13();
            openForm.Show();
            Visible = false;
        }

        private void Biography_Click(object sender, EventArgs e)
        {
            Form14 openForm = new Form14();
            openForm.Show();
            Visible = false;
        }

        private void Poetry_Click(object sender, EventArgs e)
        {
            Form15 openForm = new Form15();
            openForm.Show();
            Visible = false;
        }

        private void Sciencebutton_Click(object sender, EventArgs e)
        {
            Form16 openForm = new Form16();
            openForm.Show();
            Visible = false;
        }

        private void Computers_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17();
            openForm.Show();
            Visible = false;
        }

        private void Mathbutton_Click(object sender, EventArgs e)
        {
            Form18 openForm = new Form18();
            openForm.Show();
            Visible = false;
        }

        private void Various_Click(object sender, EventArgs e)
        {
            Form19 openForm = new Form19();
            openForm.Show();
            Visible = false;
        }
    }
}
