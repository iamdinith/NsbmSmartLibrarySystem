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
    public partial class Form5 : Form
    {
        string accesscon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + @"C:\DINITH\NSBM\LMS\C#\NsbmSmartLibrarySystem\NSBM Smart Library System\nsbm\LibraryDatabase.mdb";

        public Form5()
        {
            InitializeComponent();
        }



        private void abbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "INSERT INTO BookDetails([BookTitle],[BookAuthor],[Section]) VALUES ('" + abttb.Text + "','" + abatb.Text + "','" + abscb.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                abttb.Clear();
                abatb.Clear();
              
                con.Close();
            }
        }

        private void ubdbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "UPDATE BookDetails SET " + ubdccb.Text.ToString() + " = '" + ubdttb.Text.ToString() + "' WHERE " + ubdccb.Text.ToString() + " = '" + ubdftb.Text.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                ubdttb.Clear();
                ubdftb.Clear();
                con.Close();
            }
        }

        private void dbbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            string query = "DELETE * FROM BookDetails WHERE BookID = " + dbbidtb.Text + "";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                dbbidtb.Clear();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.ShowDialog();
            Visible = false;
        }
    }
}

