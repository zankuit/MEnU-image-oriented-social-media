namespace MEnU
{
    partial class frmForgetPassword
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
            btnSendForgetPassword = new Button();
            panel3 = new Panel();
            txtEmailForgetPassword = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            closebtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Click += label1_Click;
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
            panel2.Controls.Add(btnSendForgetPassword);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(closebtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(262, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 398);
            panel2.TabIndex = 1;
            // 
            // btnSendForgetPassword
            // 
            btnSendForgetPassword.BackColor = Color.FromArgb(41, 128, 185);
            btnSendForgetPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendForgetPassword.ForeColor = Color.White;
            btnSendForgetPassword.Location = new Point(116, 188);
            btnSendForgetPassword.Margin = new Padding(3, 2, 3, 2);
            btnSendForgetPassword.Name = "btnSendForgetPassword";
            btnSendForgetPassword.Size = new Size(124, 35);
            btnSendForgetPassword.TabIndex = 5;
            btnSendForgetPassword.Text = "Gửi ";
            btnSendForgetPassword.UseVisualStyleBackColor = false;
            btnSendForgetPassword.Click += btnSendForgetPassword_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtEmailForgetPassword);
            panel3.Controls.Add(pictureBox2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 139);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 34);
            panel3.TabIndex = 3;
            // 
            // txtEmailForgetPassword
            // 
            txtEmailForgetPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailForgetPassword.ForeColor = Color.FromArgb(41, 128, 185);
            txtEmailForgetPassword.Location = new Point(52, 4);
            txtEmailForgetPassword.Margin = new Padding(3, 2, 3, 2);
            txtEmailForgetPassword.Name = "txtEmailForgetPassword";
            txtEmailForgetPassword.Size = new Size(324, 24);
            txtEmailForgetPassword.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(13, 115);
            label3.Name = "label3";
            label3.Size = new Size(134, 17);
            label3.TabIndex = 2;
            label3.Text = "Điền địa chỉ email";
            // 
            // closebtn
            // 
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(359, 0);
            closebtn.Margin = new Padding(3, 2, 3, 2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 30);
            closebtn.TabIndex = 0;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 398);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button closebtn;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtEmailForgetPassword;
        private Button btnSendForgetPassword;
        private ContextMenuStrip contextMenuStrip1;
    }
}