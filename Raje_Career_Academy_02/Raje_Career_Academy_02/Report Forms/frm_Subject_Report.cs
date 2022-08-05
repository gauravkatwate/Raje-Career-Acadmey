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
    public partial class frm_Subject_Report : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Subject_Report()
        {
            InitializeComponent();
        }

        private void frm_Subject_Report_Load(object sender, EventArgs e)
        {
            gf.ConnectDB();
            SqlCommand cmd = new SqlCommand("select * from Subject_Detailes", gf.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Subject_Detailes");
            Report.Subject_CrystalReport1 scr = new Report.Subject_CrystalReport1();
            scr.SetDataSource(ds);
            this.Subject_Report_Viewer.ReportSource = scr;
            this.Subject_Report_Viewer.Refresh();
            gf.DisConnectDB();
        }
    }
}
