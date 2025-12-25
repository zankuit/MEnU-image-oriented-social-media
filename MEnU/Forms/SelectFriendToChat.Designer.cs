namespace MEnU.Forms
{
    partial class SelectFriendToChatUI
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
            flpFriendList = new FlowLayoutPanel();
            lblNoFriend = new Label();
            flpFriendList.SuspendLayout();
            SuspendLayout();
            // 
            // flpFriendList
            // 
            flpFriendList.AutoScroll = true;
            flpFriendList.Controls.Add(lblNoFriend);
            flpFriendList.Dock = DockStyle.Fill;
            flpFriendList.FlowDirection = FlowDirection.TopDown;
            flpFriendList.Location = new Point(0, 0);
            flpFriendList.Name = "flpFriendList";
            flpFriendList.Size = new Size(254, 411);
            flpFriendList.TabIndex = 0;
            flpFriendList.WrapContents = false;
            // 
            // lblNoFriend
            // 
            lblNoFriend.AutoSize = true;
            lblNoFriend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoFriend.ForeColor = SystemColors.Control;
            lblNoFriend.Location = new Point(3, 0);
            lblNoFriend.Name = "lblNoFriend";
            lblNoFriend.Size = new Size(126, 20);
            lblNoFriend.TabIndex = 0;
            lblNoFriend.Text = "Chưa có bạn bè ...";
            // 
            // SelectFriendToChatUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(254, 411);
            Controls.Add(flpFriendList);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectFriendToChatUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectFriendToChat";
            Load += SelectFriendToChatUI_Load;
            flpFriendList.ResumeLayout(false);
            flpFriendList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpFriendList;
        private Label lblNoFriend;
    }
}