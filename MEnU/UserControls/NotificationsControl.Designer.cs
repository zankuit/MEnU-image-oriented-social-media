namespace MEnU.UserControls
{
    partial class NotificationsControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUsername = new Label();
            lblNotificationMessage = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblTime = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblUsername);
            flowLayoutPanel1.Controls.Add(lblNotificationMessage);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 8, 0, 0);
            flowLayoutPanel1.Size = new Size(435, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Control;
            lblUsername.Location = new Point(8, 8);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(194, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "DisplayNameeeeeeeeee";
            // 
            // lblNotificationMessage
            // 
            lblNotificationMessage.AutoSize = true;
            lblNotificationMessage.Font = new Font("Segoe UI", 12F);
            lblNotificationMessage.ForeColor = SystemColors.Control;
            lblNotificationMessage.Location = new Point(208, 8);
            lblNotificationMessage.Name = "lblNotificationMessage";
            lblNotificationMessage.Size = new Size(208, 21);
            lblNotificationMessage.TabIndex = 1;
            lblNotificationMessage.Text = "accepted your friend request";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblTime);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(441, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 4, 0, 0);
            flowLayoutPanel2.Size = new Size(114, 40);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.PaleTurquoise;
            lblTime.Location = new Point(-9, 4);
            lblTime.MinimumSize = new Size(120, 30);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(120, 30);
            lblTime.TabIndex = 1;
            lblTime.Text = "1 ngày trước";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NotificationsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(16, 48, 99);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "NotificationsControl";
            Size = new Size(558, 43);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUsername;
        private Label lblNotificationMessage;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblTime;
    }
}
