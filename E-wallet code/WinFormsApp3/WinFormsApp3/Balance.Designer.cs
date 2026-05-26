namespace WinFormsApp3
{
    partial class Balance
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
            balance_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // balance_txt
            // 
            balance_txt.Location = new Point(321, 145);
            balance_txt.Name = "balance_txt";
            balance_txt.Size = new Size(125, 27);
            balance_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 152);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Balance";
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(balance_txt);
            Name = "Balance";
            Text = "Balance";
            Load += Balance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox balance_txt;
        private Label label1;
    }
}