namespace MEnU.Forms
{
    partial class UserProfileUI
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
            picBackground = new PictureBox();
            picAvatar = new PictureBox();
            lblDisplayName = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            btnAddFriend = new Button();
            btnDeclineFriendRequest = new Button();
            lblFriendRequestQuote = new Label();
            btnAcceptFriendRequest = new Button();
            btnDeleteFriend = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Image = Properties.Resources.MenuLogo;
            picBackground.Location = new Point(-2, -1);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(460, 101);
            picBackground.SizeMode = PictureBoxSizeMode.CenterImage;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Azure;
            picAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatar.Image = Properties.Resources.AvatarIcon;
            picAvatar.Location = new Point(12, 62);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(101, 102);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 19;
            picAvatar.TabStop = false;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.BackColor = Color.Transparent;
            lblDisplayName.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayName.ForeColor = Color.White;
            lblDisplayName.Location = new Point(119, 112);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(108, 19);
            lblDisplayName.TabIndex = 20;
            lblDisplayName.Text = "DISPLAYNAME";
            lblDisplayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(119, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 15);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "@USERNAME";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(12, 176);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 19);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "EMAIL";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddFriend
            // 
            btnAddFriend.BackColor = SystemColors.ActiveCaption;
            btnAddFriend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFriend.Location = new Point(180, 232);
            btnAddFriend.Name = "btnAddFriend";
            btnAddFriend.Size = new Size(96, 30);
            btnAddFriend.TabIndex = 21;
            btnAddFriend.Text = "Kết bạn";
            btnAddFriend.UseVisualStyleBackColor = false;
            btnAddFriend.Click += btnAddFriend_Click;
            // 
            // btnDeclineFriendRequest
            // 
            btnDeclineFriendRequest.BackColor = Color.LightCoral;
            btnDeclineFriendRequest.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeclineFriendRequest.Location = new Point(247, 232);
            btnDeclineFriendRequest.Name = "btnDeclineFriendRequest";
            btnDeclineFriendRequest.Size = new Size(96, 30);
            btnDeclineFriendRequest.TabIndex = 21;
            btnDeclineFriendRequest.Text = "Từ chối";
            btnDeclineFriendRequest.UseVisualStyleBackColor = false;
            btnDeclineFriendRequest.Click += btnDeclineFriendRequest_Click;
            // 
            // lblFriendRequestQuote
            // 
            lblFriendRequestQuote.AutoSize = true;
            lblFriendRequestQuote.BackColor = Color.Transparent;
            lblFriendRequestQuote.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFriendRequestQuote.ForeColor = Color.White;
            lblFriendRequestQuote.Location = new Point(213, 202);
            lblFriendRequestQuote.Name = "lblFriendRequestQuote";
            lblFriendRequestQuote.Size = new Size(232, 18);
            lblFriendRequestQuote.TabIndex = 20;
            lblFriendRequestQuote.Text = "Người này muốn kết bạn... <3";
            lblFriendRequestQuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAcceptFriendRequest
            // 
            btnAcceptFriendRequest.BackColor = Color.LightGreen;
            btnAcceptFriendRequest.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceptFriendRequest.Location = new Point(349, 232);
            btnAcceptFriendRequest.Name = "btnAcceptFriendRequest";
            btnAcceptFriendRequest.Size = new Size(96, 30);
            btnAcceptFriendRequest.TabIndex = 21;
            btnAcceptFriendRequest.Text = "Chấp nhận";
            btnAcceptFriendRequest.UseVisualStyleBackColor = false;
            btnAcceptFriendRequest.Click += btnAcceptFriendRequest_Click;
            // 
            // btnDeleteFriend
            // 
            btnDeleteFriend.BackColor = Color.DarkRed;
            btnDeleteFriend.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFriend.ForeColor = Color.White;
            btnDeleteFriend.Location = new Point(12, 232);
            btnDeleteFriend.Name = "btnDeleteFriend";
            btnDeleteFriend.Size = new Size(89, 30);
            btnDeleteFriend.TabIndex = 21;
            btnDeleteFriend.Text = "Bo xì :<";
            btnDeleteFriend.UseVisualStyleBackColor = false;
            btnDeleteFriend.Click += btnDeleteFriend_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(197, 239);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(248, 18);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Đang chờ phản hồi từ người này";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserProfileUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(457, 274);
            Controls.Add(lblStatus);
            Controls.Add(btnAcceptFriendRequest);
            Controls.Add(btnDeclineFriendRequest);
            Controls.Add(btnDeleteFriend);
            Controls.Add(btnAddFriend);
            Controls.Add(lblFriendRequestQuote);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblDisplayName);
            Controls.Add(picAvatar);
            Controls.Add(picBackground);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserProfileUI";
            Text = "UserProfileUI";
            Load += UserProfileUI_Load;
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBackground;
        private PictureBox picAvatar;
        private Label lblDisplayName;
        private Label lblUsername;
        private Label lblEmail;
        private Button btnAddFriend;
        private Button btnDeclineFriendRequest;
        private Label lblFriendRequestQuote;
        private Button btnAcceptFriendRequest;
        private Button btnDeleteFriend;
        private Label lblStatus;
    }
}