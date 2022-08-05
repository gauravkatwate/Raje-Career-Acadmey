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
    public partial class frm_View_All_Payments : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_View_All_Payments()
        {
            InitializeComponent();
        }

        private void frm_View_All_Payments_Load(object sender, EventArgs e)
        {
            gf.FillDT("select * from Payment_Detailes", dgv_Payments);
        }
    }
}
