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
    public partial class frm_Batch_Report : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Batch_Report()
        {
            InitializeComponent();
        }

        private void frm_Batch_Report_Load(object sender, EventArgs e)
        {
            gf.ConnectDB();
            SqlCommand cmd = new SqlCommand("select * from Batch_Detailes", gf.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Batch_Detailes");
            Report.Batch_CrystalReport1 scr = new Report.Batch_CrystalReport1();
            scr.SetDataSource(ds);
            this.batch_report_viewer.ReportSource = scr;
            this.batch_report_viewer.Refresh();
            gf.DisConnectDB();
        }
    }
}
