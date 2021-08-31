using Microsoft.VisualBasic;
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
    public partial class NewStudent : Form
    {
        Function fn = new Function();
        string query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus ='Yes' and Booked='No'";
            DataSet ds = fn.GetData(query);

            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                ComboRoomNumber.Items.Add(room);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCollege.Clear();
            txtRgeNo.Clear();
            ComboRoomNumber.SelectedIndex =-1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCollege.Text != "" && txtRgeNo.Text != "" && ComboRoomNumber.SelectedIndex != -1)
            {

                Int64 mobile = Int64.Parse(txtMobile.Text);
                string name = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string email = txtEmail.Text;
                string paddress = txtAddress.Text;
                string college = txtCollege.Text;
                string RegNo = txtRgeNo.Text;
                Int64 roomNo = Int64.Parse(ComboRoomNumber.Text);

                query = "insert into newStudent(mobile,name,fname,mname,email,paddress,college,RegNo,roomNo) values(" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + college + "','" + RegNo + "','" + roomNo + "') update rooms set Booked ='Yes'where roomNo =" + roomNo + "";
                fn.SetData(query, "Student Registration Success.");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill all empty spaces.","Information!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
