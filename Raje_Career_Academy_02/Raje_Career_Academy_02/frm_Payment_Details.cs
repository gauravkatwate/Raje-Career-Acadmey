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
    public partial class frm_Payment_Details : Form
    {
        Global_Functions gf = new Global_Functions();
        int pCnt = 1;
        double totalfee = 0;
        public frm_Payment_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Payment_Details_Load(object sender, EventArgs e)
        {
            tb_PaymentID.Text = Convert.ToString(gf.Autoincrement("Select Max(Payment_ID) From Payment_Detailes", 10001));

            #region Name & mob
            try
            {
                gf.ConnectDB();

                SqlCommand cmd = new SqlCommand("Select * from Student_Addmission_Detailes Where StudentID = (Select max(StudentID) From Student_Addmission_Detailes)", gf.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_StudentID.Text = obj["StudentID"].ToString();
                    tb_Name.Text = obj["Std_FName"].ToString() + (" ") + obj["Std_MName"].ToString() + (" ") + obj["Std_LName"].ToString();
                    tb_Mob_No.Text = obj["MobNo1"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            gf.DisConnectDB();
            #endregion

            gf.FillComboBox("Select Distinct(Name) From Subject_Detailes Where Stetus = 'Active' ", "Name", cmb_Subject);
        }

        #region cmb Subject
        private void cmb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            gf.ConnectDB();

            SqlCommand cmd = new SqlCommand("Select Fees From Subject_Detailes Where Name = '" + cmb_Subject.Text + "'", gf.con);
            tb_Fees.Text = Convert.ToString(cmd.ExecuteScalar());
            

            gf.DisConnectDB();

            gf.FillComboBox("Select Distinct(BatchNo) From Batch_Detailes Where Subject = '" + cmb_Subject.Text + "' and Status = 'Active' ", "BatchNo", cmb_Bactch_No);
        }
        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Bactch_No.Text != "" && cmb_Subject.Text != "")
            {
                dgv_payment.Rows.Add(pCnt, cmb_Subject.Text, cmb_Bactch_No.Text, tb_Fees.Text);

                pCnt++;

                totalfee = totalfee + Convert.ToDouble(tb_Fees.Text);
                cmb_Bactch_No.Items.Clear();
                cmb_Bactch_No.Text = "";
                cmb_Subject.Text = "";
                tb_Fees.Clear();


                tb_paid_fee.Text = Convert.ToString(totalfee);

            }
            else
            {
                MessageBox.Show("Please Enter Detailes", "Please Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_paid_fee_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb_total_fee.Text);
            int j = 0;
            if(tb_paid_fee.Text == "")
            {
                tb_paid_fee.Text = "0";
            }
            else
            {
               j = Convert.ToInt32(tb_paid_fee.Text);
            }
            tb_total_fee.Text = Convert.ToString(totalfee);
            tb_remaining_fee.Text = Convert.ToString(totalfee - j);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(pCnt > 0 )
            {
                gf.InsertData("Insert Into Payment_Detailes values('" + tb_StudentID.Text + "','" + tb_PaymentID.Text + "','" + tb_Name.Text + "','" + tb_Mob_No.Text + "','" + tb_total_fee.Text + "','" + tb_paid_fee.Text + "','" + tb_remaining_fee.Text + "')");

           
                for (int i = 0; i <= dgv_payment.Rows.Count - 1 ; i++)
                {
                    gf.ConnectDB();
                    SqlCommand cmd = new SqlCommand("Insert Into Student_Subject_Detailes Values('" + tb_StudentID.Text + "','" + dgv_payment.Rows[i].Cells[1].Value + "','"+ dgv_payment.Rows[i].Cells[2].Value + "','"+ dgv_payment.Rows[i].Cells[3].Value + "') ",gf.con);
                    cmd.ExecuteNonQuery();
                    gf.DisConnectDB();            
                }

                MessageBox.Show("Admission Sucssesfull", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frm_Main fm = new frm_Main();
                fm.Show();
                
            }
            else
            {
                MessageBox.Show("Please Enter All Detailes", "Enter Detailes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
