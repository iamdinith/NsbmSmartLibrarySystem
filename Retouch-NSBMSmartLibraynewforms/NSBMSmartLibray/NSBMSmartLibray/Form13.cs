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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            panel16.BackColor = Color.FromArgb(150, 0, 13, 250);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            panel17.BackColor = Color.FromArgb(150, 0, 130, 50);
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
