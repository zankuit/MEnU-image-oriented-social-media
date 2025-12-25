namespace MEnU.UserControls
{
    partial class FrienRequestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefuseUser = new Button();
            btnAcceptUser = new Button();
            lblUsernameRequest = new Label();
            label1 = new Label();
            picUserRequest = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUserRequest).BeginInit();
            SuspendLayout();
            // 
            // btnRefuseUser
            // 
            btnRefuseUser.AutoSize = true;
            btnRefuseUser.BackColor = Color.Transparent;
            btnRefuseUser.BackgroundImage = Properties.Resources.RefuseIcon;
            btnRefuseUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefuseUser.FlatAppearance.BorderSize = 0;
            btnRefuseUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnRefuseUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnRefuseUser.FlatStyle = FlatStyle.Flat;
            btnRefuseUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefuseUser.ForeColor = Color.White;
            btnRefuseUser.Location = new Point(247, 11);
            btnRefuseUser.Name = "btnRefuseUser";
            btnRefuseUser.Size = new Size(46, 32);
            btnRefuseUser.TabIndex = 22;
            btnRefuseUser.UseVisualStyleBackColor = false;
            // 
            // btnAcceptUser
            // 
            btnAcceptUser.AutoSize = true;
            btnAcceptUser.BackColor = Color.Transparent;
            btnAcceptUser.BackgroundImage = Properties.Resources.AcceptIcon;
            btnAcceptUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAcceptUser.FlatAppearance.BorderSize = 0;
            btnAcceptUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnAcceptUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnAcceptUser.FlatStyle = FlatStyle.Flat;
            btnAcceptUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceptUser.ForeColor = Color.White;
            btnAcceptUser.Location = new Point(196, 11);
            btnAcceptUser.Name = "btnAcceptUser";
            btnAcceptUser.Size = new Size(49, 32);
            btnAcceptUser.TabIndex = 21;
            btnAcceptUser.UseVisualStyleBackColor = false;
            // 
            // lblUsernameRequest
            // 
            lblUsernameRequest.AutoSize = true;
            lblUsernameRequest.BackColor = Color.Transparent;
            lblUsernameRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameRequest.ForeColor = Color.White;
            lblUsernameRequest.Location = new Point(44, 11);
            lblUsernameRequest.Name = "lblUsernameRequest";
            lblUsernameRequest.Size = new Size(40, 15);
            lblUsernameRequest.TabIndex = 20;
            lblUsernameRequest.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 20;
            label1.Text = "wants to be your friend <3";
            // 
            // picUserRequest
            // 
            picUserRequest.BackColor = Color.Transparent;
            picUserRequest.BackgroundImageLayout = ImageLayout.Zoom;
            picUserRequest.Image = Properties.Resources.AvatarIcon;
            picUserRequest.Location = new Point(0, 6);
            picUserRequest.Name = "picUserRequest";
            picUserRequest.Size = new Size(43, 43);
            picUserRequest.SizeMode = PictureBoxSizeMode.Zoom;
            picUserRequest.TabIndex = 23;
            picUserRequest.TabStop = false;
            // 
            // WaitingForAcceptUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            Controls.Add(picUserRequest);
            Controls.Add(btnRefuseUser);
            Controls.Add(btnAcceptUser);
            Controls.Add(label1);
            Controls.Add(lblUsernameRequest);
            Name = "WaitingForAcceptUserControl";
            Size = new Size(297, 55);
            ((System.ComponentModel.ISupportInitialize)picUserRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefuseUser;
        private Button btnAcceptUser;
        private Label lblUsernameRequest;
        private Label label1;
        private PictureBox picUserRequest;
    }
}
