namespace WinFormsApp3
{
    partial class Information
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
            username_txt = new TextBox();
            email_txt = new TextBox();
            password_txt = new TextBox();
            pin_txt = new TextBox();
            Save = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(324, 78);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(125, 27);
            username_txt.TabIndex = 0;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(324, 153);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(125, 27);
            email_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(324, 239);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(125, 27);
            password_txt.TabIndex = 2;
            // 
            // pin_txt
            // 
            pin_txt.Location = new Point(324, 314);
            pin_txt.Name = "pin_txt";
            pin_txt.Size = new Size(125, 27);
            pin_txt.TabIndex = 3;
            // 
            // Save
            // 
            Save.Location = new Point(694, 409);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 4;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 160);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 246);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 321);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 8;
            label4.Text = "pin";
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Save);
            Controls.Add(pin_txt);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(username_txt);
            Name = "Information";
            Text = "Information";
            Load += Information_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox email_txt;
        private TextBox password_txt;
        private TextBox pin_txt;
        private Button Save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}