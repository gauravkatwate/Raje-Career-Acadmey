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
    public partial class frm_Add_Course : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raje_Career_Academy_DBDataSet3.Course_Detailes' table. You can move, or remove it, as needed.
           // this.course_DetailesTableAdapter.Fill(this.raje_Career_Academy_DBDataSet3.Course_Detailes);
            tb_Course_ID.Text = Convert.ToString(gf.Autoincrement("Select max(CourseID) from Course_Detailes",101));
            gf.FillDT("select * from Course_Detailes", dgv_all_courses);
        }

        #region btn Save
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Course_ID.Text != "" && tb_Course_Name.Text != "")
            {
                gf.InsertData("insert into Course_Detailes values('" + tb_Course_ID.Text + "','" + tb_Course_Name.Text + "')");
                MessageBox.Show("Information Saved Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Course_ID.Text = Convert.ToString(gf.Autoincrement("Select max(CourseID) from Course_Detailes",101));
                tb_Course_Name.Clear();
                tb_Course_Name.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter Course Name", "Please", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
