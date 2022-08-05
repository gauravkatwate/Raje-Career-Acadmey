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
    public partial class frm_View_All_Student : Form
    {
        Global_Functions gf = new Global_Functions();

        public frm_View_All_Student()
        {
            InitializeComponent();
        }

      

        private void frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raje_Career_Academy_DBDataSet5.Student_Addmission_Detailes' table. You can move, or remove it, as needed.
            this.student_Addmission_DetailesTableAdapter.Fill(this.raje_Career_Academy_DBDataSet5.Student_Addmission_Detailes);
            // gf.FillDT("select * from Student_Addmission_Detailes", dgv_all_students);
            gf.FillComboBox("Select Distinct(ClgName) From Student_Addmission_Detailes", "ClgName", cb_clg);
            gf.FillComboBox("Select Distinct(CourseName) From Student_Addmission_Detailes", "CourseName", cb_course);
        }

        private void pb_clg_Click(object sender, EventArgs e)
        {
            gf.FillDT("select * from Student_Addmission_Detailes where ClgName = '"+cb_clg.Text+"'", dgv_all_students);
            cb_clg.Text = "";
        }

        private void pb_course_Click(object sender, EventArgs e)
        {
            gf.FillDT("select * from Student_Addmission_Detailes where CourseName = '" + cb_course.Text + "'", dgv_all_students);
            cb_course.Text = "";
        }

        private void pb_Serch_Click(object sender, EventArgs e)
        {
            gf.FillDT("select * from Student_Addmission_Detailes where StudentID = '" + tb_Student_ID.Text + "'", dgv_all_students);
            tb_Student_ID.Clear();
        }
    }
}
