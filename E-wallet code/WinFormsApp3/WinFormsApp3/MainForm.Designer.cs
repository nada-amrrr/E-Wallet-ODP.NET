namespace WinFormsApp3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Signup_btn = new Button();
            signin_btn = new Button();
            SuspendLayout();
            // 
            // Signup_btn
            // 
            Signup_btn.Location = new Point(346, 70);
            Signup_btn.Margin = new Padding(3, 2, 3, 2);
            Signup_btn.Name = "Signup_btn";
            Signup_btn.Size = new Size(82, 22);
            Signup_btn.TabIndex = 0;
            Signup_btn.Text = "Sign Up";
            Signup_btn.UseVisualStyleBackColor = true;
            Signup_btn.Click += Signup_btn_Click;
            // 
            // signin_btn
            // 
            signin_btn.Location = new Point(346, 125);
            signin_btn.Margin = new Padding(3, 2, 3, 2);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(82, 22);
            signin_btn.TabIndex = 1;
            signin_btn.Text = "Sign In";
            signin_btn.UseVisualStyleBackColor = true;
            signin_btn.Click += signin_btn_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(signin_btn);
            Controls.Add(Signup_btn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "E-Wallet";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Signup_btn;
        private Button signin_btn;
    }
}
