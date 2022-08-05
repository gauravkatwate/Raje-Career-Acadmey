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
    public partial class Frm_Signup : Form
    {
        Global_Functions gf = new Global_Functions();
        int i = 0;
        public Frm_Signup()
        {
            InitializeComponent();
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Signup_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
            i = gf.Autoincrement("Select Max(Id) from Login_Detailes", 1);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.Show();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "")
            {
                if (tb_Confirm_Password.Text == tb_Password.Text)
                {
                    gf.InsertData("insert into Login_Detailes values('"+i+"','" + tb_Username.Text + "','" + tb_Password.Text + "')");
                    MessageBox.Show("Signup Sucssesfull", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_Login login = new frm_Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Password And Confirm Password Not Same", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Signup Detailes", "Enter All", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
