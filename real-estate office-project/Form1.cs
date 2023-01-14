using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate_office_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
       
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string text = File.ReadAllText("user.txt");//admin@admin
            string[] str = text.Split('@');
            string username = str[0];//admin
            string password = str[1];//admin
            if(txtusername.Text==username && txtpassword.Text==password)
            {
                Form frmMain = new welcome_frm ();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("اسم المستخم او رمز دخول غير صحيح", "خطأ في الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
