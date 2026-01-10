namespace MEnU.UserControls
{
    partial class MessageBubbleControl
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
            tblMessagePart = new TableLayoutPanel();
            lblMessage = new Label();
            picRefPic = new PictureBox();
            flpHeader = new FlowLayoutPanel();
            picAvatar = new PictureBox();
            lblDisplayName = new Label();
            tblMessagePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefPic).BeginInit();
            flpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // tblMessagePart
            // 
            tblMessagePart.AutoSize = true;
            tblMessagePart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMessagePart.ColumnCount = 1;
            tblMessagePart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMessagePart.Controls.Add(lblMessage, 0, 2);
            tblMessagePart.Controls.Add(picRefPic, 0, 1);
            tblMessagePart.Controls.Add(flpHeader, 0, 0);
            tblMessagePart.Location = new Point(3, 3);
            tblMessagePart.Name = "tblMessagePart";
            tblMessagePart.RowCount = 3;
            tblMessagePart.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblMessagePart.RowStyles.Add(new RowStyle());
            tblMessagePart.RowStyles.Add(new RowStyle());
            tblMessagePart.Size = new Size(200, 249);
            tblMessagePart.TabIndex = 22;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.Control;
            lblMessage.Location = new Point(3, 234);
            lblMessage.MaximumSize = new Size(360, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(13, 15);
            lblMessage.TabIndex = 40;
            lblMessage.Text = "a";
            // 
            // picRefPic
            // 
            picRefPic.Location = new Point(3, 37);
            picRefPic.MaximumSize = new Size(194, 194);
            picRefPic.Name = "picRefPic";
            picRefPic.Size = new Size(194, 194);
            picRefPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picRefPic.TabIndex = 39;
            picRefPic.TabStop = false;
            // 
            // flpHeader
            // 
            flpHeader.Controls.Add(picAvatar);
            flpHeader.Controls.Add(lblDisplayName);
            flpHeader.Dock = DockStyle.Top;
            flpHeader.Location = new Point(0, 0);
            flpHeader.Margin = new Padding(0);
            flpHeader.Name = "flpHeader";
            flpHeader.Size = new Size(200, 34);
            flpHeader.TabIndex = 0;
            flpHeader.WrapContents = false;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatar.Image = Properties.Resources.AvatarIcon;
            picAvatar.Location = new Point(3, 3);
            picAvatar.Name = "picAvatar";
            picAvatar.Padding = new Padding(0, 0, 6, 0);
            picAvatar.Size = new Size(32, 32);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 36;
            picAvatar.TabStop = false;
            // 
            // lblDisplayName
            // 
            lblDisplayName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayName.ForeColor = SystemColors.Control;
            lblDisplayName.Location = new Point(41, 0);
            lblDisplayName.MaximumSize = new Size(150, 0);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(137, 34);
            lblDisplayName.TabIndex = 37;
            lblDisplayName.Text = "Zanku06";
            lblDisplayName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MessageBubbleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(16, 48, 99);
            Controls.Add(tblMessagePart);
            Name = "MessageBubbleControl";
            Size = new Size(206, 255);
            tblMessagePart.ResumeLayout(false);
            tblMessagePart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRefPic).EndInit();
            flpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tblMessagePart;
        private FlowLayoutPanel flpHeader;
        private PictureBox picAvatar;
        private Label lblDisplayName;
        private PictureBox picRefPic;
        private Label lblMessage;
    }
}
