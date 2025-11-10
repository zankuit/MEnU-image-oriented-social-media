namespace MEnU
{
    partial class frmRegister
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLoginLinker = new Button();
            label4 = new Label();
            btnRegister = new Button();
            panel3 = new Panel();
            txtEmailRegister = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtPasswordRegister = new TextBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            txtDisplayNameRegister = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnCloseRegister = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(21, 194);
            label2.Name = "label2";
            label2.Size = new Size(209, 18);
            label2.TabIndex = 1;
            label2.Text = "Không gian chia sẻ ảnh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(4, 163);
            label1.Name = "label1";
            label1.Size = new Size(231, 18);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng đến với MEnU";
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
            // panel2
            // 
            panel2.Controls.Add(btnLoginLinker);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCloseRegister);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(262, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 398);
            panel2.TabIndex = 1;
            // 
            // btnLoginLinker
            // 
            btnLoginLinker.BackColor = SystemColors.Control;
            btnLoginLinker.FlatAppearance.BorderSize = 0;
            btnLoginLinker.FlatStyle = FlatStyle.Flat;
            btnLoginLinker.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLoginLinker.ForeColor = Color.FromArgb(41, 128, 185);
            btnLoginLinker.Location = new Point(228, 339);
            btnLoginLinker.Margin = new Padding(3, 2, 3, 2);
            btnLoginLinker.Name = "btnLoginLinker";
            btnLoginLinker.Size = new Size(82, 35);
            btnLoginLinker.TabIndex = 10;
            btnLoginLinker.Text = "Đăng nhập";
            btnLoginLinker.UseVisualStyleBackColor = false;
            btnLoginLinker.Click += btnLoginLinker_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(98, 347);
            label4.Name = "label4";
            label4.Size = new Size(133, 18);
            label4.TabIndex = 9;
            label4.Text = "Đã có tài khoản?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(41, 128, 185);
            btnRegister.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(141, 296);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(124, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtEmailRegister);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtPasswordRegister);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtDisplayNameRegister);
            panel3.Controls.Add(pictureBox2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 225);
            panel3.TabIndex = 3;
            // 
            // txtEmailRegister
            // 
            txtEmailRegister.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailRegister.ForeColor = Color.FromArgb(41, 128, 185);
            txtEmailRegister.Location = new Point(60, 88);
            txtEmailRegister.Margin = new Padding(3, 2, 3, 2);
            txtEmailRegister.Name = "txtEmailRegister";
            txtEmailRegister.Size = new Size(317, 24);
            txtEmailRegister.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 141);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 93);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordRegister.ForeColor = Color.FromArgb(41, 128, 185);
            txtPasswordRegister.Location = new Point(52, 166);
            txtPasswordRegister.Margin = new Padding(3, 2, 3, 2);
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.PasswordChar = '*';
            txtPasswordRegister.Size = new Size(324, 24);
            txtPasswordRegister.TabIndex = 4;
            txtPasswordRegister.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 13);
            label5.Name = "label5";
            label5.Size = new Size(205, 19);
            label5.TabIndex = 4;
            label5.Text = "Tên người dùng (tên hiển thị)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._8819786;
            pictureBox3.Location = new Point(13, 166);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // txtDisplayNameRegister
            // 
            txtDisplayNameRegister.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplayNameRegister.ForeColor = Color.FromArgb(41, 128, 185);
            txtDisplayNameRegister.Location = new Point(52, 38);
            txtDisplayNameRegister.Margin = new Padding(3, 2, 3, 2);
            txtDisplayNameRegister.Name = "txtDisplayNameRegister";
            txtDisplayNameRegister.Size = new Size(324, 24);
            txtDisplayNameRegister.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(13, 41);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "ĐĂNG KÝ";
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.FlatAppearance.BorderSize = 0;
            btnCloseRegister.FlatStyle = FlatStyle.Flat;
            btnCloseRegister.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseRegister.ForeColor = Color.FromArgb(41, 128, 185);
            btnCloseRegister.Location = new Point(359, 0);
            btnCloseRegister.Margin = new Padding(3, 2, 3, 2);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(35, 30);
            btnCloseRegister.TabIndex = 0;
            btnCloseRegister.Text = "X";
            btnCloseRegister.UseVisualStyleBackColor = true;
            btnCloseRegister.Click += btnCloseRegister_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 398);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnCloseRegister;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtPasswordRegister;
        private PictureBox pictureBox3;
        private TextBox txtDisplayNameRegister;
        private Button btnRegister;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
        private TextBox txtEmailRegister;
        private Label label8;
        private Label label6;
        private Button btnLoginLinker;
        private Label label4;
    }
}