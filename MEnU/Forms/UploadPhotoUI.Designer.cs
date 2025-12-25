namespace MEnU.Forms
{
    partial class UploadPhotoUI
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
            picPhoto = new PictureBox();
            btnSendReactChat = new Button();
            txtReactChat = new TextBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // picPhoto
            // 
            picPhoto.Location = new Point(15, 12);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(400, 400);
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoto.TabIndex = 0;
            picPhoto.TabStop = false;
            // 
            // btnSendReactChat
            // 
            btnSendReactChat.BackColor = Color.White;
            btnSendReactChat.BackgroundImage = Properties.Resources.UpIcon;
            btnSendReactChat.BackgroundImageLayout = ImageLayout.Zoom;
            btnSendReactChat.FlatAppearance.BorderSize = 0;
            btnSendReactChat.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSendReactChat.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSendReactChat.FlatStyle = FlatStyle.Flat;
            btnSendReactChat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendReactChat.ForeColor = Color.White;
            btnSendReactChat.Location = new Point(326, 464);
            btnSendReactChat.Name = "btnSendReactChat";
            btnSendReactChat.Size = new Size(56, 32);
            btnSendReactChat.TabIndex = 40;
            btnSendReactChat.UseVisualStyleBackColor = false;
            btnSendReactChat.Click += btnSendReactChat_Click;
            // 
            // txtReactChat
            // 
            txtReactChat.BorderStyle = BorderStyle.None;
            txtReactChat.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReactChat.ForeColor = Color.FromArgb(10, 29, 60);
            txtReactChat.Location = new Point(47, 464);
            txtReactChat.Multiline = true;
            txtReactChat.Name = "txtReactChat";
            txtReactChat.Size = new Size(304, 32);
            txtReactChat.TabIndex = 39;
            // 
            // button1
            // 
            button1.Location = new Point(131, 418);
            button1.Name = "button1";
            button1.Size = new Size(184, 23);
            button1.TabIndex = 41;
            button1.Text = "Choose Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(47, 441);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 42;
            label1.Text = "Caption:";
            // 
            // UploadPhotoUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(431, 508);
            Controls.Add(label1);
            Controls.Add(btnSendReactChat);
            Controls.Add(button1);
            Controls.Add(txtReactChat);
            Controls.Add(picPhoto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UploadPhotoUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UploadPhotoUI";
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPhoto;
        private Button btnSendReactChat;
        private TextBox txtReactChat;
        private Button button1;
        private Label label1;
    }
}