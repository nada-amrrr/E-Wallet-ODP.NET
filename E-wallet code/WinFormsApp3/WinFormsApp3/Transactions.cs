using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using EWalletSystem;

namespace WinFormsApp3
{
    public partial class Transactions : Form
    {
        private int userId;

        private OracleDataAdapter adapter;
        private DataSet ds;

        public Transactions() : this(0) { }

        public Transactions(int id)
        {
            InitializeComponent();
            this.userId = id;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("All Transactions");
            cmbFilter.Items.Add("As Sender");
            cmbFilter.Items.Add("As Receiver");
            cmbFilter.SelectedIndex = 0;

            try
            {
                using (OracleConnection conn = Db.GetConnection())
                {
                    OracleCommand c = new OracleCommand(
                        "select usrname from user_data where id_user = :id", conn);
                    c.BindByName = true;
                    c.Parameters.Add("id", userId);
                    object name = c.ExecuteScalar();
                    if (name != null) txtUsername.Text = name.ToString();
                }
            }
            catch {  }

            LoadTransactions();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            int targetUserId;
            try
            {
                using (OracleConnection conn = Db.GetConnection())
                {
                    OracleCommand idCmd = new OracleCommand(
                        "select id_user from user_data where usrname = :u", conn);
                    idCmd.BindByName = true;
                    idCmd.Parameters.Add("u", txtUsername.Text);
                    object obj = idCmd.ExecuteScalar();
                    if (obj == null)
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }
                    targetUserId = Convert.ToInt32(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error looking up user: " + ex.Message);
                return;
            }

            string filter = cmbFilter.SelectedItem?.ToString() ?? "All Transactions";
            string sql;

         
            if (filter == "As Sender")
            {
                sql = @"SELECT transactionid, sender_user_id, receiver_user_id,
                               amount, tdate, transaction_type, status
                        FROM   Transactions
                        WHERE  sender_user_id = :userid
                        ORDER  BY tdate DESC";
            }
            else if (filter == "As Receiver")
            {
                sql = @"SELECT transactionid, sender_user_id, receiver_user_id,
                               amount, tdate, transaction_type, status
                        FROM   Transactions
                        WHERE  receiver_user_id = :userid
                        ORDER  BY tdate DESC";
            }
            else
            {
                sql = @"SELECT transactionid, sender_user_id, receiver_user_id,
                               amount, tdate, transaction_type, status
                        FROM   Transactions
                        WHERE  sender_user_id = :userid OR receiver_user_id = :userid
                        ORDER  BY tdate DESC";
            }

            try
            {
                adapter = new OracleDataAdapter(sql, Db.ConnectionString);
                adapter.SelectCommand.BindByName = true;
                adapter.SelectCommand.Parameters.Add("userid", OracleDbType.Int32).Value = targetUserId;

                ds = new DataSet();
                adapter.Fill(ds, "Transactions");
                dgvTransactions.DataSource = ds.Tables["Transactions"];

                if (dgvTransactions.Columns.Count >= 7)
                {
                    dgvTransactions.Columns[0].HeaderText = "ID";
                    dgvTransactions.Columns[1].HeaderText = "Sender ID";
                    dgvTransactions.Columns[2].HeaderText = "Receiver ID";
                    dgvTransactions.Columns[3].HeaderText = "Amount";
                    dgvTransactions.Columns[4].HeaderText = "Date";
                    dgvTransactions.Columns[5].HeaderText = "Type";
                    dgvTransactions.Columns[6].HeaderText = "Status";
                    dgvTransactions.Columns[0].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (adapter == null || ds == null)
            {
                MessageBox.Show("Please search first before saving.");
                return;
            }

            try
            {
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                int rows = adapter.Update(ds.Tables["Transactions"]);

                if (rows == 0)
                    MessageBox.Show("No changes to save.");
                else
                    MessageBox.Show(rows + " row(s) updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
                LoadTransactions();
        }
    }
}