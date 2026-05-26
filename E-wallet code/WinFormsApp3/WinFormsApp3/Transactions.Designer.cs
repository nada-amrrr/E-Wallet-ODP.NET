namespace WinFormsApp3
{
    partial class Transactions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            cmbFilter = new ComboBox();
            btnSearch = new Button();
            btnSave = new Button();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "Search by Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(210, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 23);
            txtUsername.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(370, 20);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(150, 23);
            cmbFilter.TabIndex = 2;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(530, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 28);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(640, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(20, 60);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(750, 320);
            dgvTransactions.TabIndex = 5;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTransactions);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(cmbFilter);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Transactions";
            Text = "Transactions";
            Load += Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private ComboBox cmbFilter;
        private Button btnSearch;
        private Button btnSave;
        private DataGridView dgvTransactions;
    }
}