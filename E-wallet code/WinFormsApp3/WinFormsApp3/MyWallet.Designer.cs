namespace WinFormsApp3
{
    partial class MyWallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ViewInfo = new Button();
            ViewBalance = new Button();
            ViewTransactions = new Button();
            ViewBanks = new Button();
            userID_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ViewInfo
            // 
            ViewInfo.Location = new Point(262, 90);
            ViewInfo.Margin = new Padding(3, 2, 3, 2);
            ViewInfo.Name = "ViewInfo";
            ViewInfo.Size = new Size(160, 22);
            ViewInfo.TabIndex = 0;
            ViewInfo.Text = "View Info";
            ViewInfo.UseVisualStyleBackColor = true;
            ViewInfo.Click += ViewInfo_Click;
            // 
            // ViewBalance
            // 
            ViewBalance.Location = new Point(262, 152);
            ViewBalance.Margin = new Padding(3, 2, 3, 2);
            ViewBalance.Name = "ViewBalance";
            ViewBalance.Size = new Size(160, 22);
            ViewBalance.TabIndex = 1;
            ViewBalance.Text = "View Balance";
            ViewBalance.UseVisualStyleBackColor = true;
            ViewBalance.Click += ViewBalance_Click;
            // 
            // ViewTransactions
            // 
            ViewTransactions.Location = new Point(261, 208);
            ViewTransactions.Margin = new Padding(3, 2, 3, 2);
            ViewTransactions.Name = "ViewTransactions";
            ViewTransactions.Size = new Size(161, 22);
            ViewTransactions.TabIndex = 2;
            ViewTransactions.Text = "View Transactions";
            ViewTransactions.UseVisualStyleBackColor = true;
            ViewTransactions.Click += ViewTransactions_Click;
            // 
            // ViewBanks
            // 
            ViewBanks.Location = new Point(262, 262);
            ViewBanks.Margin = new Padding(3, 2, 3, 2);
            ViewBanks.Name = "ViewBanks";
            ViewBanks.Size = new Size(160, 22);
            ViewBanks.TabIndex = 3;
            ViewBanks.Text = "View Banks";
            ViewBanks.UseVisualStyleBackColor = true;
            ViewBanks.Click += ViewBanks_Click;
            // 
            // userID_txt
            // 
            userID_txt.Location = new Point(572, 18);
            userID_txt.Margin = new Padding(3, 2, 3, 2);
            userID_txt.Name = "userID_txt";
            userID_txt.Size = new Size(110, 23);
            userID_txt.TabIndex = 4;
            userID_txt.TextChanged += userID_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "User ID";
            // 
            // MyWallet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(userID_txt);
            Controls.Add(ViewBanks);
            Controls.Add(ViewTransactions);
            Controls.Add(ViewBalance);
            Controls.Add(ViewInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyWallet";
            Text = "MyWallet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewInfo;
        private Button ViewBalance;
        private Button ViewTransactions;
        private Button ViewBanks;
        private TextBox userID_txt;
        private Label label1;
    }
}