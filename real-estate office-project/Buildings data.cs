using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate_office_project
{
    public partial class Buildings_data : Form
    {
        public Buildings_data()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Buildings_data_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand("select * from Buildingsdata", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string a1 = txtA1.Text;
            string a2 = txtA2.Text;
            string a3 = txtA3.Text;
            string a4 = txtA4.Text;
            string a5 = txtA5.Text;
            string a6 = txtA6.Text;

            string insertCommand = $"Insert Into Buildingsdata([BuildingOrLotNumber],[NameOfTheBuildingOrPiece],[Address],[eliminate],[Region],[Notes]) values('{a1}','{a2}','{a3}','{a4}','{a5}','{a6}')";
            OleDbCommand command = new OleDbCommand(insertCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();

            txtA1.Text = "";
            txtA2.Text = "";
            txtA3.Text = "";
            txtA4.Text = "";
            txtA5.Text = "";
            txtA6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string A10 = txtA10.Text;

            con.Open();

            try
            {
                string F1 = $"DELETE FROM Buildingsdata WHERE ID ={A10}";
                OleDbCommand cmd = new OleDbCommand(F1, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtA10.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("قاعدة البيانات فراغة او لم تق بملئ البيانات بشكل صحيح");
            }
        }

       
    }
}
