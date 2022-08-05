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
    public partial class frm_Admission : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Admission()
        {
            InitializeComponent();
        }

        #region btn next
        private void btn_Next_Click_1(object sender, EventArgs e)
        {
                if (tb_Address.Text != "" && tb_Mob_No1.Text != "" && tb_Student_ID.Text != "" && tb_First_Name.Text != "" && tb_Last_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Mail.Text != "" &&  cmb_Refernce.Text != "" && cmb_Collage_Name.Text != "" && cmb_Course.Text != "")
                {
                gf.InsertData("Insert Into Student_Addmission_Detailes values('"+tb_Student_ID.Text+"','"+tb_First_Name.Text+"','"+tb_Middle_Name.Text+"','"+tb_Last_Name.Text+"','"+dtp_DOB.Text+"','"+dtp_Addmition_Date.Text+"','"+tb_Mail.Text+"','"+tb_Mob_No1.Text+"','"+tb_Mob_No2.Text+"','"+tb_Address.Text+"','"+cmb_Collage_Name.Text+"','"+cmb_Course.Text+"','"+cmb_Refernce.Text+"','"+tb_Refrencer_Name.Text+"')");
                MessageBox.Show("Information Added Sucssesfully", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #region next form
                Form formbackground = new Form();
                try
                {
                    using (frm_Payment_Details fpd = new frm_Payment_Details())
                    {
                        formbackground.StartPosition = FormStartPosition.Manual;
                        formbackground.FormBorderStyle = FormBorderStyle.None;
                        formbackground.Opacity = .70d;
                        formbackground.BackColor = Color.Black;
                        formbackground.WindowState = FormWindowState.Maximized;
                        formbackground.TopMost = true;
                        formbackground.Location = this.Location;
                        formbackground.ShowInTaskbar = false;

                        formbackground.Show();

                        fpd.Owner = formbackground;
                        fpd.ShowDialog();

                        formbackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formbackground.Dispose();
                }
                #endregion
            }
            else
                {
                MessageBox.Show("Please Enter All Detailes","ENTER ALL",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
        }
        #endregion
      

        private void frm_Admission_Load(object sender, EventArgs e)
        {
            tb_Student_ID.Text = Convert.ToString(gf.Autoincrement("Select Max(StudentID) from Student_Addmission_Detailes",1001));
            gf.FillComboBox("select Distinct(Name) from Course_Detailes", "Name", cmb_Course);
            gf.FillComboBox("select Distinct(ClgName) from Student_Addmission_Detailes", "ClgName", cmb_Collage_Name);
        }

        void clear()
        {
            tb_Address.Clear();
            tb_First_Name.Clear();
            tb_Last_Name.Clear();
            tb_Mail.Clear();
            tb_Middle_Name.Clear();
            tb_Mob_No1.Clear();
            tb_Mob_No2.Clear();
            tb_Refrencer_Name.Clear();
            cmb_Collage_Name.Text = "";
            cmb_Course.Text = "";
            cmb_Refernce.Text = "";
            tb_First_Name.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
