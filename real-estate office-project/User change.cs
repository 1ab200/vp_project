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
    public partial class User_change : Form
    {
        public User_change()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string txt = txtusername.Text + "@" + txtpassword.Text;
            File.WriteAllText("user.txt", txt);
            MessageBox.Show("تم تغير اسم المستخدم وكلمة المرور بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
