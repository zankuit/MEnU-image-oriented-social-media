namespace MEnU.Forms
{
    partial class MainHomeUI
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tabMenu = new TabControl();
            tpHome = new TabPage();
            btnRefreshHome = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblDisplayNamePost = new Label();
            lblTimePost = new Label();
            lblNoPhotoYet = new Label();
            txtShowCaption = new TextBox();
            btnUp = new Button();
            llbViewReactions = new LinkLabel();
            picAvatarPost = new PictureBox();
            btnDeletePost = new Button();
            btnDownloadPost = new Button();
            btnSendReactChat = new Button();
            txtReactChat = new TextBox();
            btnLoadimage = new Button();
            btnDown = new Button();
            picImage = new PictureBox();
            panel1 = new Panel();
            btnReactSad = new Button();
            btnReactHaha = new Button();
            btnReactHeart = new Button();
            btnReactHug = new Button();
            tpChat = new TabPage();
            sctChatView = new SplitContainer();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            flpListFriendChat = new FlowLayoutPanel();
            llbStartChat = new LinkLabel();
            picAvatarTitleChat = new PictureBox();
            lblDisplayNameTitleChat = new Label();
            txtContent = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSendContent = new Button();
            tpFriendlist = new TabPage();
            sctFriendView = new SplitContainer();
            flpListFriend = new FlowLayoutPanel();
            lblNoFriend = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            flpUserSeachedList = new FlowLayoutPanel();
            flpListUserRequest = new FlowLayoutPanel();
            txtFindUser = new TextBox();
            btnFind = new Button();
            tpNotification = new TabPage();
            flpNotificationView = new FlowLayoutPanel();
            btnReloadNotification = new Button();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            tpSetting = new TabPage();
            btnSendFeedback = new Button();
            groupBox2 = new GroupBox();
            btnChangePassword = new Button();
            btnDeleteUser = new Button();
            groupBox1 = new GroupBox();
            txtDisplayname = new TextBox();
            picAvatarSetting = new PictureBox();
            label10 = new Label();
            btnCancelUpdateInfo = new Button();
            btnSaveUpdateInfo = new Button();
            btnChangeInfo = new Button();
            btnSetavt = new Button();
            label9 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            rtxLog = new RichTextBox();
            btnLogoutMain = new Button();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            lblUsername = new Label();
            panel2 = new Panel();
            searchedUsers1 = new MEnU.UserControl.SearchedUsers();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMenu.SuspendLayout();
            tpHome.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            panel1.SuspendLayout();
            tpChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sctChatView).BeginInit();
            sctChatView.Panel1.SuspendLayout();
            sctChatView.Panel2.SuspendLayout();
            sctChatView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flpListFriendChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarTitleChat).BeginInit();
            tpFriendlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sctFriendView).BeginInit();
            sctFriendView.Panel1.SuspendLayout();
            sctFriendView.Panel2.SuspendLayout();
            sctFriendView.SuspendLayout();
            flpListFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flpUserSeachedList.SuspendLayout();
            tpNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tpSetting.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarSetting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(7, 48);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 6;
            label2.Text = "MEnU";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.MenuLogo;
            pictureBox1.Location = new Point(-21, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tpHome);
            tabMenu.Controls.Add(tpChat);
            tabMenu.Controls.Add(tpFriendlist);
            tabMenu.Controls.Add(tpNotification);
            tabMenu.Controls.Add(tpSetting);
            tabMenu.Location = new Point(151, -2);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(633, 667);
            tabMenu.TabIndex = 7;
            tabMenu.SelectedIndexChanged += tabMenu_SelectedIndexChanged;
            // 
            // tpHome
            // 
            tpHome.BackColor = Color.FromArgb(16, 48, 99);
            tpHome.Controls.Add(btnRefreshHome);
            tpHome.Controls.Add(flowLayoutPanel2);
            tpHome.Controls.Add(lblNoPhotoYet);
            tpHome.Controls.Add(txtShowCaption);
            tpHome.Controls.Add(btnUp);
            tpHome.Controls.Add(llbViewReactions);
            tpHome.Controls.Add(picAvatarPost);
            tpHome.Controls.Add(btnDeletePost);
            tpHome.Controls.Add(btnDownloadPost);
            tpHome.Controls.Add(btnSendReactChat);
            tpHome.Controls.Add(txtReactChat);
            tpHome.Controls.Add(btnLoadimage);
            tpHome.Controls.Add(btnDown);
            tpHome.Controls.Add(picImage);
            tpHome.Controls.Add(panel1);
            tpHome.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpHome.ForeColor = SystemColors.ControlText;
            tpHome.Location = new Point(4, 26);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(625, 637);
            tpHome.TabIndex = 0;
            tpHome.Text = "Home";
            // 
            // btnRefreshHome
            // 
            btnRefreshHome.AutoSize = true;
            btnRefreshHome.BackColor = Color.Transparent;
            btnRefreshHome.BackgroundImage = Properties.Resources.ReloadIcon;
            btnRefreshHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshHome.FlatAppearance.BorderSize = 0;
            btnRefreshHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnRefreshHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnRefreshHome.FlatStyle = FlatStyle.Flat;
            btnRefreshHome.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshHome.ForeColor = Color.White;
            btnRefreshHome.Location = new Point(6, 24);
            btnRefreshHome.Name = "btnRefreshHome";
            btnRefreshHome.Size = new Size(42, 30);
            btnRefreshHome.TabIndex = 48;
            btnRefreshHome.UseVisualStyleBackColor = false;
            btnRefreshHome.Click += btnRefreshHome_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(lblDisplayNamePost);
            flowLayoutPanel2.Controls.Add(lblTimePost);
            flowLayoutPanel2.Location = new Point(103, 486);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(241, 20);
            flowLayoutPanel2.TabIndex = 47;
            // 
            // lblDisplayNamePost
            // 
            lblDisplayNamePost.AutoSize = true;
            lblDisplayNamePost.BackColor = Color.Transparent;
            lblDisplayNamePost.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayNamePost.ForeColor = Color.White;
            lblDisplayNamePost.Location = new Point(3, 0);
            lblDisplayNamePost.MaximumSize = new Size(198, 0);
            lblDisplayNamePost.MinimumSize = new Size(20, 20);
            lblDisplayNamePost.Name = "lblDisplayNamePost";
            lblDisplayNamePost.Size = new Size(189, 20);
            lblDisplayNamePost.TabIndex = 15;
            lblDisplayNamePost.Text = "Displayyyyyyyyyyyyyy";
            // 
            // lblTimePost
            // 
            lblTimePost.AutoSize = true;
            lblTimePost.BackColor = Color.Transparent;
            lblTimePost.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimePost.ForeColor = Color.PaleTurquoise;
            lblTimePost.Location = new Point(198, 0);
            lblTimePost.MaximumSize = new Size(150, 0);
            lblTimePost.Name = "lblTimePost";
            lblTimePost.Size = new Size(40, 18);
            lblTimePost.TabIndex = 15;
            lblTimePost.Text = "Time";
            lblTimePost.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNoPhotoYet
            // 
            lblNoPhotoYet.AutoSize = true;
            lblNoPhotoYet.BackColor = SystemColors.GradientActiveCaption;
            lblNoPhotoYet.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoPhotoYet.Location = new Point(206, 242);
            lblNoPhotoYet.Name = "lblNoPhotoYet";
            lblNoPhotoYet.Size = new Size(180, 19);
            lblNoPhotoYet.TabIndex = 45;
            lblNoPhotoYet.Text = "Chưa có bức ảnh nào";
            // 
            // txtShowCaption
            // 
            txtShowCaption.BackColor = SystemColors.GradientInactiveCaption;
            txtShowCaption.BorderStyle = BorderStyle.None;
            txtShowCaption.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShowCaption.ForeColor = Color.FromArgb(10, 29, 60);
            txtShowCaption.Location = new Point(70, 437);
            txtShowCaption.Multiline = true;
            txtShowCaption.Name = "txtShowCaption";
            txtShowCaption.ReadOnly = true;
            txtShowCaption.Size = new Size(448, 36);
            txtShowCaption.TabIndex = 43;
            txtShowCaption.TextAlign = HorizontalAlignment.Center;
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
            btnUp.Location = new Point(524, 177);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(71, 45);
            btnUp.TabIndex = 42;
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // llbViewReactions
            // 
            llbViewReactions.ActiveLinkColor = Color.Cyan;
            llbViewReactions.AutoSize = true;
            llbViewReactions.LinkColor = Color.White;
            llbViewReactions.Location = new Point(68, 521);
            llbViewReactions.Name = "llbViewReactions";
            llbViewReactions.Size = new Size(152, 18);
            llbViewReactions.TabIndex = 41;
            llbViewReactions.TabStop = true;
            llbViewReactions.Text = "Xem lượt reactions";
            llbViewReactions.LinkClicked += llbViewReactions_LinkClicked;
            // 
            // picAvatarPost
            // 
            picAvatarPost.BackColor = Color.Transparent;
            picAvatarPost.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatarPost.Image = Properties.Resources.AvatarIcon;
            picAvatarPost.Location = new Point(68, 479);
            picAvatarPost.Name = "picAvatarPost";
            picAvatarPost.Size = new Size(32, 32);
            picAvatarPost.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatarPost.TabIndex = 40;
            picAvatarPost.TabStop = false;
            // 
            // btnDeletePost
            // 
            btnDeletePost.AutoSize = true;
            btnDeletePost.BackColor = Color.Transparent;
            btnDeletePost.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeletePost.FlatAppearance.BorderSize = 0;
            btnDeletePost.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnDeletePost.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnDeletePost.FlatStyle = FlatStyle.Flat;
            btnDeletePost.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDeletePost.ForeColor = Color.Red;
            btnDeletePost.Location = new Point(518, 445);
            btnDeletePost.Name = "btnDeletePost";
            btnDeletePost.Size = new Size(77, 28);
            btnDeletePost.TabIndex = 13;
            btnDeletePost.Text = "Xóa ảnh";
            btnDeletePost.UseVisualStyleBackColor = false;
            btnDeletePost.Click += btnDeletePost_Click;
            // 
            // btnDownloadPost
            // 
            btnDownloadPost.AutoSize = true;
            btnDownloadPost.BackColor = Color.Transparent;
            btnDownloadPost.BackgroundImageLayout = ImageLayout.Zoom;
            btnDownloadPost.FlatAppearance.BorderSize = 0;
            btnDownloadPost.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnDownloadPost.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnDownloadPost.FlatStyle = FlatStyle.Flat;
            btnDownloadPost.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDownloadPost.ForeColor = Color.White;
            btnDownloadPost.Location = new Point(518, 414);
            btnDownloadPost.Name = "btnDownloadPost";
            btnDownloadPost.Size = new Size(98, 28);
            btnDownloadPost.TabIndex = 13;
            btnDownloadPost.Text = "Tải ảnh về";
            btnDownloadPost.UseVisualStyleBackColor = false;
            btnDownloadPost.Click += btnDownloadPost_Click;
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
            btnSendReactChat.Location = new Point(340, 567);
            btnSendReactChat.Name = "btnSendReactChat";
            btnSendReactChat.Size = new Size(32, 41);
            btnSendReactChat.TabIndex = 38;
            btnSendReactChat.UseVisualStyleBackColor = false;
            btnSendReactChat.Click += btnSendReactChat_Click;
            // 
            // txtReactChat
            // 
            txtReactChat.BorderStyle = BorderStyle.None;
            txtReactChat.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReactChat.ForeColor = Color.FromArgb(10, 29, 60);
            txtReactChat.Location = new Point(77, 567);
            txtReactChat.Multiline = true;
            txtReactChat.Name = "txtReactChat";
            txtReactChat.Size = new Size(295, 41);
            txtReactChat.TabIndex = 37;
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
            btnLoadimage.Location = new Point(518, 23);
            btnLoadimage.Name = "btnLoadimage";
            btnLoadimage.Size = new Size(92, 57);
            btnLoadimage.TabIndex = 36;
            btnLoadimage.UseVisualStyleBackColor = false;
            btnLoadimage.Click += btnLoadimage_Click;
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
            btnDown.Location = new Point(524, 252);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(71, 44);
            btnDown.TabIndex = 35;
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += btnDown_Click;
            // 
            // picImage
            // 
            picImage.BackColor = SystemColors.GradientActiveCaption;
            picImage.Location = new Point(68, 23);
            picImage.Name = "picImage";
            picImage.Size = new Size(450, 450);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReactSad);
            panel1.Controls.Add(btnReactHaha);
            panel1.Controls.Add(btnReactHeart);
            panel1.Controls.Add(btnReactHug);
            panel1.Location = new Point(340, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 41);
            panel1.TabIndex = 39;
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
            btnReactSad.Click += btnReactSad_Click;
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
            btnReactHaha.Click += btnReactHaha_Click;
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
            btnReactHeart.Click += btnReactHeart_Click;
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
            btnReactHug.Click += btnReactHug_Click;
            // 
            // tpChat
            // 
            tpChat.BackColor = Color.FromArgb(16, 48, 99);
            tpChat.Controls.Add(sctChatView);
            tpChat.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpChat.Location = new Point(4, 26);
            tpChat.Name = "tpChat";
            tpChat.Padding = new Padding(3);
            tpChat.Size = new Size(625, 637);
            tpChat.TabIndex = 1;
            tpChat.Text = "Chat";
            // 
            // sctChatView
            // 
            sctChatView.BorderStyle = BorderStyle.FixedSingle;
            sctChatView.Location = new Point(1, 0);
            sctChatView.Name = "sctChatView";
            // 
            // sctChatView.Panel1
            // 
            sctChatView.Panel1.Controls.Add(label5);
            sctChatView.Panel1.Controls.Add(pictureBox6);
            sctChatView.Panel1.Controls.Add(flpListFriendChat);
            // 
            // sctChatView.Panel2
            // 
            sctChatView.Panel2.Controls.Add(picAvatarTitleChat);
            sctChatView.Panel2.Controls.Add(lblDisplayNameTitleChat);
            sctChatView.Panel2.Controls.Add(txtContent);
            sctChatView.Panel2.Controls.Add(flowLayoutPanel1);
            sctChatView.Panel2.Controls.Add(btnSendContent);
            sctChatView.Size = new Size(624, 632);
            sctChatView.SplitterDistance = 207;
            sctChatView.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 23);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 18;
            label5.Text = "TIN NHẮN";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Image = Properties.Resources.MessageIcon;
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // flpListFriendChat
            // 
            flpListFriendChat.BackColor = Color.FromArgb(16, 48, 99);
            flpListFriendChat.Controls.Add(llbStartChat);
            flpListFriendChat.FlowDirection = FlowDirection.TopDown;
            flpListFriendChat.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpListFriendChat.Location = new Point(5, 75);
            flpListFriendChat.Name = "flpListFriendChat";
            flpListFriendChat.Size = new Size(202, 542);
            flpListFriendChat.TabIndex = 18;
            flpListFriendChat.WrapContents = false;
            // 
            // llbStartChat
            // 
            llbStartChat.ActiveLinkColor = SystemColors.Highlight;
            llbStartChat.AutoSize = true;
            llbStartChat.LinkColor = SystemColors.Control;
            llbStartChat.Location = new Point(3, 0);
            llbStartChat.Name = "llbStartChat";
            llbStartChat.Size = new Size(98, 15);
            llbStartChat.TabIndex = 19;
            llbStartChat.TabStop = true;
            llbStartChat.Text = "Đoạn chat mới";
            llbStartChat.LinkClicked += llbStartChat_LinkClicked;
            // 
            // picAvatarTitleChat
            // 
            picAvatarTitleChat.BackColor = Color.Transparent;
            picAvatarTitleChat.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatarTitleChat.Image = Properties.Resources.AvatarIcon;
            picAvatarTitleChat.Location = new Point(3, 0);
            picAvatarTitleChat.Name = "picAvatarTitleChat";
            picAvatarTitleChat.Size = new Size(47, 45);
            picAvatarTitleChat.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatarTitleChat.TabIndex = 18;
            picAvatarTitleChat.TabStop = false;
            // 
            // lblDisplayNameTitleChat
            // 
            lblDisplayNameTitleChat.AutoSize = true;
            lblDisplayNameTitleChat.BackColor = Color.Transparent;
            lblDisplayNameTitleChat.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayNameTitleChat.ForeColor = Color.White;
            lblDisplayNameTitleChat.Location = new Point(56, 17);
            lblDisplayNameTitleChat.Name = "lblDisplayNameTitleChat";
            lblDisplayNameTitleChat.Size = new Size(81, 19);
            lblDisplayNameTitleChat.TabIndex = 15;
            lblDisplayNameTitleChat.Text = "USERNAME";
            lblDisplayNameTitleChat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(3, 574);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(343, 43);
            txtContent.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(16, 48, 99);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Google Sans Mono", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(3, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 517);
            flowLayoutPanel1.TabIndex = 18;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnSendContent
            // 
            btnSendContent.BackColor = Color.White;
            btnSendContent.BackgroundImage = Properties.Resources.UpIcon;
            btnSendContent.BackgroundImageLayout = ImageLayout.Zoom;
            btnSendContent.FlatAppearance.BorderSize = 0;
            btnSendContent.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSendContent.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSendContent.FlatStyle = FlatStyle.Flat;
            btnSendContent.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendContent.ForeColor = Color.White;
            btnSendContent.Location = new Point(344, 574);
            btnSendContent.Name = "btnSendContent";
            btnSendContent.Size = new Size(63, 43);
            btnSendContent.TabIndex = 17;
            btnSendContent.UseVisualStyleBackColor = false;
            btnSendContent.Click += btnSendContent_Click;
            // 
            // tpFriendlist
            // 
            tpFriendlist.BackColor = Color.FromArgb(16, 48, 99);
            tpFriendlist.Controls.Add(sctFriendView);
            tpFriendlist.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpFriendlist.Location = new Point(4, 26);
            tpFriendlist.Name = "tpFriendlist";
            tpFriendlist.Size = new Size(625, 637);
            tpFriendlist.TabIndex = 2;
            tpFriendlist.Text = "Danh sách bạn bè";
            // 
            // sctFriendView
            // 
            sctFriendView.Location = new Point(3, 3);
            sctFriendView.Name = "sctFriendView";
            // 
            // sctFriendView.Panel1
            // 
            sctFriendView.Panel1.Controls.Add(flpListFriend);
            sctFriendView.Panel1.Controls.Add(label1);
            sctFriendView.Panel1.Controls.Add(pictureBox3);
            // 
            // sctFriendView.Panel2
            // 
            sctFriendView.Panel2.Controls.Add(flpUserSeachedList);
            sctFriendView.Panel2.Controls.Add(flpListUserRequest);
            sctFriendView.Panel2.Controls.Add(txtFindUser);
            sctFriendView.Panel2.Controls.Add(btnFind);
            sctFriendView.Size = new Size(619, 626);
            sctFriendView.SplitterDistance = 287;
            sctFriendView.TabIndex = 17;
            // 
            // flpListFriend
            // 
            flpListFriend.AutoScroll = true;
            flpListFriend.Controls.Add(lblNoFriend);
            flpListFriend.FlowDirection = FlowDirection.TopDown;
            flpListFriend.Location = new Point(14, 72);
            flpListFriend.Name = "flpListFriend";
            flpListFriend.Size = new Size(259, 542);
            flpListFriend.TabIndex = 19;
            flpListFriend.WrapContents = false;
            // 
            // lblNoFriend
            // 
            lblNoFriend.AutoSize = true;
            lblNoFriend.ForeColor = SystemColors.Control;
            lblNoFriend.Location = new Point(3, 0);
            lblNoFriend.Name = "lblNoFriend";
            lblNoFriend.Size = new Size(120, 18);
            lblNoFriend.TabIndex = 0;
            lblNoFriend.Text = "Chưa có bạn bè";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 16;
            label1.Text = "BẠN BÈ CỦA BẠN\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.FriendIcon;
            pictureBox3.Location = new Point(14, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // flpUserSeachedList
            // 
            flpUserSeachedList.AutoScroll = true;
            flpUserSeachedList.Controls.Add(searchedUsers1);
            flpUserSeachedList.FlowDirection = FlowDirection.TopDown;
            flpUserSeachedList.Location = new Point(15, 59);
            flpUserSeachedList.Name = "flpUserSeachedList";
            flpUserSeachedList.Size = new Size(300, 212);
            flpUserSeachedList.TabIndex = 21;
            flpUserSeachedList.WrapContents = false;
            // 
            // flpListUserRequest
            // 
            flpListUserRequest.AutoScroll = true;
            flpListUserRequest.Location = new Point(15, 277);
            flpListUserRequest.Name = "flpListUserRequest";
            flpListUserRequest.Size = new Size(300, 337);
            flpListUserRequest.TabIndex = 20;
            // 
            // txtFindUser
            // 
            txtFindUser.BorderStyle = BorderStyle.None;
            txtFindUser.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFindUser.Location = new Point(15, 12);
            txtFindUser.Multiline = true;
            txtFindUser.Name = "txtFindUser";
            txtFindUser.Size = new Size(245, 41);
            txtFindUser.TabIndex = 18;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.BackgroundImage = Properties.Resources.FindIcon;
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnFind.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(260, 12);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(55, 41);
            btnFind.TabIndex = 19;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // tpNotification
            // 
            tpNotification.BackColor = Color.FromArgb(16, 48, 99);
            tpNotification.Controls.Add(flpNotificationView);
            tpNotification.Controls.Add(btnReloadNotification);
            tpNotification.Controls.Add(label3);
            tpNotification.Controls.Add(pictureBox4);
            tpNotification.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpNotification.Location = new Point(4, 24);
            tpNotification.Name = "tpNotification";
            tpNotification.Size = new Size(625, 639);
            tpNotification.TabIndex = 3;
            tpNotification.Text = "Thông báo";
            // 
            // flpNotificationView
            // 
            flpNotificationView.AutoScroll = true;
            flpNotificationView.FlowDirection = FlowDirection.TopDown;
            flpNotificationView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpNotificationView.Location = new Point(19, 93);
            flpNotificationView.Name = "flpNotificationView";
            flpNotificationView.Size = new Size(584, 530);
            flpNotificationView.TabIndex = 19;
            flpNotificationView.WrapContents = false;
            // 
            // btnReloadNotification
            // 
            btnReloadNotification.AutoSize = true;
            btnReloadNotification.BackColor = Color.Transparent;
            btnReloadNotification.BackgroundImage = Properties.Resources.ReloadIcon;
            btnReloadNotification.BackgroundImageLayout = ImageLayout.Zoom;
            btnReloadNotification.FlatAppearance.BorderSize = 0;
            btnReloadNotification.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnReloadNotification.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnReloadNotification.FlatStyle = FlatStyle.Flat;
            btnReloadNotification.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReloadNotification.ForeColor = Color.White;
            btnReloadNotification.Location = new Point(561, 20);
            btnReloadNotification.Name = "btnReloadNotification";
            btnReloadNotification.Size = new Size(42, 30);
            btnReloadNotification.TabIndex = 16;
            btnReloadNotification.UseVisualStyleBackColor = false;
            btnReloadNotification.Click += btnReloadNotification_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 26);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 17;
            label3.Text = "THÔNG BÁO";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = Properties.Resources.NotiIcon;
            pictureBox4.Location = new Point(19, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // tpSetting
            // 
            tpSetting.BackColor = Color.FromArgb(16, 48, 99);
            tpSetting.Controls.Add(btnSendFeedback);
            tpSetting.Controls.Add(groupBox2);
            tpSetting.Controls.Add(groupBox1);
            tpSetting.Controls.Add(label4);
            tpSetting.Controls.Add(pictureBox5);
            tpSetting.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpSetting.Location = new Point(4, 24);
            tpSetting.Name = "tpSetting";
            tpSetting.Size = new Size(625, 639);
            tpSetting.TabIndex = 4;
            tpSetting.Text = "Cài đặt";
            // 
            // btnSendFeedback
            // 
            btnSendFeedback.AutoSize = true;
            btnSendFeedback.BackColor = Color.FromArgb(105, 203, 253);
            btnSendFeedback.BackgroundImageLayout = ImageLayout.Zoom;
            btnSendFeedback.FlatAppearance.BorderSize = 0;
            btnSendFeedback.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSendFeedback.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSendFeedback.FlatStyle = FlatStyle.Flat;
            btnSendFeedback.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendFeedback.ForeColor = Color.White;
            btnSendFeedback.Location = new Point(17, 603);
            btnSendFeedback.Name = "btnSendFeedback";
            btnSendFeedback.Size = new Size(114, 25);
            btnSendFeedback.TabIndex = 27;
            btnSendFeedback.Text = "Gửi phản hồi";
            btnSendFeedback.UseVisualStyleBackColor = false;
            btnSendFeedback.Click += btnSendFeedback_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChangePassword);
            groupBox2.Controls.Add(btnDeleteUser);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(17, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 124);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảo mật tài khoản";
            // 
            // btnChangePassword
            // 
            btnChangePassword.AutoSize = true;
            btnChangePassword.BackColor = Color.FromArgb(105, 203, 253);
            btnChangePassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(10, 42);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(200, 28);
            btnChangePassword.TabIndex = 27;
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.AutoSize = true;
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnDeleteUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.Black;
            btnDeleteUser.Location = new Point(10, 83);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(200, 28);
            btnDeleteUser.TabIndex = 27;
            btnDeleteUser.Text = "Xóa tài khoản";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDisplayname);
            groupBox1.Controls.Add(picAvatarSetting);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnCancelUpdateInfo);
            groupBox1.Controls.Add(btnSaveUpdateInfo);
            groupBox1.Controls.Add(btnChangeInfo);
            groupBox1.Controls.Add(btnSetavt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(17, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 259);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtDisplayname
            // 
            txtDisplayname.BorderStyle = BorderStyle.None;
            txtDisplayname.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplayname.Location = new Point(177, 78);
            txtDisplayname.Name = "txtDisplayname";
            txtDisplayname.ReadOnly = true;
            txtDisplayname.Size = new Size(385, 17);
            txtDisplayname.TabIndex = 29;
            // 
            // picAvatarSetting
            // 
            picAvatarSetting.BackColor = Color.Transparent;
            picAvatarSetting.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatarSetting.Image = Properties.Resources.AvatarIcon;
            picAvatarSetting.Location = new Point(177, 165);
            picAvatarSetting.Name = "picAvatarSetting";
            picAvatarSetting.Size = new Size(60, 60);
            picAvatarSetting.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatarSetting.TabIndex = 18;
            picAvatarSetting.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 78);
            label10.Name = "label10";
            label10.Size = new Size(104, 18);
            label10.TabIndex = 28;
            label10.Text = "Tên hiển thị";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelUpdateInfo
            // 
            btnCancelUpdateInfo.AutoSize = true;
            btnCancelUpdateInfo.BackColor = Color.White;
            btnCancelUpdateInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelUpdateInfo.FlatAppearance.BorderSize = 0;
            btnCancelUpdateInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnCancelUpdateInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnCancelUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnCancelUpdateInfo.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelUpdateInfo.ForeColor = Color.Black;
            btnCancelUpdateInfo.Location = new Point(369, 179);
            btnCancelUpdateInfo.Name = "btnCancelUpdateInfo";
            btnCancelUpdateInfo.Size = new Size(93, 25);
            btnCancelUpdateInfo.TabIndex = 27;
            btnCancelUpdateInfo.Text = "Hủy";
            btnCancelUpdateInfo.UseVisualStyleBackColor = false;
            btnCancelUpdateInfo.Click += btnCancelUpdateInfo_Click;
            // 
            // btnSaveUpdateInfo
            // 
            btnSaveUpdateInfo.AutoSize = true;
            btnSaveUpdateInfo.BackColor = Color.FromArgb(128, 255, 128);
            btnSaveUpdateInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveUpdateInfo.FlatAppearance.BorderSize = 0;
            btnSaveUpdateInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSaveUpdateInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSaveUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnSaveUpdateInfo.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveUpdateInfo.ForeColor = Color.White;
            btnSaveUpdateInfo.Location = new Point(468, 179);
            btnSaveUpdateInfo.Name = "btnSaveUpdateInfo";
            btnSaveUpdateInfo.Size = new Size(101, 25);
            btnSaveUpdateInfo.TabIndex = 27;
            btnSaveUpdateInfo.Text = "Lưu thay đổi";
            btnSaveUpdateInfo.UseVisualStyleBackColor = false;
            btnSaveUpdateInfo.Click += btnSaveUpdateInfo_Click;
            // 
            // btnChangeInfo
            // 
            btnChangeInfo.AutoSize = true;
            btnChangeInfo.BackColor = Color.FromArgb(105, 203, 253);
            btnChangeInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnChangeInfo.FlatAppearance.BorderSize = 0;
            btnChangeInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnChangeInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnChangeInfo.FlatStyle = FlatStyle.Flat;
            btnChangeInfo.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeInfo.ForeColor = Color.White;
            btnChangeInfo.Location = new Point(369, 210);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(200, 32);
            btnChangeInfo.TabIndex = 27;
            btnChangeInfo.Text = "Thay đổi thông tin";
            btnChangeInfo.UseVisualStyleBackColor = false;
            btnChangeInfo.Click += btnChangeInfo_Click;
            // 
            // btnSetavt
            // 
            btnSetavt.AutoSize = true;
            btnSetavt.BackColor = Color.FromArgb(105, 203, 253);
            btnSetavt.BackgroundImageLayout = ImageLayout.Zoom;
            btnSetavt.FlatAppearance.BorderSize = 0;
            btnSetavt.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnSetavt.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnSetavt.FlatStyle = FlatStyle.Flat;
            btnSetavt.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetavt.ForeColor = Color.White;
            btnSetavt.Location = new Point(10, 195);
            btnSetavt.Name = "btnSetavt";
            btnSetavt.Size = new Size(104, 28);
            btnSetavt.TabIndex = 17;
            btnSetavt.Text = "Tải ảnh";
            btnSetavt.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 165);
            label9.Name = "label9";
            label9.Size = new Size(104, 18);
            label9.TabIndex = 26;
            label9.Text = "Ảnh đại diện";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(177, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(385, 17);
            txtEmail.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 121);
            label7.Name = "label7";
            label7.Size = new Size(48, 18);
            label7.TabIndex = 22;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(177, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(385, 17);
            txtUsername.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 35);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 16;
            label6.Text = "Tên người dùng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 29);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 19;
            label4.Text = "CÀI ĐẶT";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = Properties.Resources.SettingIcon;
            pictureBox5.Location = new Point(17, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // rtxLog
            // 
            rtxLog.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxLog.Location = new Point(-2, 266);
            rtxLog.Name = "rtxLog";
            rtxLog.ReadOnly = true;
            rtxLog.Size = new Size(140, 319);
            rtxLog.TabIndex = 46;
            rtxLog.Text = "";
            // 
            // btnLogoutMain
            // 
            btnLogoutMain.AutoSize = true;
            btnLogoutMain.BackColor = Color.Transparent;
            btnLogoutMain.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogoutMain.FlatAppearance.BorderSize = 0;
            btnLogoutMain.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnLogoutMain.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnLogoutMain.FlatStyle = FlatStyle.Flat;
            btnLogoutMain.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLogoutMain.ForeColor = Color.White;
            btnLogoutMain.Location = new Point(-2, 580);
            btnLogoutMain.Name = "btnLogoutMain";
            btnLogoutMain.Size = new Size(151, 39);
            btnLogoutMain.TabIndex = 13;
            btnLogoutMain.Text = "Đăng xuất";
            btnLogoutMain.UseVisualStyleBackColor = false;
            btnLogoutMain.Click += btnLogoutMain_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.AvatarIcon;
            pictureBox2.Location = new Point(12, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(-2, 613);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 39);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(3, 2);
            lblUsername.MaximumSize = new Size(120, 0);
            lblUsername.MinimumSize = new Size(120, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 20);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Display Name";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(lblUsername);
            panel2.Location = new Point(12, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 22);
            panel2.TabIndex = 19;
            // 
            // searchedUsers1
            // 
            searchedUsers1.Location = new Point(3, 3);
            searchedUsers1.Name = "searchedUsers1";
            searchedUsers1.Size = new Size(280, 46);
            searchedUsers1.TabIndex = 0;
            // 
            // MainHomeUI
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 29, 60);
            ClientSize = new Size(783, 664);
            Controls.Add(rtxLog);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnLogoutMain);
            Controls.Add(tabMenu);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainHomeUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEnU";
            Load += MainHomeUI_Load;
            Shown += MainHomeUI_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMenu.ResumeLayout(false);
            tpHome.ResumeLayout(false);
            tpHome.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            panel1.ResumeLayout(false);
            tpChat.ResumeLayout(false);
            sctChatView.Panel1.ResumeLayout(false);
            sctChatView.Panel1.PerformLayout();
            sctChatView.Panel2.ResumeLayout(false);
            sctChatView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sctChatView).EndInit();
            sctChatView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flpListFriendChat.ResumeLayout(false);
            flpListFriendChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarTitleChat).EndInit();
            tpFriendlist.ResumeLayout(false);
            sctFriendView.Panel1.ResumeLayout(false);
            sctFriendView.Panel1.PerformLayout();
            sctFriendView.Panel2.ResumeLayout(false);
            sctFriendView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sctFriendView).EndInit();
            sctFriendView.ResumeLayout(false);
            flpListFriend.ResumeLayout(false);
            flpListFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flpUserSeachedList.ResumeLayout(false);
            tpNotification.ResumeLayout(false);
            tpNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tpSetting.ResumeLayout(false);
            tpSetting.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarSetting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private TabControl tabMenu;
        private TabPage tpChat;
        private TabPage tpFriendlist;
        private TabPage tpNotification;
        private TabPage tpSetting;
        private Button btnLogoutMain;
        private TextBox txtContent;
        private Button btnSendContent;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Button btnReloadNotification;
        private Label label4;
        private PictureBox pictureBox5;
        private SplitContainer sctChatView;
        private Label label5;
        private PictureBox pictureBox6;
        private SplitContainer sctFriendView;
        private FlowLayoutPanel flpListFriend;
        private TextBox txtFindUser;
        private Button btnFind;
        private FlowLayoutPanel flpListUserRequest;
        private FlowLayoutPanel flpNotificationView;
        private TabPage tpHome;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtUsername;
        private Button btnSetavt;
        private Button btnChangeInfo;
        private PictureBox pictureBox2;
        private TextBox txtDisplayname;
        private Label label10;
        private Button btnDeleteUser;
        private Button btnExit;
        private FlowLayoutPanel flpUserSeachedList;
        private Label lblNoFriend;
        private FlowLayoutPanel flpListFriendChat;
        private LinkLabel llbStartChat;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox picAvatarTitleChat;
        private Label lblDisplayNameTitleChat;
        private PictureBox picImage;
        private Button btnDown;
        private Button btnLoadimage;
        private TextBox txtReactChat;
        private Button btnSendReactChat;
        private PictureBox picAvatarPost;
        private Panel panel1;
        private Button btnReactSad;
        private Button btnReactHaha;
        private Button btnReactHeart;
        private Button btnReactHug;
        private Label lblTimePost;
        private Label lblDisplayNamePost;
        private LinkLabel llbViewReactions;
        private Button btnUp;
        private Button btnDeletePost;
        private Button btnDownloadPost;
        private TextBox txtShowCaption;
        private Label lblNoPhotoYet;
        private RichTextBox rtxLog;
        private Label lblUsername;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnRefreshHome;
        private GroupBox groupBox2;
        private PictureBox picAvatarSetting;
        private Button btnCancelUpdateInfo;
        private Button btnSaveUpdateInfo;
        private Button btnSendFeedback;
        private Button btnChangePassword;
        private UserControl.SearchedUsers searchedUsers1;
    }
}