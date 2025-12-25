namespace MEnU.UserControls
{
    partial class ChatListControl
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
            llbDisplayName = new LinkLabel();
            lblLastMessage = new Label();
            picAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
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
            llbDisplayName.TabIndex = 24;
            llbDisplayName.TabStop = true;
            llbDisplayName.Text = "linkLabel1";
            llbDisplayName.LinkClicked += llbDisplayName_LinkClicked;
            // 
            // lblLastMessage
            // 
            lblLastMessage.AutoSize = true;
            lblLastMessage.ForeColor = SystemColors.Control;
            lblLastMessage.Location = new Point(52, 26);
            lblLastMessage.Name = "lblLastMessage";
            lblLastMessage.Size = new Size(50, 15);
            lblLastMessage.TabIndex = 23;
            lblLastMessage.Text = "labelllllll";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatar.Image = Properties.Resources.AvatarIcon;
            picAvatar.Location = new Point(3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(43, 43);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 22;
            picAvatar.TabStop = false;
            // 
            // ChatListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            Controls.Add(llbDisplayName);
            Controls.Add(lblLastMessage);
            Controls.Add(picAvatar);
            Name = "ChatListControl";
            Size = new Size(200, 50);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llbDisplayName;
        private Label lblLastMessage;
        private PictureBox picAvatar;
    }
}
