using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NSBMSmartLibray
{
    public partial class Form17 : Form
    {
        string accesscon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + @"C:\DINITH\NSBM\LMS\C#\NsbmSmartLibrarySystem\Dileka\Library1.mdb";
        public Form17(string category)
        {
            InitializeComponent();
            string name = category;
            textBox1.Text = category;
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM Books WHERE B_Category = '" + category + "'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "Books");
            dataGridView1.DataSource = set.Tables["Books"];
            dataGridView1.ReadOnly = true;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            Visible = false;
        }
    }
}
