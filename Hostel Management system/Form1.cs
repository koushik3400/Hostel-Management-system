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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="ssn" && guna2TextBox1.Text=="ssn")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else 
            {
                guna2TextBox1.Clear();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox1.UseSystemPasswordChar = false;

            }
            else
            {
                guna2TextBox1.UseSystemPasswordChar = true;

            }
        }
    }
}
