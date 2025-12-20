namespace MEnU
{
    partial class frmHome
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
            btnSetting = new Button();
            btnHome = new Button();
            lblUsername = new Label();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCloseHome = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 180);
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 398);
            panel1.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(41, 128, 185);
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = SystemColors.Control;
            btnSetting.Image = Properties.Resources.R;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(70, 190);
            btnSetting.Margin = new Padding(3, 2, 3, 2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(148, 35);
            btnSetting.TabIndex = 11;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Image = Properties.Resources.home_150499_1280;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(70, 151);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(148, 35);
            btnHome.TabIndex = 10;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Transparent;
            lblUsername.Location = new Point(81, 98);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 23);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(83, 344);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 35);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.User;
            pictureBox1.Location = new Point(96, 27);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCloseHome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(262, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 398);
            panel2.TabIndex = 1;
            // 
            // btnCloseHome
            // 
            btnCloseHome.Cursor = Cursors.Hand;
            btnCloseHome.FlatAppearance.BorderSize = 0;
            btnCloseHome.FlatStyle = FlatStyle.Flat;
            btnCloseHome.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseHome.ForeColor = Color.FromArgb(41, 128, 185);
            btnCloseHome.Location = new Point(359, 0);
            btnCloseHome.Margin = new Padding(3, 2, 3, 2);
            btnCloseHome.Name = "btnCloseHome";
            btnCloseHome.Size = new Size(35, 30);
            btnCloseHome.TabIndex = 0;
            btnCloseHome.Text = "X";
            btnCloseHome.UseVisualStyleBackColor = true;
            btnCloseHome.Click += btnCloseHome_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 398);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCloseHome;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnLogout;
        private Label lblUsername;
        private Button btnHome;
        private Button btnSetting;
    }
}