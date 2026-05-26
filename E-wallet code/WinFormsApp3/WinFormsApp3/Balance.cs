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
    public partial class Balance : Form
    {
        private int id;
        public Balance(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = Db.GetConnection();
            c2.CommandText = "view_balance";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("id", id);
            c2.Parameters.Add("balan", OracleDbType.Int32).Direction = ParameterDirection.Output;
            c2.ExecuteNonQuery();
            string balance = c2.Parameters["balan"].Value.ToString();
            MessageBox.Show("your current balance is: " + balance);
        }
    }
}
