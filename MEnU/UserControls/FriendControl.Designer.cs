namespace MEnU.UserControls
{
    partial class FriendControl
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
            picAvatar = new PictureBox();
            lblUsername = new Label();
            llbDisplayName = new LinkLabel();
            btnChat = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatar.Image = Properties.Resources.AvatarIcon;
            picAvatar.Location = new Point(3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(43, 43);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 19;
            picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.Control;
            lblUsername.Location = new Point(52, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "label1";
            // 
            // llbDisplayName
            // 
            llbDisplayName.ActiveLinkColor = Color.DeepSkyBlue;
            llbDisplayName.AutoSize = true;
            llbDisplayName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDisplayName.LinkColor = Color.White;
            llbDisplayName.Location = new Point(52, 6);
            llbDisplayName.Name = "llbDisplayName";
            llbDisplayName.Size = new Size(65, 17);
            llbDisplayName.TabIndex = 21;
            llbDisplayName.TabStop = true;
            llbDisplayName.Text = "linkLabel1";
            llbDisplayName.LinkClicked += llbDisplayName_LinkClicked;
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.DeepSkyBlue;
            btnChat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChat.ForeColor = SystemColors.Control;
            btnChat.Location = new Point(172, 22);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(75, 23);
            btnChat.TabIndex = 22;
            btnChat.Text = "Nhắn tin";
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click;
            // 
            // FriendControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnChat);
            Controls.Add(llbDisplayName);
            Controls.Add(lblUsername);
            Controls.Add(picAvatar);
            Name = "FriendControl";
            Size = new Size(250, 50);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label lblUsername;
        private LinkLabel llbDisplayName;
        private Button btnChat;
    }
}
