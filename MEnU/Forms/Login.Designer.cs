namespace MEnU
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnCloseLogin = new Button();
            label3 = new Label();
            panel3 = new Panel();
            txtEmailLogin = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            txtPasswordLogin = new TextBox();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            btnForgetPassword = new Button();
            label4 = new Label();
            btnRegisterLinker = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.Cursor = Cursors.Hand;
            btnCloseLogin.FlatAppearance.BorderSize = 0;
            btnCloseLogin.FlatStyle = FlatStyle.Flat;
            btnCloseLogin.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseLogin.ForeColor = Color.FromArgb(41, 128, 185);
            btnCloseLogin.Location = new Point(359, 0);
            btnCloseLogin.Margin = new Padding(3, 2, 3, 2);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(35, 30);
            btnCloseLogin.TabIndex = 0;
            btnCloseLogin.Text = "X";
            btnCloseLogin.UseVisualStyleBackColor = true;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(33, 101);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 2;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtEmailLogin);
            panel3.Controls.Add(pictureBox2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 139);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 34);
            panel3.TabIndex = 3;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailLogin.ForeColor = Color.FromArgb(41, 128, 185);
            txtEmailLogin.Location = new Point(52, 4);
            txtEmailLogin.Margin = new Padding(3, 2, 3, 2);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(324, 24);
            txtEmailLogin.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(13, 8);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtPasswordLogin);
            panel4.Controls.Add(pictureBox3);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 185);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(394, 34);
            panel4.TabIndex = 4;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordLogin.ForeColor = Color.FromArgb(41, 128, 185);
            txtPasswordLogin.Location = new Point(52, 6);
            txtPasswordLogin.Margin = new Padding(3, 2, 3, 2);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.Size = new Size(324, 24);
            txtPasswordLogin.TabIndex = 4;
            txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._8819786;
            pictureBox3.Location = new Point(13, 8);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(82, 236);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgetPassword
            // 
            btnForgetPassword.BackColor = SystemColors.Control;
            btnForgetPassword.FlatAppearance.BorderSize = 0;
            btnForgetPassword.FlatStyle = FlatStyle.Flat;
            btnForgetPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForgetPassword.ForeColor = Color.FromArgb(41, 128, 185);
            btnForgetPassword.Location = new Point(220, 236);
            btnForgetPassword.Margin = new Padding(3, 2, 3, 2);
            btnForgetPassword.Name = "btnForgetPassword";
            btnForgetPassword.Size = new Size(124, 35);
            btnForgetPassword.TabIndex = 6;
            btnForgetPassword.Text = "Quên mật khẩu?";
            btnForgetPassword.UseVisualStyleBackColor = false;
            btnForgetPassword.Click += btnForgetPassword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(61, 284);
            label4.Name = "label4";
            label4.Size = new Size(156, 18);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản? ";
            // 
            // btnRegisterLinker
            // 
            btnRegisterLinker.BackColor = SystemColors.Control;
            btnRegisterLinker.FlatAppearance.BorderSize = 0;
            btnRegisterLinker.FlatStyle = FlatStyle.Flat;
            btnRegisterLinker.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRegisterLinker.ForeColor = Color.FromArgb(41, 128, 185);
            btnRegisterLinker.Location = new Point(220, 275);
            btnRegisterLinker.Margin = new Padding(3, 2, 3, 2);
            btnRegisterLinker.Name = "btnRegisterLinker";
            btnRegisterLinker.Size = new Size(108, 35);
            btnRegisterLinker.TabIndex = 8;
            btnRegisterLinker.Text = "Đăng ký";
            btnRegisterLinker.UseVisualStyleBackColor = false;
            btnRegisterLinker.Click += btnRegisterLinker_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRegisterLinker);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnForgetPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCloseLogin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(262, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 398);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3d_chat_bubble_share_148391_347;
            pictureBox1.Location = new Point(83, 30);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 164);
            label1.Name = "label1";
            label1.Size = new Size(231, 18);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng đến với MEnU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(26, 199);
            label2.Name = "label2";
            label2.Size = new Size(209, 18);
            label2.TabIndex = 1;
            label2.Text = "Không gian chia sẻ ảnh";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 180);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 398);
            panel1.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 398);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button btnCloseLogin;
        private Label label3;
        private Panel panel3;
        private TextBox txtEmailLogin;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox txtPasswordLogin;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private Button btnForgetPassword;
        private Label label4;
        private Button btnRegisterLinker;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}