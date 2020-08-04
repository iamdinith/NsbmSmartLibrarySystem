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
    public partial class Form2 : Form
    {
        string accesscon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + @"C:\DINITH\NSBM\LMS\C#\NsbmSmartLibrarySystem\NSBM Smart Library System\nsbm\LibraryDatabase.mdb";
        public Form2()
        {
            InitializeComponent();
            viewData();
        }
        
        public void viewData()
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM Borrowed ORDER BY BorrowID DESC";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "Borrowed");
            dataGridView1.DataSource = set.Tables["Borrowed"];
            dataGridView1.ReadOnly = true;
      
            con.Close();
        }

        public void viewData2()
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM PositionData WHERE BookID = '" + bmftb.Text.ToString() + "'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "PositionData");
            dataGridView2.DataSource = set.Tables["PositionData"];
            dataGridView2.ReadOnly = true;

            /*string query2 = "SELECT Lent FROM Borrowed WHERE BookID = '" + bmftb.Text.ToString() + "'";

            OleDbDataAdapter adapt2 = new OleDbDataAdapter(query2, accesscon);
            DataSet set2 = new DataSet();

            adapt2.Fill(set2, "PositionData");
            dataGridView3.DataSource = set2.Tables["PositionData"];
            dataGridView3.ReadOnly = true;*/

            con.Close();
        }

        private void bgbtn_Click(object sender, EventArgs e)
        {
            viewData();
        }

        private void bmbrbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "DELETE * FROM Borrowed WHERE BookID = '" + bmbidtb.Text.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            String query2 = "UPDATE BookDetails SET Availability = 'In Library' WHERE BookID ='" + bmbidtb.Text.ToString() + "'";
            OleDbCommand cmd2 = new OleDbCommand(query2, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                bmbidtb.Clear();
                viewData();
                con.Close();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewData2();
        }

        private void bmlbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "UPDATE Borrowed SET Availability = 'Lent' WHERE BookID ='" + bmltb.Text.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            String query2 = "UPDATE BookDetails SET Availability = 'Lent' WHERE BookID ='" + bmltb.Text.ToString() + "'";
            OleDbCommand cmd2 = new OleDbCommand(query2, con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                viewData();
                viewData2();
                bmltb.Clear();
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
