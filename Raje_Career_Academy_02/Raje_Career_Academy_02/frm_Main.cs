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
    public partial class frm_Main : Form
    {
        Global_Functions gf = new Global_Functions();
       
        public frm_Main()
        {
            InitializeComponent();
        }

        #region HideSubMenu
        private void hidesubmenu()
        {
            if (panel_Student_menu.Visible == true)
            {
                panel_Student_menu.Visible = false;
            }
            if (panel_Batch.Visible == true)
            {
                panel_Batch.Visible = false;
            }
            if (panel_Course.Visible == true)
            {
                panel_Course.Visible = false;
            }
            if(panel_Subject_Menu.Visible == true)
            {
                panel_Subject_Menu.Visible = false;
            }
            if(panel_Payment.Visible == true)
            {
                panel_Payment.Visible = false;
            }
            if(panel_Reports.Visible == true)
            {
                panel_Reports.Visible = false;
            }
        }
        #endregion

        #region ShowSubMenu
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        #region OpenChiledForm
            public Form ActiveForm = null;
            public void openChiledForm(Form chiledForm)
            {
                if (ActiveForm != null)
                    ActiveForm.Close();
                ActiveForm = chiledForm;
                chiledForm.TopLevel = false;
                chiledForm.FormBorderStyle = FormBorderStyle.None;
                chiledForm.Dock = DockStyle.Fill;
                panel_Main.Controls.Add(chiledForm);
                panel_Main.Tag = chiledForm;
                chiledForm.BringToFront();
                chiledForm.Show();
            }
        #endregion

        #region Btn Dashboard
        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            hidesubmenu();
            panel_Main.Controls.Add(panel_cover);
        }
        #endregion

        #region Btn Student
        private void btn_Student_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Student_menu);
        }

        public void btn_Admission_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Admission());
            hidesubmenu();
        }

        private void btn_Enquiry_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Student_Enquiry());
            hidesubmenu();
        }

        private void btn_Manage_Student_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Manage_Student());
            hidesubmenu();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_View_All_Student());
            hidesubmenu();
        }
        #endregion

        #region Btn Course
        private void btn_Course_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Course);
        }

        private void btn_New_Course_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Add_Course());
            hidesubmenu();
        }
        #endregion

        #region Btn Batch
        private void btn_Batch_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Batch);
        }

        private void btn_Add_New_Batch_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Add_Batch_Details());
            hidesubmenu();
        }

        private void btn_Manage_Batch_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Manage_Batch());
            hidesubmenu();
        }
        #endregion

        #region Btn Subject
        private void btn_Subject_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Subject_Menu);
        }

        private void btn_Add_Subject_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Add_Subject());
            hidesubmenu();
        }

        private void btn_Manage_Subject_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Manage_Subject());
            hidesubmenu();
        }

        #endregion

        #region btn Payment
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Payment);
        }

        private void btn_View_Payment_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_View_All_Payments());
            hidesubmenu();
        }

        private void btn_View_Single_Payment_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_View_Single_Payment());
        }
        #endregion

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        #region btn Logout
        private void pb_Logout_Click(object sender, EventArgs e)
        {
            DialogResult  = MessageBox.Show("Do You Want To Exit","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
        #endregion

        #region Btn Report

        private void btn_Report_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_Reports);
        }

        private void btn_All_Student_Reports_Click(object sender, EventArgs e)
        {
            openChiledForm(new Report_Forms.frm_student_report());
            hidesubmenu();
        }

        private void btn_Subject_Report_Click(object sender, EventArgs e)
        {
            openChiledForm(new Report_Forms.frm_Subject_Report());
            hidesubmenu();
        }

        private void btn_Payment_Report_Click(object sender, EventArgs e)
        {
            openChiledForm(new Report_Forms.frm_Payment_Report());
            hidesubmenu();
        }

        private void btn_Batch_Report_Click(object sender, EventArgs e)
        {
            openChiledForm(new Report_Forms.frm_Batch_Report());
            hidesubmenu();
        }
        #endregion


    }
}
