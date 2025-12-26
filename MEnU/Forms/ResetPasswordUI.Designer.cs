namespace MEnU.Forms
{
    partial class ResetPasswordUI
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
            pictureBox1 = new PictureBox();
            groupBox5 = new GroupBox();
            txtConfirmNewPassword = new TextBox();
            pictureBox6 = new PictureBox();
            groupBox4 = new GroupBox();
            txtNewPassword = new TextBox();
            pictureBox5 = new PictureBox();
            chkShowPassword = new CheckBox();
            btnConfirmResetPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(96, 81);
            label2.Name = "label2";
            label2.Size = new Size(239, 36);
            label2.TabIndex = 6;
            label2.Text = "Reset mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.MenuLogo;
            pictureBox1.Location = new Point(147, -19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(txtConfirmNewPassword);
            groupBox5.Controls.Add(pictureBox6);
            groupBox5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(45, 200);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(341, 43);
            groupBox5.TabIndex = 18;
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
            groupBox4.Location = new Point(45, 150);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(341, 43);
            groupBox4.TabIndex = 19;
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
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.FromArgb(16, 48, 99);
            chkShowPassword.ForeColor = SystemColors.Control;
            chkShowPassword.Location = new Point(45, 248);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 19);
            chkShowPassword.TabIndex = 22;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnConfirmResetPassword
            // 
            btnConfirmResetPassword.AutoSize = true;
            btnConfirmResetPassword.BackColor = Color.FromArgb(105, 203, 253);
            btnConfirmResetPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnConfirmResetPassword.FlatAppearance.BorderSize = 0;
            btnConfirmResetPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnConfirmResetPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnConfirmResetPassword.FlatStyle = FlatStyle.Flat;
            btnConfirmResetPassword.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmResetPassword.ForeColor = Color.White;
            btnConfirmResetPassword.Location = new Point(45, 294);
            btnConfirmResetPassword.Margin = new Padding(3, 2, 3, 2);
            btnConfirmResetPassword.Name = "btnConfirmResetPassword";
            btnConfirmResetPassword.Size = new Size(341, 29);
            btnConfirmResetPassword.TabIndex = 23;
            btnConfirmResetPassword.Text = "Xác nhận";
            btnConfirmResetPassword.UseVisualStyleBackColor = false;
            btnConfirmResetPassword.Click += btnConfirmResetPassword_Click;
            // 
            // ResetPasswordUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(430, 348);
            Controls.Add(btnConfirmResetPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordUI";
            FormClosing += ResetPasswordUI_Closing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox5;
        private TextBox txtConfirmNewPassword;
        private PictureBox pictureBox6;
        private GroupBox groupBox4;
        private TextBox txtNewPassword;
        private PictureBox pictureBox5;
        private CheckBox chkShowPassword;
        private Button btnConfirmResetPassword;
    }
}