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

namespace Library_Management_System
{
    public partial class Form3 : Form
    {
        string accesscon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + @"C:\DINITH\NSBM\LMS\C#\Library Management System\LibraryDatabase.mdb";
        public Form3()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM BookDetails  WHERE " + sbcb.Text.ToString() +" LIKE '%"+sbstb.Text.ToString()+"%'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "BookDetails");
            dataGridView3.DataSource = set.Tables["BookDetails"];
            dataGridView3.ReadOnly = true;

            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
