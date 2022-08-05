using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Raje_Career_Academy_02.Report_Forms
{
    public partial class frm_student_report : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_student_report()
        {
            InitializeComponent();
        }

        private void frm_student_report_Load(object sender, EventArgs e)
        {
            
            gf.ConnectDB();
            SqlCommand cmd = new SqlCommand("select * from Student_Addmission_Detailes", gf.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Student_Addmission_Detailes");
            Report.Student_CrystalReport1 scr = new Report.Student_CrystalReport1();
            scr.SetDataSource(ds);
            this.Student_Report_Viewer.ReportSource = scr;
            this.Student_Report_Viewer.Refresh();
            gf.DisConnectDB();
        }
    }
}
