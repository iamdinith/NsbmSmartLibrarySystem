using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(150, 0, 210, 10);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            panel15.BackColor = Color.FromArgb(150, 0, 120, 10);
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            panel20.BackColor = Color.FromArgb(150, 50, 120, 10);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            panel13.BackColor = Color.FromArgb(150, 0, 13, 250);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            panel19.BackColor = Color.FromArgb(150, 0, 13, 150);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            panel17.BackColor = Color.FromArgb(150, 50, 130, 210);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            panel14.BackColor = Color.FromArgb(150, 242, 38, 19);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            panel21.BackColor = Color.FromArgb(150, 242, 138, 129);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            panel18.BackColor = Color.FromArgb(150, 242, 38, 190);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            panel16.BackColor = Color.FromArgb(150, 242, 198, 159);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 openForm = new Form7();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 openForm = new Form8();
            openForm.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 openForm = new Form9();
            openForm.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 openForm = new Form10();
            openForm.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 openForm = new Form11();
            openForm.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form12 openForm = new Form12();
            openForm.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 openForm = new Form13();
            openForm.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 openForm = new Form14();
            openForm.Show();
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form15 openForm = new Form15();
            openForm.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form16 openForm = new Form16();
            openForm.Show();
            Visible = false;
        }
    }
}
