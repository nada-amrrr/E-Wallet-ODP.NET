using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using EWalletSystem;

namespace WinFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = Db.GetConnection())
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select id_user
                                        from user_data
                                        where usrname = :uname
                                          and user_password = :pass";
                    cmd.CommandType = CommandType.Text;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("uname", textBox1.Text);
                    cmd.Parameters.Add("pass", textBox2.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int userId = Convert.ToInt32(result);
                        MessageBox.Show("Login successful!");
                        new MyWallet(userId).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}