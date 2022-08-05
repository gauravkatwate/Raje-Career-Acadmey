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
    class Global_Functions
    {
        #region GlobalVariables

        public int cnt = 0;
        public bool bret = false;


        #endregion

        #region Connection
        public static string strcon = (@"Data Source=.\SQLEXPRESS;Initial Catalog=Raje_Career_Academy_DB;Integrated Security=True");

        public SqlConnection con = new SqlConnection(strcon);

        public void ConnectDB()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void DisConnectDB()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        #endregion

        #region Login
        
        public void Login(string query)
        {
            ConnectDB();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {  
                bret = true;
            }
            DisConnectDB();
        }
        
        #endregion

        #region FillComboBox

        public void FillComboBox(string query,string ColumnName, ComboBox cmb)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand(query, con);
                var obj = cmd.ExecuteReader();

                while(obj.Read())
                {
                    cmb.Items.Add(obj[ColumnName].ToString());
                }

                cmd.Dispose();
                DisConnectDB();
            }
            catch
            {

            }
        }
        #endregion

        #region InsertData   
        public void InsertData(string query)
        {
            ConnectDB();

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DisConnectDB();
        }
        #endregion

        #region AutoIncrement
        public int Autoincrement(string query, int i)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand(query, con);

            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                cnt = i;
            }
            else
            {
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            DisConnectDB();
            return cnt;
        }
        #endregion

        #region Fill Dt
        public void FillDT(string query,DataGridView dgv)
        {
            ConnectDB();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);            
            dgv.DataSource = dt;            
            DisConnectDB();
        }
        #endregion

        #region delete Data

        public void deleteData(string query)
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            
            DisConnectDB();
        }

        #endregion

        

    }
}
