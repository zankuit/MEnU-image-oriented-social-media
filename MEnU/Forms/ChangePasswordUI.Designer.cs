namespace MEnU.Forms
{
    partial class ChangePasswordUI
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
            groupBox5 = new GroupBox();
            txtConfirmNewPassword = new TextBox();
            pictureBox6 = new PictureBox();
            groupBox4 = new GroupBox();
            txtNewPassword = new TextBox();
            pictureBox5 = new PictureBox();
            groupBox1 = new GroupBox();
            txtCurrentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnConfirmChangePassword = new Button();
            chkShowPassword = new CheckBox();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(txtConfirmNewPassword);
            groupBox5.Controls.Add(pictureBox6);
            groupBox5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(27, 253);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(341, 43);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Xác nhận mật khẩu mới";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BorderStyle = BorderStyle.None;
            txtConfirmNewPassword.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.Location = new Point(60, 20);
            txtConfirmNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(267, 17);
            txtConfirmNewPassword.TabIndex = 2;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.confirmicon;
            pictureBox6.Location = new Point(11, 16);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(txtNewPassword);
            groupBox4.Controls.Add(pictureBox5);
            groupBox4.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(27, 203);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(341, 43);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(60, 20);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(267, 17);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Password_Icon;
            pictureBox5.Location = new Point(11, 16);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCurrentPassword);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 138);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(341, 43);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mật khẩu hiện tại";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BorderStyle = BorderStyle.None;
            txtCurrentPassword.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(60, 20);
            txtCurrentPassword.Margin = new Padding(3, 2, 3, 2);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(267, 17);
            txtCurrentPassword.TabIndex = 2;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Password_Icon;
            pictureBox1.Location = new Point(11, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(94, 79);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 19;
            label2.Text = "Đổi mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.MenuLogo;
            pictureBox2.Location = new Point(127, -21);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnConfirmChangePassword
            // 
            btnConfirmChangePassword.AutoSize = true;
            btnConfirmChangePassword.BackColor = Color.FromArgb(105, 203, 253);
            btnConfirmChangePassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnConfirmChangePassword.FlatAppearance.BorderSize = 0;
            btnConfirmChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnConfirmChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnConfirmChangePassword.FlatStyle = FlatStyle.Flat;
            btnConfirmChangePassword.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmChangePassword.ForeColor = Color.White;
            btnConfirmChangePassword.Location = new Point(27, 345);
            btnConfirmChangePassword.Margin = new Padding(3, 2, 3, 2);
            btnConfirmChangePassword.Name = "btnConfirmChangePassword";
            btnConfirmChangePassword.Size = new Size(341, 29);
            btnConfirmChangePassword.TabIndex = 20;
            btnConfirmChangePassword.Text = "Xác nhận";
            btnConfirmChangePassword.UseVisualStyleBackColor = false;
            btnConfirmChangePassword.Click += btnConfirmChangePassword_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.FromArgb(16, 48, 99);
            chkShowPassword.ForeColor = SystemColors.Control;
            chkShowPassword.Location = new Point(27, 301);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 19);
            chkShowPassword.TabIndex = 21;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // ChangePasswordUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(395, 402);
            Controls.Add(chkShowPassword);
            Controls.Add(btnConfirmChangePassword);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordUI";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private TextBox txtConfirmNewPassword;
        private PictureBox pictureBox6;
        private GroupBox groupBox4;
        private TextBox txtNewPassword;
        private PictureBox pictureBox5;
        private GroupBox groupBox1;
        private TextBox txtCurrentPassword;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnConfirmChangePassword;
        private CheckBox chkShowPassword;
    }
}