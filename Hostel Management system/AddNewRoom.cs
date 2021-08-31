using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_system
{
    //[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class AddNewRoom : Form
    {
        Function fn = new Function();
        String query;

        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load_1(object sendor, EventArgs e)
        {
            this.Location = new Point(350, 170);
            label17.Visible = false;
            label18.Visible = false;

            query = "select *from rooms";
            DataSet ds = fn.GetData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }



       

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            query = "select *from rooms where roomNo="+guna2TextBox1.Text+"";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if(guna2CheckBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                label18.Visible = false;
                query = "insert into rooms(roomNo,roomStatus) values(" + guna2TextBox1.Text + ",'"+status+"')";
                fn.SetData(query, "Room Added.");
                AddNewRoom_Load_1(this, null);

                
            }
            else
            {
                label18.Text = "Room All Ready Exixt.";
                label18.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select *from rooms where roomNo=" + guna2TextBox2.Text + "";
            DataSet ds = fn.GetData(query);

            if(ds.Tables[0].Rows.Count==0)
            {
                label17.Text = "No Room Exist.";
                label17.Visible = true;
                guna2CheckBox2.Checked = false;
            }
            else
            {
                label17.Text = "Room Found.";
                label17.Visible = true;
                if(ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    guna2CheckBox2.Checked = true;
                }
                else
                {
                    guna2CheckBox2.Checked = false;
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string status;
            if(guna2CheckBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "Update rooms set roomStatus='" + status + "'where roomNo="+guna2TextBox2.Text+"";
            fn.SetData(query, "Details Updated.");
            AddNewRoom_Load_1(this, null);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(label17.Text=="Room Found.")
            {
                query = "delete from rooms where roomNo=" + guna2TextBox2.Text + "";
                fn.SetData(query, "Room Details Deleted.");
                AddNewRoom_Load_1(this, null);
            }
            else
            {
                MessageBox.Show("trying to Delete which doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




        