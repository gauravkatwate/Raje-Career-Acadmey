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
    public partial class frm_Manage_Subject : Form
    {
        Global_Functions gf = new Global_Functions();
        string stetus = "";
        public frm_Manage_Subject()
        {
            InitializeComponent();
        }

        private void pb_Serch_Click(object sender, EventArgs e)
        {
            if(tb_Subject_ID.Text != "")
            {
                gf.ConnectDB();
                SqlCommand cmd = new SqlCommand("select * from Subject_Detailes where SubjectID = '"+tb_Subject_ID.Text+"'",gf.con);
                var obj = cmd.ExecuteReader();
                
                if (obj.Read())
                {
                    tb_Subject_Name.Text = obj["Name"].ToString();
                    tb_subject_Fee.Text = obj["fees"].ToString();
                 
                    if ("Active" == obj["Stetus"].ToString())
                    {
                        rb_Active.Checked = true;
                    }
                    else
                    {
                        rb_InActive.Checked = true;
                    }

                    pb_Serch.Enabled = false;
                    tb_Subject_ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Subject ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        private void frm_Manage_Subject_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'raje_Career_Academy_DBDataSet2.Subject_Detailes' table. You can move, or remove it, as needed.
            this.subject_DetailesTableAdapter1.Fill(this.raje_Career_Academy_DBDataSet2.Subject_Detailes);
              
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Subject_ID.Clear();
            tb_Subject_Name.Clear();
            tb_subject_Fee.Clear();
            tb_Subject_ID.Enabled = true;
            pb_Serch.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tb_Subject_Name.Text != "" && tb_subject_Fee.Text != "")
            {
                #region Stetus
                if (rb_Active.Checked == true)
                {
                    stetus = rb_Active.Text;
                }
                else
                {
                    stetus = rb_InActive.Text;
                }
                #endregion

                gf.InsertData("update Subject_Detailes set Name = '"+tb_Subject_Name.Text+"', Fees = '"+ tb_subject_Fee.Text+"', Stetus = '"+stetus+"' where SubjectID = '"+tb_Subject_ID.Text+"'");

                MessageBox.Show("Data Updated Sucssesfully","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tb_Subject_ID.Clear();
                tb_Subject_Name.Clear();
                tb_subject_Fee.Clear();
                tb_Subject_ID.Enabled = true;
                pb_Serch.Enabled = true;
                gf.FillDT("select * from Subject_Detailes", dgv_all_subject);
            }
            else
            {
                MessageBox.Show("Fill All Detailes", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
