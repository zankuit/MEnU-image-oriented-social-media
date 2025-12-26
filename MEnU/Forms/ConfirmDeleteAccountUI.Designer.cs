namespace MEnU.Forms
{
    partial class ConfirmDeleteAccountUI
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            btnConfirmDeleteAccount = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(64, 25);
            label2.Name = "label2";
            label2.Size = new Size(415, 36);
            label2.TabIndex = 5;
            label2.Text = "Cân nhắc hành động này!!!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(101, 93);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(341, 43);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Username của bạn";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(60, 20);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 17);
            txtUsername.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.User_Icon;
            pictureBox2.Location = new Point(11, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnConfirmDeleteAccount
            // 
            btnConfirmDeleteAccount.AutoSize = true;
            btnConfirmDeleteAccount.BackColor = Color.FromArgb(192, 0, 0);
            btnConfirmDeleteAccount.BackgroundImageLayout = ImageLayout.Zoom;
            btnConfirmDeleteAccount.FlatAppearance.BorderSize = 0;
            btnConfirmDeleteAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnConfirmDeleteAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnConfirmDeleteAccount.FlatStyle = FlatStyle.Flat;
            btnConfirmDeleteAccount.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmDeleteAccount.ForeColor = Color.White;
            btnConfirmDeleteAccount.Location = new Point(101, 180);
            btnConfirmDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            btnConfirmDeleteAccount.Name = "btnConfirmDeleteAccount";
            btnConfirmDeleteAccount.Size = new Size(341, 29);
            btnConfirmDeleteAccount.TabIndex = 18;
            btnConfirmDeleteAccount.Text = "Tôi xác nhận xóa tài khoản này";
            btnConfirmDeleteAccount.UseVisualStyleBackColor = false;
            btnConfirmDeleteAccount.Click += btnConfirmDeleteAccount_Click;
            // 
            // ConfirmDeleteAccountUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(542, 241);
            Controls.Add(btnConfirmDeleteAccount);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmDeleteAccountUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xóa tài khoản";
            Load += ConfirmDeleteAccountUI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private Button btnConfirmDeleteAccount;
    }
}