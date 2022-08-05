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
    public partial class frm_Manage_Batch : Form
    {
        string Stetus = "", Creator = "", Modifier = "";
        Global_Functions gf = new Global_Functions();

        public frm_Manage_Batch()
        {
            InitializeComponent();
        }

        private void frm_Manage_Batch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raje_Career_Academy_DBDataSet4.Batch_Detailes' table. You can move, or remove it, as needed.
            this.batch_DetailesTableAdapter1.Fill(this.raje_Career_Academy_DBDataSet4.Batch_Detailes);
            // TODO: This line of code loads data into the 'raje_Career_Academy_DBDataSet.Batch_Detailes' table. You can move, or remove it, as needed.
            this.batch_DetailesTableAdapter.Fill(this.raje_Career_Academy_DBDataSet.Batch_Detailes);
           // gf.FillDT("Select * From Batch_Detailes", dgv_Manage_Batch);
            gf.FillComboBox("Select Distinct(Name) From Subject_Detailes","Name",cmb_Subject);
        }

        #region Clear Controles
        void Clear()
        {
            tb_Batch_ID.Clear();
            tb_Batch_No.Clear();
            tb_Capacity.Clear();
            tb_Dueration.Clear();
            cmb_Subject.Text = "";
            tb_Batch_ID.Focus();
            tb_Batch_ID.Enabled = true;
            gf.FillDT("Select * From Batch_Detailes",dgv_Manage_Batch);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_Manage_Batch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region btn Update
        private void btn_Update_Click(object sender, EventArgs e)
        {
            #region Stetus
            if (rb_Active.Checked == true)
            {
                Stetus = "Active";
            }
            else
            {
                Stetus = "InActive";
            }
            #endregion

            if (cmb_Subject.Text != "" && tb_Dueration.Text != "" && tb_Batch_ID.Text != "" && tb_Batch_No.Text != "" && tb_Capacity.Text != "" && Stetus != "")
            {
                gf.InsertData("Update Batch_Detailes Set Subject = '" + cmb_Subject.Text + "',BatchNo = '" + tb_Batch_No.Text + "',Status = '" + Stetus + "',StartDate = '" + dtp_Batch_Start_Date.Text + "',Duration = '" + tb_Dueration.Text + "',Capacity = '" + tb_Capacity.Text + "',Creator = '" + Creator + "',Modifier = '" + Modifier + "' Where BatchID = '" + tb_Batch_ID.Text + "'");
                MessageBox.Show("Information Update Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Please Fill All Information","FillAll",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Search
        private void pb_Serch_Click(object sender, EventArgs e)
        {
            if (tb_Batch_ID.Text != "")
            {
                gf.ConnectDB();

                SqlCommand cmd = new SqlCommand("Select * from Batch_Detailes Where BatchID = '" + tb_Batch_ID.Text + "'", gf.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Batch_No.Text = obj["BatchNO"].ToString();
                    tb_Capacity.Text = obj["Capacity"].ToString();
                    tb_Dueration.Text = obj["Duration"].ToString();
                    cmb_Subject.Text = obj["Subject"].ToString();
                    dtp_Batch_Start_Date.Text = obj["StartDate"].ToString();

                    if (obj["Status"].ToString() == "Active")
                    {
                        rb_Active.Checked = true;
                    }
                    else
                    {
                        rb_InActive.Checked = true;
                    }
                    tb_Batch_ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Id","EnterID",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                gf.DisConnectDB();
            }
            else
            {
                MessageBox.Show("Please Enter BatchID", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
