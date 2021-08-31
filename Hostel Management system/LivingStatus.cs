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
    public partial class LivingStatus : Form
    {
        Function fn = new Function();
        string query;
        public LivingStatus()
        {
            InitializeComponent();
        }

        private void LivingStatus_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select *from newStudent where living='Yes'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
