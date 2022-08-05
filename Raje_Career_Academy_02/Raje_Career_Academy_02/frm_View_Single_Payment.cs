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
    public partial class frm_View_Single_Payment : Form
    {
        Global_Functions gf = new Global_Functions();

        int j, i, k, m;
        public frm_View_Single_Payment()
        {
            InitializeComponent();
        }

        void clear()
        {
            tb_Student_Id.Clear();
            tb_Student_Name.Clear();
            tb_remaining_fee.Clear();
            tb_PaymentID.Clear();
            tb_mob.Clear();
            tb_Current_Fees.Clear();
            tb_paid_fee.Clear();
            tb_total_fee.Clear();
            tb_Student_Id.Focus();
            tb_Student_Id.Enabled = true;
            pb_Serch.Enabled = true;
            dgv_subject.DataSource = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Student_Id.Text != "" && tb_Current_Fees.Text != "")
            {
                gf.InsertData("Update Payment_Detailes Set Paid_Fees = '" + tb_paid_fee.Text + "', Remaining_Fees = '" + tb_remaining_fee.Text + "' where Student_ID = '" + tb_Student_Id.Text + "'");
                MessageBox.Show("Information Update Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Please Fill Information", "FillAll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pb_Serch_Click(object sender, EventArgs e)
        {
            if (tb_Student_Id.Text != "")
            {
                gf.ConnectDB();

                SqlCommand cmd = new SqlCommand("Select * from Payment_Detailes Where Student_ID = '" + tb_Student_Id.Text + "'", gf.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Student_Name.Text = obj["Name"].ToString();
                    tb_PaymentID.Text = obj["Payment_ID"].ToString();
                    tb_mob.Text = obj["Mob_No"].ToString();
                    tb_total_fee.Text = obj["Total_Fees"].ToString();
                    tb_remaining_fee.Text = obj["Remaining_Fees"].ToString();
                    tb_paid_fee.Text = obj["Paid_Fees"].ToString();

                    tb_Student_Id.Enabled = false;
                    pb_Serch.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Id", "EnterID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                gf.DisConnectDB();
                gf.ConnectDB();
                gf.FillDT("select * from Student_Subject_Detailes where student_ID = '" + tb_Student_Id.Text + "'", dgv_subject);
                gf.DisConnectDB();
                k = Convert.ToInt32(tb_remaining_fee.Text);
                i = Convert.ToInt32(tb_paid_fee.Text);
                m = dgv_subject.Rows.Count;
            }
            else
            {
                MessageBox.Show("Please Enter StudentID", "EnterID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_Current_Fees_TextChanged(object sender, EventArgs e)
        {
            if (tb_Current_Fees.Text == "")
            {
                tb_Current_Fees.Text = "0";
            }
            else
            {
                j = Convert.ToInt32(tb_Current_Fees.Text);
            }
            tb_paid_fee.Text = Convert.ToString(i + j);
            tb_remaining_fee.Text = Convert.ToString(k - j);
        }
    }
}
