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
    public partial class frm_Student_Enquiry : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Student_Enquiry()
        {
            InitializeComponent();
        }

        void clear()
        {
            foreach(Control crt in this.Controls)
            {
                if(crt.GetType() == typeof(TextBox))
                {
                    crt.Text = "";
                }
            }
        }
        #region btn Save
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(cb_clg.Text != "" && tb_Email.Text != "" && tb_Enquiry_ID.Text != "" && tb_First_Name.Text != "" && tb_Last_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Phone.Text != "" && tb_Refrencer_Name.Text != "" && tb_Sudent_Count.Text != "" && dtp_Enquiry_Date.Text != "" && cb_Course.Text != "" && cb_Refernce.Text != "" && cb_Subject.Text != "")
            {
                gf.InsertData("Insert Into Student_Enquiry_Detailes values('" + tb_Enquiry_ID.Text+"','"+tb_First_Name.Text+"','"+tb_Middle_Name.Text+"','"+tb_Last_Name.Text+"','"+cb_clg.Text+"','"+dtp_Enquiry_Date.Text+"','"+tb_Phone.Text+"','"+tb_Email.Text+"','"+cb_Course.Text+"','"+tb_msg.Text+"','"+cb_Subject.Text+"','"+tb_Sudent_Count.Text+"','"+cb_Refernce.Text+"','"+tb_Refrencer_Name.Text+"')");
                MessageBox.Show("Information Saved Sucssesfully","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear();
                tb_Enquiry_ID.Text = Convert.ToString(gf.Autoincrement("Select Max(EnquiryID) from Student_Enquiry_Detailes", 1));
                tb_First_Name.Focus();

            }
            else
            {
                MessageBox.Show("Please Enter All Information","Enter",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void frm_Student_Enquiry_Load(object sender, EventArgs e)
        {
            tb_Enquiry_ID.Text = Convert.ToString(gf.Autoincrement("Select Max(EnquiryID) from Student_Enquiry_Detailes", 1));
            gf.FillComboBox("select Distinct(Name) from Course_Detailes","Name", cb_Course);
            gf.FillComboBox("select Distinct(Name) from Subject_Detailes", "Name", cb_Subject);
            gf.FillComboBox("select Distinct(ClgName) from Student_Addmission_Detailes", "ClgName", cb_clg);
        }
    }
}
