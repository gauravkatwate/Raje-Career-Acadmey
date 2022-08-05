using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Raje_Career_Academy_02
{
    public partial class frm_Manage_Student : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Manage_Student()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            tb_Student_ID.Clear();
            tb_Refrencer_Name.Clear();
            tb_mob2.Clear();
            tb_Mob1.Clear();
            tb_Middle_Name.Clear();
            tb_Last_Name.Clear();
            tb_First_Name.Clear();
            tb_Email.Clear();
            tb_address.Clear();
            cb_clg.Text = "";
            cb_Course.Text = "";
            cb_Refernce.Text = "";
            tb_Student_ID.Enabled = true;
            pb_Serch.Enabled = true;
            tb_Student_ID.Focus();
        }

        private void pb_Serch_Click(object sender, EventArgs e)
        {
            if (tb_Student_ID.Text != "")
            {
                gf.ConnectDB();

                SqlCommand cmd = new SqlCommand("Select * from Student_Addmission_Detailes Where StudentID = '" + tb_Student_ID.Text + "'", gf.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_DOB.Text = obj["DOB"].ToString();
                    tb_First_Name.Text = obj["Std_FName"].ToString();
                    tb_Middle_Name.Text = obj["Std_MName"].ToString();
                    tb_Last_Name.Text = obj["Std_LName"].ToString();
                    dtp_add_Date.Text = obj["Add_Date"].ToString();
                    tb_Email.Text = obj["Email_ID"].ToString();
                    tb_Mob1.Text = obj["MobNo1"].ToString();
                    tb_mob2.Text = obj["MobNo2"].ToString();
                    tb_address.Text = obj["Address"].ToString();
                    cb_clg.Text = obj["ClgName"].ToString();
                    cb_Course.Text = obj["CourseName"].ToString();
                    cb_Refernce.Text = obj["Reference"].ToString();
                    tb_Refrencer_Name.Text = obj["Ref_Name"].ToString();


                    tb_Student_ID.Enabled = false;
                    pb_Serch.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Id", "EnterID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                gf.DisConnectDB();
            }
            else
            {
                MessageBox.Show("Please Enter BatchID", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_address.Text != "" && tb_Mob1.Text != "" && tb_Student_ID.Text != "" && tb_First_Name.Text != "" && tb_Last_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Email.Text != "" && cb_Refernce.Text != "" && cb_clg.Text != "" && cb_Course.Text != "")
            {
                gf.InsertData("Update Student_Addmission_Detailes Set Std_FName = '" + tb_First_Name.Text + "',Std_MName = '" + tb_Middle_Name.Text + "',Std_LName = '" + tb_Last_Name.Text + "',DOB = '" + tb_DOB.Text + "',Add_Date = '" + dtp_add_Date.Text + "',Email_ID = '" + tb_Email.Text + "',MobNo1 = '" + tb_Mob1.Text + "',MobNo2 = '" + tb_mob2.Text + "',Address = '" + tb_address.Text + "',ClgName = '" + cb_clg.Text + "',CourseName = '" + cb_Course.Text + "',Reference = '" + cb_Refernce.Text + "',Ref_Name = '" + tb_Refrencer_Name.Text + "' where StudentID = '" + tb_Student_ID.Text + "'");
                MessageBox.Show("Information Update Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Please Fill All Information", "FillAll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           if(tb_Student_ID.Text != "")
            {
                gf.deleteData("delete from Student_Addmission_Detailes where StudentID = '" + tb_Student_ID.Text + "'");
                MessageBox.Show("Information Deleted Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
           else
            {
                MessageBox.Show("Please Fill Student ID", "FillAll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_Manage_Student_Load(object sender, EventArgs e)
        {
            gf.FillComboBox("select Distinct(Name) from Course_Detailes", "Name", cb_Course);
            gf.FillComboBox("select Distinct(ClgName) from Student_Addmission_Detailes", "ClgName", cb_clg);
        }
    }
}
