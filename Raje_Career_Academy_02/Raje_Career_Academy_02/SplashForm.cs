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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(4);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                frm_Login login = new frm_Login();
                this.Hide();
                login.Show();
            }

        }

        private void lbl_Raje_Career_Academy_Click(object sender, EventArgs e)
        {

        }
    }
}
