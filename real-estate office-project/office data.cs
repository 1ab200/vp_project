using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace real_estate_office_project
{
    public partial class office_data : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
        private OleDbConnection con;
        public office_data()
        {
            con = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void office_data_Load(object sender, EventArgs e)
        {
            updatestudentsgird();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Insertstudent(txtOfficeName.Text, txtAddress.Text, txtPhoneNumber.Text, txtTaxNumber.Text, txtNameOfTheOfficeHolder.Text);
            ClearForm();
            updatestudentsgird();
        }
        private void updatestudentsgird()
        {
            OleDbCommand command = new OleDbCommand("select * from Settings", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Insertstudent(string OfficeName, string Address, string PhoneNumber, string TaxNumber, string NameOfTheOfficeHolder)
        {
            string insertCommand = $"Insert Into Settings([OfficeName],[Address],[PhoneNumber],[TaxNumber],[OwnerName]) values('{OfficeName}','{Address}','{PhoneNumber}','{TaxNumber}','{NameOfTheOfficeHolder}')";


            OleDbCommand command = new OleDbCommand(insertCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();
        }
        private void ClearForm()
        {
            txtAddress.Text = "";
            txtNameOfTheOfficeHolder.Text = "";
            txtOfficeName.Text = "";
            txtPhoneNumber.Text = "";
            txtTaxNumber.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Settings where id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم المسح");
        }
    }
}
