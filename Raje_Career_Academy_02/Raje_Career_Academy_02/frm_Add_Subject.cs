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
    public partial class frm_Add_Subject : Form
    {
        string Stetus = "", Creater = "", Modifier = "";
        Global_Functions gf = new Global_Functions();

        public frm_Add_Subject()
        {
            InitializeComponent();
        }

        private void frm_Add_Subject_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Clear
        void clear()
        {
            tb_Subject_Name.Clear();
            tb_Subject_Fee.Clear();
            tb_Subject_Name.Focus();
            tb_Subject_ID.Text = Convert.ToString(gf.Autoincrement("Select Max(SubjectID) from Subject_Detailes", 101));
        }
        #endregion

        #region btn Save
        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region Stetus
            if (rb_Active.Checked == true)
            {
                Stetus = rb_Active.Text;
            }
            else
            {
                Stetus = rb_InActive.Text;
            }
            #endregion

            if (tb_Subject_Fee.Text != "" && tb_Subject_Name.Text != "" && Stetus != "")
            {
                gf.InsertData("Insert into Subject_Detailes values('"+tb_Subject_ID.Text+"', '"+tb_Subject_Name.Text+"','"+tb_Subject_Fee.Text+"','"+Stetus+"','"+Creater+"','"+Modifier+"')");
                MessageBox.Show("information Enterd Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();     
            }
            else
            {
                MessageBox.Show("Please Enter All Detailes", "Please", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


    }
}
