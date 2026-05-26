using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using EWalletSystem;
namespace WinFormsApp3
{
    public partial class Information : Form
    {
        private int id;
        public Information(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = Db.GetConnection())
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select id_user, usrname, email, user_password, pin from user_data where id_user=:id";
                c.CommandType = CommandType.Text;
                c.BindByName = true;
                c.Parameters.Add("id", id);

                OracleDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    username_txt.Text = dr["usrname"].ToString();
                    email_txt.Text = dr["email"].ToString();
                    password_txt.Text = dr["user_password"].ToString();
                    pin_txt.Text = dr["pin"].ToString();
                }
                dr.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = Db.GetConnection())
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = @"update user_data
                          set usrname=:uname,
                              email=:uemail,
                              user_password=:pass,
                              pin=:upin
                          where id_user=:id";
                c.CommandType = CommandType.Text;
                c.BindByName = true;
                c.Parameters.Add("uname", username_txt.Text);
                c.Parameters.Add("uemail", email_txt.Text);
                c.Parameters.Add("pass", password_txt.Text);
                c.Parameters.Add("upin", Convert.ToInt32(pin_txt.Text));
                c.Parameters.Add("id", id);
                c.ExecuteNonQuery();

                MessageBox.Show("Saved!");
            }
        }
    }
}
