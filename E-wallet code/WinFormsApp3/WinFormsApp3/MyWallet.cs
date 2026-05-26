using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MyWallet : Form
    {
        private int userId;

        public MyWallet() : this(0) { }

        public MyWallet(int id)
        {
            InitializeComponent();
            this.userId = id;
            userID_txt.Text = id.ToString();
            userID_txt.ReadOnly = true;
        }

        private void MyWallet_Load(object sender, EventArgs e)
        {
            userID_txt.Text = this.userId.ToString();
            userID_txt.ReadOnly = true;
        }

        private void ViewInfo_Click(object sender, EventArgs e)
        {
            new Information(userId).Show();
        }

        private void ViewBalance_Click(object sender, EventArgs e)
        {
            new Balance(userId).Show();
        }

        private void ViewTransactions_Click(object sender, EventArgs e)
        {
            new Transactions(userId).Show();
        }

        private void ViewBanks_Click(object sender, EventArgs e)
        {
            new Banks(userId).Show();
        }

        private void userID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}