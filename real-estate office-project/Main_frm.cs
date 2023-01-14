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
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pSetting.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pRealEstates.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pClients.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pRentContract.BringToFront();
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            Form Userchange = new User_change();
            Userchange.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form officedata = new office_data();
            officedata.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form Buildingsdata = new Buildings_data();
            Buildingsdata.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pSetting.BringToFront();

        }

        private void pRealEstates_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand("select * from Realestatedata", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pClients_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand("select * from Clients", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void pRentContract_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand("select * from RentContract", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string b1 = txtB1.Text;
            string b2 = txtB2.Text;
            string b3 = txtB3.Text;
            string b4 = txtB4.Text;
            string b5 = txtB5.Text;
            string b6 = txtB6.Text;
            string b7 = txtB7.Text;
            string b8 = txtB8.Text;
            string b9 = txtB9.Text;

            string insertCommand = $"Insert Into Realestatedata([NameOfTheBuildingOrPlot],[BuildingCode],[PropertyCode],[DescriptionOfTheProperty],[Address],[eliminate],[DistrictOrRegion],[TheTypeOfProperty],[TheConditionOfTheProperty]) values('{b1}','{b2}','{b3}','{b4}','{b5}','{b6}','{b7}','{b8}','{b9}')";
            OleDbCommand command = new OleDbCommand(insertCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();

            txtB1.Text = "";
            txtB2.Text = "";
            txtB3.Text = "";
            txtB4.Text = "";
            txtB5.Text = "";
            txtB6.Text = "";
            txtB7.Text = "";
            txtB8.Text = "";
            txtB9.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string d1 = txtD1.Text;
            string d2 = txtD2.Text;
            string d3 = txtD3.Text;
            string d4 = txtD4.Text;
            string d5 = txtD5.Text;
            string d6 = txtD6.Text;
            string d7 = txtD7.Text;
            string d8 = txtD8.Text;
            string d9 = txtD9.Text;

            string insertCommand = $"Insert Into Clients([AgentCode],[CustomerName],[PhoneNumber],[IDNumber],[ComingFrom],[OnTheDate],[PositionAndItsAddress],[Nationality],[Email]) values('{d1}','{d2}','{d3}','{d4}','{d5}','{d6}','{d7}','{d8}','{d9}')";
            OleDbCommand command = new OleDbCommand(insertCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();

            txtD1.Text = "";
            txtD2.Text = "";
            txtD3.Text = "";
            txtD4.Text = "";
            txtD5.Text = "";
            txtD6.Text = "";
            txtD7.Text = "";
            txtD8.Text = "";
            txtD9.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            string s3 = txtS3.Text;
            string s4 = txtS4.Text;
            string s5 = txtS5.Text;
            string s6 = txtS6.Text;
            string s7 = txtS7.Text;
            string s8 = txtS8.Text;
            string s9 = txtS9.Text;
            string s10 = txtS10.Text;
            string s11 = txtS11.Text;
            string s12 = txtS12.Text;
            string s13 = txtS13.Text;
            string s14 = txtS14.Text;
            string s15 = txtS15.Text;
            string s16 = txtS16.Text;

            string insertCommand = $"Insert Into RentContract([اسم المكتب],[رقم الهاتف],[اسم صاحب المكتب],[العنوان],[اسم صاحب الدار],[اسم المستأجر],[تسلسل العقار],[نوع العقار],[مساحة العقار],[موقع الاجار],[رقم العقار],[مدة الاجار],[اعتبارا من],[لغاية],[الاجار السنوي قدره],[الاجار الشهري قدره]) values('{s1}','{s2}','{s3}','{s4}','{s5}','{s6}','{s7}','{s8}','{s9}','{s10}','{s11}','{s12}','{s13}','{s14}','{s15}','{s16}')";
            OleDbCommand command = new OleDbCommand(insertCommand, con);

            con.Open();

            command.ExecuteNonQuery();
          
            con.Close();

            txtS1.Text="";
            txtS2.Text="";
            txtS3.Text="";
            txtS4.Text="";
            txtS5.Text="";
            txtS6.Text="";
            txtS7.Text="";
            txtS8.Text="";
            txtS9.Text = "";
            txtS10.Text="";
            txtS11.Text="";
            txtS12.Text="";
            txtS13.Text="";
            txtS14.Text="";
            txtS15.Text="";
            txtS16.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string s17 = txts17.Text;

            con.Open();

            try
            {
                string F1 = $"DELETE FROM RentContract WHERE ID ={s17}";
                OleDbCommand cmd = new OleDbCommand(F1, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txts17.Text = "";
            }
            catch (Exception en)
            {
                MessageBox.Show("قاعدة البيانات فراغة او لم تق بملئ البيانات بشكل صحيح");
            }

            

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txts17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string D10 = txtD10.Text;

            con.Open();
            try
            {
                string F1 = $"DELETE FROM Clients WHERE ID ={D10}";
                OleDbCommand cmd = new OleDbCommand(F1, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtD10.Text = "";
            }catch(Exception en)
            {
                MessageBox.Show("قاعدة البيانات فراغة او لم تق بملئ البيانات بشكل صحيح");
            }
            
            

        }

        private void txtD10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=شركة عقارات.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string B10 = txtB10.Text;

            con.Open();

            try
            {
                string F1 = $"DELETE FROM Realestatedata WHERE ID ={B10}";
                OleDbCommand cmd = new OleDbCommand(F1, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtD10.Text = "";
            }
            catch (Exception en)
            {
                MessageBox.Show("قاعدة البيانات فراغة او لم تق بملئ البيانات بشكل صحيح");
            }
           
        }
    }
}
