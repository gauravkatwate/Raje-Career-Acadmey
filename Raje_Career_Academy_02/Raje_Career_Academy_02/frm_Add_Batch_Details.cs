using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raje_Career_Academy_02
{
    public partial class frm_Add_Batch_Details : Form
    {
        string Stetus = "", Creator = "", Modifier = "";
        Global_Functions gf = new Global_Functions();
        public frm_Add_Batch_Details()
        {
            InitializeComponent();
        }

        #region Clear
        void clearControls()
        {
            tb_Batch_ID.Text = Convert.ToString(gf.Autoincrement("Select max(BatchID) from Batch_Detailes", 101));
            tb_Batch_No.Clear();
            tb_Capacity.Clear();
            tb_Dueration.Clear();
            cmb_Subject.Text = "";
            cmb_Subject.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearControls();
        }
        #endregion

        #region btn Save
        private void btn_Save_Click(object sender, EventArgs e)
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
                gf.InsertData("insert into Batch_Detailes values('" + tb_Batch_ID.Text + "','" + cmb_Subject.Text + "','" + tb_Batch_No.Text + "','" + Stetus + "','" + dtp_Batch_Start_Date.Text + "','" + tb_Dueration.Text + "','" + tb_Capacity.Text + "','" + Creator + "','" + Modifier + "')");
                MessageBox.Show("Information Saved Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearControls();
            }
            else
            {
                MessageBox.Show("Please Enter All Detailes", "Please", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Load Event
        private void frm_Add_Batch_Detailes_Load(object sender, EventArgs e)
        {
            clearControls();
            gf.FillComboBox("Select Distinct(Name) from Subject_Detailes", "Name", cmb_Subject);
        }
        #endregion
    }
}
