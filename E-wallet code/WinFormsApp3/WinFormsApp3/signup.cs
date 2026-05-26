using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using EWalletSystem;

namespace WinFormsApp3
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = Db.GetConnection())
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = @"insert into user_data
                          (id_user, usrname, email, user_password, pin, balance)
                          values
                          (seq_user_id.NEXTVAL, :usrname, :email, :pass, :pin, 0)";
                c.CommandType = CommandType.Text;
                c.BindByName = true;
                c.Parameters.Add("usrname", username_txt.Text);
                c.Parameters.Add("email", email_txt.Text);
                c.Parameters.Add("pass", password_txt.Text);
                c.Parameters.Add("pin", Convert.ToInt32(pin_txt.Text));
                c.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!");
            }
        }
    }
}
