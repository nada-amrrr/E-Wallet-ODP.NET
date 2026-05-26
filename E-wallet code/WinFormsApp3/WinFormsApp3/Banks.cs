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
    public partial class Banks : Form
    {
        private int id;
        public Banks(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = Db.GetConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "getuserbanks";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.BindByName = true;
                cmd.Parameters.Add("p_user_id", id);
                cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
        }

        private void banks_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
