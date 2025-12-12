namespace MEnU.Forms
{
    partial class ForgetUI
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
            panel1 = new Panel();
            btnLoginForget = new Button();
            label1 = new Label();
            btnSendForget = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtEmailLogin = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = Properties.Resources._8;
            panel1.Controls.Add(btnLoginForget);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSendForget);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 664);
            panel1.TabIndex = 1;
            // 
            // btnLoginForget
            // 
            btnLoginForget.AutoSize = true;
            btnLoginForget.BackColor = Color.Transparent;
            btnLoginForget.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoginForget.FlatAppearance.BorderSize = 0;
            btnLoginForget.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnLoginForget.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnLoginForget.FlatStyle = FlatStyle.Flat;
            btnLoginForget.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLoginForget.ForeColor = Color.White;
            btnLoginForget.Location = new Point(173, 623);
            btnLoginForget.Name = "btnLoginForget";
            btnLoginForget.Size = new Size(110, 39);
            btnLoginForget.TabIndex = 15;
            btnLoginForget.Text = "Đăng nhập";
            btnLoginForget.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 246);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 14;
            label1.Text = "Nhập email";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSendForget
            // 
            btnSendForget.AutoSize = true;
            btnSendForget.BackColor = Color.FromArgb(105, 203, 253);
            btnSendForget.BackgroundImageLayout = ImageLayout.Zoom;
            btnSendForget.FlatAppearance.BorderSize = 0;
            btnSendForget.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSendForget.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSendForget.FlatStyle = FlatStyle.Flat;
            btnSendForget.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendForget.ForeColor = Color.White;
            btnSendForget.Location = new Point(33, 360);
            btnSendForget.Name = "btnSendForget";
            btnSendForget.Size = new Size(390, 39);
            btnSendForget.TabIndex = 10;
            btnSendForget.Text = "Gửi";
            btnSendForget.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtEmailLogin);
            panel2.Location = new Point(33, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 50);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.EmailIcon;
            pictureBox2.Location = new Point(11, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BorderStyle = BorderStyle.None;
            txtEmailLogin.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailLogin.Location = new Point(65, 15);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(305, 22);
            txtEmailLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(179, 162);
            label2.Name = "label2";
            label2.Size = new Size(99, 43);
            label2.TabIndex = 4;
            label2.Text = "MEnU";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.MenuLogo;
            pictureBox1.Location = new Point(146, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ForgetUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 663);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSendForget;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtEmailLogin;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLoginForget;
    }
}