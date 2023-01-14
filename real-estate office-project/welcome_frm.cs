using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate_office_project
{
    public partial class welcome_frm : Form
    {
        public welcome_frm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_frm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer2.Interval = 40;
            timer3.Interval = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if(this.Opacity==1)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cpbar.Increment(1);
            if(cpbar.Value==100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if(this.Opacity==0)
            {
                timer3.Stop();
                this.Hide();
                Main_frm f3 = new Main_frm();
                f3.ShowDialog();
            }
        }
    }
}
