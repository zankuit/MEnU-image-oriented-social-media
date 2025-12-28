namespace MEnU.UserControl
{
    partial class SearchedUsers
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
            pnlTemplateAddFriend = new Panel();
            llbUserDetail = new LinkLabel();
            picSearchedUser = new PictureBox();
            lblDisplayNameSearchedUser = new Label();
            pnlTemplateAddFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchedUser).BeginInit();
            SuspendLayout();
            // 
            // pnlTemplateAddFriend
            // 
            pnlTemplateAddFriend.BackColor = Color.FromArgb(16, 48, 99);
            pnlTemplateAddFriend.Controls.Add(llbUserDetail);
            pnlTemplateAddFriend.Controls.Add(picSearchedUser);
            pnlTemplateAddFriend.Controls.Add(lblDisplayNameSearchedUser);
            pnlTemplateAddFriend.Location = new Point(0, 0);
            pnlTemplateAddFriend.Name = "pnlTemplateAddFriend";
            pnlTemplateAddFriend.Size = new Size(280, 46);
            pnlTemplateAddFriend.TabIndex = 17;
            // 
            // llbUserDetail
            // 
            llbUserDetail.ActiveLinkColor = Color.Cyan;
            llbUserDetail.AutoSize = true;
            llbUserDetail.LinkColor = Color.White;
            llbUserDetail.Location = new Point(211, 15);
            llbUserDetail.Name = "llbUserDetail";
            llbUserDetail.Size = new Size(45, 15);
            llbUserDetail.TabIndex = 19;
            llbUserDetail.TabStop = true;
            llbUserDetail.Text = "Chi tiết";
            llbUserDetail.LinkClicked += llbUserDetail_LinkClicked;
            // 
            // picSearchedUser
            // 
            picSearchedUser.BackColor = Color.Transparent;
            picSearchedUser.BackgroundImageLayout = ImageLayout.Zoom;
            picSearchedUser.Image = Properties.Resources.AvatarIcon;
            picSearchedUser.Location = new Point(7, 2);
            picSearchedUser.Name = "picSearchedUser";
            picSearchedUser.Size = new Size(43, 43);
            picSearchedUser.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchedUser.TabIndex = 18;
            picSearchedUser.TabStop = false;
            // 
            // lblDisplayNameSearchedUser
            // 
            lblDisplayNameSearchedUser.AutoSize = true;
            lblDisplayNameSearchedUser.BackColor = Color.Transparent;
            lblDisplayNameSearchedUser.ForeColor = Color.White;
            lblDisplayNameSearchedUser.Location = new Point(56, 15);
            lblDisplayNameSearchedUser.Name = "lblDisplayNameSearchedUser";
            lblDisplayNameSearchedUser.Size = new Size(39, 15);
            lblDisplayNameSearchedUser.TabIndex = 0;
            lblDisplayNameSearchedUser.Text = "Name";
            // 
            // SearchedUsers
            // 
            Controls.Add(pnlTemplateAddFriend);
            Name = "SearchedUsers";
            Size = new Size(280, 46);
            pnlTemplateAddFriend.ResumeLayout(false);
            pnlTemplateAddFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchedUser).EndInit();
            ResumeLayout(false);
            // Remove: this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion

        private Panel pnlTemplateAddFriend;
        private Label lblDisplayNameSearchedUser;
        private PictureBox picSearchedUser;
        private LinkLabel llbUserDetail;
    }
}
