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
    public partial class frm_Payment_Report : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Payment_Report()
        {
            InitializeComponent();
        }

        private void frm_Payment_Report_Load(object sender, EventArgs e)
        {
            gf.ConnectDB();
            SqlCommand cmd = new SqlCommand("select * from Payment_Detailes", gf.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Payment_Detailes");
            Report.Payment_CrystalReport1 scr = new Report.Payment_CrystalReport1();
            scr.SetDataSource(ds);
            this.payment_report_viewer.ReportSource = scr;
            this.payment_report_viewer.Refresh();
            gf.DisConnectDB();
        }
    }
}
