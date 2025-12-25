namespace MEnU.Forms
{
    partial class PlaceHolder
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
            picImage = new PictureBox();
            txtUsernamePostImage = new TextBox();
            txtShowCaption = new TextBox();
            txtReactChat = new TextBox();
            panel1 = new Panel();
            btnSendReactChat = new Button();
            btnReactSad = new Button();
            btnReactHaha = new Button();
            btnReactHeart = new Button();
            btnReactHug = new Button();
            txtInputCaption = new TextBox();
            btnPostimage = new Button();
            btnLoadimage = new Button();
            btnUp = new Button();
            btnDown = new Button();
            picRefPic = new PictureBox();
            lblDisplayName = new Label();
            lblMessage = new Label();
            picAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.BackColor = SystemColors.GradientActiveCaption;
            picImage.Location = new Point(69, 12);
            picImage.Name = "picImage";
            picImage.Size = new Size(453, 416);
            picImage.TabIndex = 1;
            picImage.TabStop = false;
            // 
            // txtUsernamePostImage
            // 
            txtUsernamePostImage.BackColor = SystemColors.GradientInactiveCaption;
            txtUsernamePostImage.BorderStyle = BorderStyle.None;
            txtUsernamePostImage.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsernamePostImage.ForeColor = Color.FromArgb(10, 29, 60);
            txtUsernamePostImage.Location = new Point(201, 12);
            txtUsernamePostImage.Multiline = true;
            txtUsernamePostImage.Name = "txtUsernamePostImage";
            txtUsernamePostImage.ReadOnly = true;
            txtUsernamePostImage.Size = new Size(176, 36);
            txtUsernamePostImage.TabIndex = 26;
            txtUsernamePostImage.TextAlign = HorizontalAlignment.Center;
            // 
            // txtShowCaption
            // 
            txtShowCaption.BackColor = SystemColors.GradientInactiveCaption;
            txtShowCaption.BorderStyle = BorderStyle.None;
            txtShowCaption.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShowCaption.ForeColor = Color.FromArgb(10, 29, 60);
            txtShowCaption.Location = new Point(69, 392);
            txtShowCaption.Multiline = true;
            txtShowCaption.Name = "txtShowCaption";
            txtShowCaption.ReadOnly = true;
            txtShowCaption.Size = new Size(448, 36);
            txtShowCaption.TabIndex = 27;
            txtShowCaption.TextAlign = HorizontalAlignment.Center;
            // 
            // txtReactChat
            // 
            txtReactChat.BorderStyle = BorderStyle.None;
            txtReactChat.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReactChat.ForeColor = Color.FromArgb(10, 29, 60);
            txtReactChat.Location = new Point(82, 464);
            txtReactChat.Multiline = true;
            txtReactChat.Name = "txtReactChat";
            txtReactChat.Size = new Size(295, 41);
            txtReactChat.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSendReactChat);
            panel1.Controls.Add(btnReactSad);
            panel1.Controls.Add(btnReactHaha);
            panel1.Controls.Add(btnReactHeart);
            panel1.Controls.Add(btnReactHug);
            panel1.Location = new Point(508, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 41);
            panel1.TabIndex = 29;
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
            btnSendReactChat.Location = new Point(8, 0);
            btnSendReactChat.Name = "btnSendReactChat";
            btnSendReactChat.Size = new Size(32, 41);
            btnSendReactChat.TabIndex = 18;
            btnSendReactChat.UseVisualStyleBackColor = false;
            // 
            // btnReactSad
            // 
            btnReactSad.BackColor = Color.FromArgb(16, 48, 99);
            btnReactSad.BackgroundImage = Properties.Resources.SadIcon;
            btnReactSad.BackgroundImageLayout = ImageLayout.Zoom;
            btnReactSad.FlatAppearance.BorderSize = 0;
            btnReactSad.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnReactSad.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnReactSad.FlatStyle = FlatStyle.Flat;
            btnReactSad.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactSad.ForeColor = Color.White;
            btnReactSad.Location = new Point(135, 0);
            btnReactSad.Name = "btnReactSad";
            btnReactSad.Size = new Size(31, 41);
            btnReactSad.TabIndex = 23;
            btnReactSad.UseVisualStyleBackColor = false;
            // 
            // btnReactHaha
            // 
            btnReactHaha.BackColor = Color.FromArgb(16, 48, 99);
            btnReactHaha.BackgroundImage = Properties.Resources.HahaIcon;
            btnReactHaha.BackgroundImageLayout = ImageLayout.Zoom;
            btnReactHaha.FlatAppearance.BorderSize = 0;
            btnReactHaha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnReactHaha.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnReactHaha.FlatStyle = FlatStyle.Flat;
            btnReactHaha.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactHaha.ForeColor = Color.White;
            btnReactHaha.Location = new Point(72, 0);
            btnReactHaha.Name = "btnReactHaha";
            btnReactHaha.Size = new Size(30, 41);
            btnReactHaha.TabIndex = 21;
            btnReactHaha.UseVisualStyleBackColor = false;
            // 
            // btnReactHeart
            // 
            btnReactHeart.BackColor = Color.FromArgb(16, 48, 99);
            btnReactHeart.BackgroundImage = Properties.Resources.HeartIcon;
            btnReactHeart.BackgroundImageLayout = ImageLayout.Zoom;
            btnReactHeart.FlatAppearance.BorderSize = 0;
            btnReactHeart.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnReactHeart.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnReactHeart.FlatStyle = FlatStyle.Flat;
            btnReactHeart.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactHeart.ForeColor = Color.White;
            btnReactHeart.Location = new Point(44, 0);
            btnReactHeart.Name = "btnReactHeart";
            btnReactHeart.Size = new Size(28, 41);
            btnReactHeart.TabIndex = 19;
            btnReactHeart.UseVisualStyleBackColor = false;
            // 
            // btnReactHug
            // 
            btnReactHug.BackColor = Color.FromArgb(16, 48, 99);
            btnReactHug.BackgroundImage = Properties.Resources.HugIcon;
            btnReactHug.BackgroundImageLayout = ImageLayout.Zoom;
            btnReactHug.FlatAppearance.BorderSize = 0;
            btnReactHug.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnReactHug.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnReactHug.FlatStyle = FlatStyle.Flat;
            btnReactHug.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactHug.ForeColor = Color.White;
            btnReactHug.Location = new Point(101, 0);
            btnReactHug.Name = "btnReactHug";
            btnReactHug.Size = new Size(34, 41);
            btnReactHug.TabIndex = 20;
            btnReactHug.UseVisualStyleBackColor = false;
            // 
            // txtInputCaption
            // 
            txtInputCaption.BorderStyle = BorderStyle.None;
            txtInputCaption.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputCaption.Location = new Point(180, 464);
            txtInputCaption.Multiline = true;
            txtInputCaption.Name = "txtInputCaption";
            txtInputCaption.Size = new Size(270, 41);
            txtInputCaption.TabIndex = 30;
            // 
            // btnPostimage
            // 
            btnPostimage.AutoSize = true;
            btnPostimage.BackColor = Color.Transparent;
            btnPostimage.BackgroundImage = Properties.Resources.PostIcon;
            btnPostimage.BackgroundImageLayout = ImageLayout.Zoom;
            btnPostimage.FlatAppearance.BorderSize = 0;
            btnPostimage.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnPostimage.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnPostimage.FlatStyle = FlatStyle.Flat;
            btnPostimage.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostimage.ForeColor = Color.White;
            btnPostimage.Location = new Point(607, 51);
            btnPostimage.Name = "btnPostimage";
            btnPostimage.Size = new Size(78, 57);
            btnPostimage.TabIndex = 31;
            btnPostimage.UseVisualStyleBackColor = false;
            // 
            // btnLoadimage
            // 
            btnLoadimage.AutoSize = true;
            btnLoadimage.BackColor = Color.Transparent;
            btnLoadimage.BackgroundImage = Properties.Resources.LoadIcon;
            btnLoadimage.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoadimage.FlatAppearance.BorderSize = 0;
            btnLoadimage.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnLoadimage.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnLoadimage.FlatStyle = FlatStyle.Flat;
            btnLoadimage.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadimage.ForeColor = Color.White;
            btnLoadimage.Location = new Point(607, 148);
            btnLoadimage.Name = "btnLoadimage";
            btnLoadimage.Size = new Size(92, 57);
            btnLoadimage.TabIndex = 32;
            btnLoadimage.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            btnUp.AutoSize = true;
            btnUp.BackColor = Color.Transparent;
            btnUp.BackgroundImage = Properties.Resources.UpIcon;
            btnUp.BackgroundImageLayout = ImageLayout.Zoom;
            btnUp.FlatAppearance.BorderSize = 0;
            btnUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUp.ForeColor = Color.White;
            btnUp.Location = new Point(628, 256);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(71, 45);
            btnUp.TabIndex = 33;
            btnUp.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            btnDown.AutoSize = true;
            btnDown.BackColor = Color.Transparent;
            btnDown.BackgroundImage = Properties.Resources.DownIcon;
            btnDown.BackgroundImageLayout = ImageLayout.Zoom;
            btnDown.FlatAppearance.BorderSize = 0;
            btnDown.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnDown.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnDown.FlatStyle = FlatStyle.Flat;
            btnDown.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDown.ForeColor = Color.White;
            btnDown.Location = new Point(628, 307);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(71, 44);
            btnDown.TabIndex = 34;
            btnDown.UseVisualStyleBackColor = false;
            // 
            // picRefPic
            // 
            picRefPic.Location = new Point(69, 529);
            picRefPic.Name = "picRefPic";
            picRefPic.Size = new Size(214, 214);
            picRefPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picRefPic.TabIndex = 38;
            picRefPic.TabStop = false;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayName.ForeColor = SystemColors.Control;
            lblDisplayName.Location = new Point(110, 751);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(79, 15);
            lblDisplayName.TabIndex = 36;
            lblDisplayName.Text = "DisplayName";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.Control;
            lblMessage.Location = new Point(110, 766);
            lblMessage.MaximumSize = new Size(360, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(13, 15);
            lblMessage.TabIndex = 37;
            lblMessage.Text = "a";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatar.Image = Properties.Resources.AvatarIcon;
            picAvatar.Location = new Point(72, 749);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(32, 32);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 35;
            picAvatar.TabStop = false;
            // 
            // PlaceHolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 793);
            Controls.Add(picRefPic);
            Controls.Add(lblDisplayName);
            Controls.Add(lblMessage);
            Controls.Add(picAvatar);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(btnLoadimage);
            Controls.Add(btnPostimage);
            Controls.Add(txtReactChat);
            Controls.Add(panel1);
            Controls.Add(txtInputCaption);
            Controls.Add(txtShowCaption);
            Controls.Add(txtUsernamePostImage);
            Controls.Add(picImage);
            Name = "PlaceHolder";
            Text = "PlaceHolder";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRefPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImage;
        private TextBox txtUsernamePostImage;
        private TextBox txtShowCaption;
        private TextBox txtReactChat;
        private Panel panel1;
        private Button btnSendReactChat;
        private Button btnReactSad;
        private Button btnReactHaha;
        private Button btnReactHeart;
        private Button btnReactHug;
        private TextBox txtInputCaption;
        private Button btnPostimage;
        private Button btnLoadimage;
        private Button btnUp;
        private Button btnDown;
        private PictureBox picRefPic;
        private Label lblDisplayName;
        private Label lblMessage;
        private PictureBox picAvatar;
    }
}