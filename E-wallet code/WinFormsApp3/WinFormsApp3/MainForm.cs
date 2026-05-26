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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Db.GetConnection();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB error: " + ex.ToString());
            }
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            new Signup().Show();
        }

        private void signin_btn_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }
}
