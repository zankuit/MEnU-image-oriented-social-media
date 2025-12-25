namespace dangky
{
    partial class dangky
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
            btnDangky = new Button();
            btnDangnhap = new Button();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbTennguoidung = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(624, 431);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(150, 46);
            btnDangky.TabIndex = 0;
            btnDangky.Text = "Dang ky";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(276, 431);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(150, 46);
            btnDangnhap.TabIndex = 1;
            btnDangnhap.Text = "Dangnhap";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(301, 97);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(655, 39);
            tbEmail.TabIndex = 2;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(264, 218);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(692, 39);
            tbPassword.TabIndex = 3;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 97);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 221);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 5;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 30);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 6;
            // 
            // tbTennguoidung
            // 
            tbTennguoidung.Location = new Point(352, 38);
            tbTennguoidung.Name = "tbTennguoidung";
            tbTennguoidung.Size = new Size(592, 39);
            tbTennguoidung.TabIndex = 7;
            tbTennguoidung.TextChanged += tbTennguoidung_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 30);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 8;
            label4.Text = "ten nguoi dung";
            // 
            // dangky
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 582);
            Controls.Add(label4);
            Controls.Add(tbTennguoidung);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(btnDangnhap);
            Controls.Add(btnDangky);
            Name = "dangky";
            Text = "dangky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangky;
        private Button btnDangnhap;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTennguoidung;
        private Label label4;
    }
}