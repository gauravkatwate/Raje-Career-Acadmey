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
    public partial class frm_Login : Form
    {
        Global_Functions gf = new Global_Functions();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text != "" && tb_Password.Text != "")
            {
                gf.Login("select * from Login_Detailes Where Username = '"+tb_username.Text+"' and Password = '"+tb_Password.Text+"'");

                if(gf.bret == true)
                {
                    MessageBox.Show("Login Sucssesfull", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_Main main = new frm_Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Username Or Password", "Failuer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_username.Clear();
                    tb_Password.Clear();
                    tb_Password.Focus();
                }
              
                
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username And Password","Credenshial",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Signup obj = new Frm_Signup();
            obj.Show();
        }
    }
}
