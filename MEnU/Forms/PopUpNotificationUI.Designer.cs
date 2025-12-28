namespace MEnU.Forms
{
    partial class PopUpNotificationUI
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
            notificationsControl1 = new MEnU.UserControls.NotificationsControl();
            SuspendLayout();
            // 
            // notificationsControl1
            // 
            notificationsControl1.AutoSize = true;
            notificationsControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            notificationsControl1.BackColor = Color.FromArgb(16, 48, 99);
            notificationsControl1.BorderStyle = BorderStyle.FixedSingle;
            notificationsControl1.Location = new Point(-1, 0);
            notificationsControl1.Name = "notificationsControl1";
            notificationsControl1.Size = new Size(560, 45);
            notificationsControl1.TabIndex = 0;
            // 
            // PopUpNotificationUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(558, 45);
            Controls.Add(notificationsControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUpNotificationUI";
            Text = "PopUpNotificationUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.NotificationsControl notificationsControl1;
    }
}