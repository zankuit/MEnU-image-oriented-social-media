namespace MEnU.Forms
{
    partial class LoginUI
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
            label1 = new Label();
            btnSignupLogin = new Button();
            btnForgetLogin = new Button();
            btnLoginLogin = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtPasswordLogin = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtEmailLogin = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = Properties.Resources._8;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSignupLogin);
            panel1.Controls.Add(btnForgetLogin);
            panel1.Controls.Add(btnLoginLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 663);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 632);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 13;
            label1.Text = "Chưa có tài khoản?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignupLogin
            // 
            btnSignupLogin.AutoSize = true;
            btnSignupLogin.BackColor = Color.Transparent;
            btnSignupLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnSignupLogin.FlatAppearance.BorderSize = 0;
            btnSignupLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSignupLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSignupLogin.FlatStyle = FlatStyle.Flat;
            btnSignupLogin.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSignupLogin.ForeColor = Color.White;
            btnSignupLogin.Location = new Point(228, 622);
            btnSignupLogin.Name = "btnSignupLogin";
            btnSignupLogin.Size = new Size(140, 39);
            btnSignupLogin.TabIndex = 12;
            btnSignupLogin.Text = "Đăng ký ngay";
            btnSignupLogin.UseVisualStyleBackColor = false;
            btnSignupLogin.Click += btnSignupLogin_Click;
            // 
            // btnForgetLogin
            // 
            btnForgetLogin.AutoSize = true;
            btnForgetLogin.BackColor = Color.Transparent;
            btnForgetLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnForgetLogin.FlatAppearance.BorderSize = 0;
            btnForgetLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnForgetLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnForgetLogin.FlatStyle = FlatStyle.Flat;
            btnForgetLogin.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgetLogin.ForeColor = Color.White;
            btnForgetLogin.Location = new Point(266, 457);
            btnForgetLogin.Name = "btnForgetLogin";
            btnForgetLogin.Size = new Size(174, 39);
            btnForgetLogin.TabIndex = 11;
            btnForgetLogin.Text = "Quên mật khẩu?";
            btnForgetLogin.UseVisualStyleBackColor = false;
            btnForgetLogin.Click += btnForgetLogin_Click;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.AutoSize = true;
            btnLoginLogin.BackColor = Color.FromArgb(105, 203, 253);
            btnLoginLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoginLogin.FlatAppearance.BorderSize = 0;
            btnLoginLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnLoginLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginLogin.ForeColor = Color.White;
            btnLoginLogin.Location = new Point(33, 412);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(390, 39);
            btnLoginLogin.TabIndex = 10;
            btnLoginLogin.Text = "Đăng nhập";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtPasswordLogin);
            panel3.Location = new Point(33, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 50);
            panel3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Password_Icon;
            pictureBox3.Location = new Point(13, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.BorderStyle = BorderStyle.None;
            txtPasswordLogin.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordLogin.Location = new Point(62, 14);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.Size = new Size(305, 17);
            txtPasswordLogin.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtEmailLogin);
            panel2.Location = new Point(33, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 50);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.EmailIcon;
            pictureBox2.Location = new Point(13, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BorderStyle = BorderStyle.None;
            txtEmailLogin.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailLogin.Location = new Point(62, 15);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(305, 17);
            txtEmailLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(183, 144);
            label2.Name = "label2";
            label2.Size = new Size(79, 36);
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
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 663);
            Controls.Add(panel1);
            Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEnU - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmailLogin;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtPasswordLogin;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnLoginLogin;
        private Button btnForgetLogin;
        private Label label1;
        private Button btnSignupLogin;
    }
}