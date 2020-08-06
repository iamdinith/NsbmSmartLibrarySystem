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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(150, 0, 13, 250);
            
        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(150, 0, 210, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void Continuebutton_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }
    }
}
