using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StudentsLeft sl = new StudentsLeft();
            sl.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LivingStatus ls = new LivingStatus();
            ls.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }
        Boolean lableVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lableVisible==true)
            {
                label1.Visible = true;
                lableVisible = false;
            }
            else
            {
                label1.Visible = false;
                lableVisible = true;

            }

        }
    }
}
