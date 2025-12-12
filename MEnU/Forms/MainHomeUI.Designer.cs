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
            pnlPostView = new Panel();
            txtReactChat = new TextBox();
            txtUsernamePostImage = new TextBox();
            panel1 = new Panel();
            btnSendReactChat = new Button();
            btnReactSad = new Button();
            btnReactHaha = new Button();
            btnReactHeart = new Button();
            btnReactHug = new Button();
            txtShowCaption = new TextBox();
            picImage = new PictureBox();
            btnPostimage = new Button();
            btnLoadimage = new Button();
            txtInputCaption = new TextBox();
            btnDown = new Button();
            btnUp = new Button();
            tpChat = new TabPage();
            sctChatView = new SplitContainer();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            flpListFriendChat = new FlowLayoutPanel();
            pnlTemplateChatView = new Panel();
            btnOpenChat = new Button();
            lblFriendNameChat = new Label();
            flpChatHistory = new FlowLayoutPanel();
            panel2 = new Panel();
            lblContentChat = new Label();
            txtContent = new TextBox();
            btnSendContent = new Button();
            tpFriendlist = new TabPage();
            sctFriendView = new SplitContainer();
            flpListFriend = new FlowLayoutPanel();
            pnlTemplateFriendView = new Panel();
            lblFriendNameList = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            flpListUserRequest = new FlowLayoutPanel();
            pnlTemplateUserRequest = new Panel();
            btnRefuseUser = new Button();
            btnAcceptUser = new Button();
            lblUsernameRequest = new Label();
            pnlTemplateAddFriend = new Panel();
            btnAddUser = new Button();
            lblUsernameFind = new Label();
            txtFindUser = new TextBox();
            btnFind = new Button();
            tpNotification = new TabPage();
            flpNotificationView = new FlowLayoutPanel();
            pnlTemplateNotification = new Panel();
            lblNotificationname = new Label();
            btnReloadNotification = new Button();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            tpSetting = new TabPage();
            groupBox1 = new GroupBox();
            txtDisplayname = new TextBox();
            label10 = new Label();
            btnChangeInfo = new Button();
            btnSetavt = new Button();
            label9 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            btnLogoutMain = new Button();
            lblUsername = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMenu.SuspendLayout();
            tpHome.SuspendLayout();
            pnlPostView.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            tpChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sctChatView).BeginInit();
            sctChatView.Panel1.SuspendLayout();
            sctChatView.Panel2.SuspendLayout();
            sctChatView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flpListFriendChat.SuspendLayout();
            pnlTemplateChatView.SuspendLayout();
            flpChatHistory.SuspendLayout();
            panel2.SuspendLayout();
            tpFriendlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sctFriendView).BeginInit();
            sctFriendView.Panel1.SuspendLayout();
            sctFriendView.Panel2.SuspendLayout();
            sctFriendView.SuspendLayout();
            flpListFriend.SuspendLayout();
            pnlTemplateFriendView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flpListUserRequest.SuspendLayout();
            pnlTemplateUserRequest.SuspendLayout();
            pnlTemplateAddFriend.SuspendLayout();
            tpNotification.SuspendLayout();
            flpNotificationView.SuspendLayout();
            pnlTemplateNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tpSetting.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(49, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 6;
            label2.Text = "MEnU";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.MenuLogo;
            pictureBox1.Location = new Point(36, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            // 
            // tpHome
            // 
            tpHome.BackColor = Color.FromArgb(16, 48, 99);
            tpHome.Controls.Add(pnlPostView);
            tpHome.Controls.Add(btnDown);
            tpHome.Controls.Add(btnUp);
            tpHome.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpHome.ForeColor = SystemColors.ControlText;
            tpHome.Location = new Point(4, 31);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(625, 632);
            tpHome.TabIndex = 0;
            tpHome.Text = "Home";
            // 
            // pnlPostView
            // 
            pnlPostView.Controls.Add(txtReactChat);
            pnlPostView.Controls.Add(txtUsernamePostImage);
            pnlPostView.Controls.Add(panel1);
            pnlPostView.Controls.Add(txtShowCaption);
            pnlPostView.Controls.Add(picImage);
            pnlPostView.Controls.Add(btnPostimage);
            pnlPostView.Controls.Add(btnLoadimage);
            pnlPostView.Controls.Add(txtInputCaption);
            pnlPostView.Location = new Point(61, 57);
            pnlPostView.Name = "pnlPostView";
            pnlPostView.Size = new Size(485, 527);
            pnlPostView.TabIndex = 16;
            // 
            // txtReactChat
            // 
            txtReactChat.BorderStyle = BorderStyle.None;
            txtReactChat.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReactChat.ForeColor = Color.FromArgb(10, 29, 60);
            txtReactChat.Location = new Point(4, 450);
            txtReactChat.Multiline = true;
            txtReactChat.Name = "txtReactChat";
            txtReactChat.Size = new Size(295, 41);
            txtReactChat.TabIndex = 18;
            // 
            // txtUsernamePostImage
            // 
            txtUsernamePostImage.BackColor = SystemColors.GradientInactiveCaption;
            txtUsernamePostImage.BorderStyle = BorderStyle.None;
            txtUsernamePostImage.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsernamePostImage.ForeColor = Color.FromArgb(10, 29, 60);
            txtUsernamePostImage.Location = new Point(141, 6);
            txtUsernamePostImage.Multiline = true;
            txtUsernamePostImage.Name = "txtUsernamePostImage";
            txtUsernamePostImage.ReadOnly = true;
            txtUsernamePostImage.Size = new Size(176, 36);
            txtUsernamePostImage.TabIndex = 25;
            txtUsernamePostImage.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSendReactChat);
            panel1.Controls.Add(btnReactSad);
            panel1.Controls.Add(btnReactHaha);
            panel1.Controls.Add(btnReactHeart);
            panel1.Controls.Add(btnReactHug);
            panel1.Location = new Point(291, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 41);
            panel1.TabIndex = 23;
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
            // txtShowCaption
            // 
            txtShowCaption.BackColor = SystemColors.GradientInactiveCaption;
            txtShowCaption.BorderStyle = BorderStyle.None;
            txtShowCaption.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShowCaption.ForeColor = Color.FromArgb(10, 29, 60);
            txtShowCaption.Location = new Point(6, 384);
            txtShowCaption.Multiline = true;
            txtShowCaption.Name = "txtShowCaption";
            txtShowCaption.ReadOnly = true;
            txtShowCaption.Size = new Size(448, 36);
            txtShowCaption.TabIndex = 24;
            txtShowCaption.TextAlign = HorizontalAlignment.Center;
            // 
            // picImage
            // 
            picImage.BackColor = SystemColors.GradientActiveCaption;
            picImage.Location = new Point(3, 5);
            picImage.Name = "picImage";
            picImage.Size = new Size(453, 416);
            picImage.TabIndex = 0;
            picImage.TabStop = false;
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
            btnPostimage.Location = new Point(378, 442);
            btnPostimage.Name = "btnPostimage";
            btnPostimage.Size = new Size(78, 57);
            btnPostimage.TabIndex = 12;
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
            btnLoadimage.Location = new Point(4, 442);
            btnLoadimage.Name = "btnLoadimage";
            btnLoadimage.Size = new Size(92, 57);
            btnLoadimage.TabIndex = 11;
            btnLoadimage.UseVisualStyleBackColor = false;
            // 
            // txtInputCaption
            // 
            txtInputCaption.BorderStyle = BorderStyle.None;
            txtInputCaption.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputCaption.Location = new Point(102, 450);
            txtInputCaption.Multiline = true;
            txtInputCaption.Name = "txtInputCaption";
            txtInputCaption.Size = new Size(270, 41);
            txtInputCaption.TabIndex = 24;
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
            btnDown.Location = new Point(536, 288);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(71, 44);
            btnDown.TabIndex = 14;
            btnDown.UseVisualStyleBackColor = false;
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
            btnUp.Location = new Point(536, 226);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(71, 45);
            btnUp.TabIndex = 13;
            btnUp.UseVisualStyleBackColor = false;
            // 
            // tpChat
            // 
            tpChat.BackColor = Color.FromArgb(16, 48, 99);
            tpChat.Controls.Add(sctChatView);
            tpChat.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpChat.Location = new Point(4, 31);
            tpChat.Name = "tpChat";
            tpChat.Padding = new Padding(3);
            tpChat.Size = new Size(625, 632);
            tpChat.TabIndex = 1;
            tpChat.Text = "Chat";
            // 
            // sctChatView
            // 
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
            sctChatView.Panel2.Controls.Add(flpChatHistory);
            sctChatView.Panel2.Controls.Add(txtContent);
            sctChatView.Panel2.Controls.Add(btnSendContent);
            sctChatView.Size = new Size(624, 632);
            sctChatView.SplitterDistance = 208;
            sctChatView.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 23);
            label5.Name = "label5";
            label5.Size = new Size(116, 27);
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
            flpListFriendChat.Controls.Add(pnlTemplateChatView);
            flpListFriendChat.Location = new Point(5, 75);
            flpListFriendChat.Name = "flpListFriendChat";
            flpListFriendChat.Size = new Size(200, 542);
            flpListFriendChat.TabIndex = 18;
            // 
            // pnlTemplateChatView
            // 
            pnlTemplateChatView.Controls.Add(btnOpenChat);
            pnlTemplateChatView.Controls.Add(lblFriendNameChat);
            pnlTemplateChatView.Location = new Point(3, 3);
            pnlTemplateChatView.Name = "pnlTemplateChatView";
            pnlTemplateChatView.Size = new Size(197, 45);
            pnlTemplateChatView.TabIndex = 0;
            // 
            // btnOpenChat
            // 
            btnOpenChat.AutoSize = true;
            btnOpenChat.BackColor = Color.FromArgb(105, 203, 253);
            btnOpenChat.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenChat.FlatAppearance.BorderSize = 0;
            btnOpenChat.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnOpenChat.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnOpenChat.FlatStyle = FlatStyle.Flat;
            btnOpenChat.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenChat.ForeColor = Color.White;
            btnOpenChat.Location = new Point(131, 7);
            btnOpenChat.Name = "btnOpenChat";
            btnOpenChat.Size = new Size(61, 32);
            btnOpenChat.TabIndex = 16;
            btnOpenChat.Text = "Chat";
            btnOpenChat.UseVisualStyleBackColor = false;
            // 
            // lblFriendNameChat
            // 
            lblFriendNameChat.AutoSize = true;
            lblFriendNameChat.BackColor = Color.Transparent;
            lblFriendNameChat.ForeColor = Color.White;
            lblFriendNameChat.Location = new Point(10, 12);
            lblFriendNameChat.Name = "lblFriendNameChat";
            lblFriendNameChat.Size = new Size(50, 22);
            lblFriendNameChat.TabIndex = 0;
            lblFriendNameChat.Text = "Name";
            // 
            // flpChatHistory
            // 
            flpChatHistory.AutoScroll = true;
            flpChatHistory.Controls.Add(panel2);
            flpChatHistory.FlowDirection = FlowDirection.TopDown;
            flpChatHistory.Location = new Point(15, 12);
            flpChatHistory.Name = "flpChatHistory";
            flpChatHistory.Size = new Size(383, 545);
            flpChatHistory.TabIndex = 18;
            flpChatHistory.WrapContents = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(lblContentChat);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 30);
            panel2.TabIndex = 0;
            // 
            // lblContentChat
            // 
            lblContentChat.AutoSize = true;
            lblContentChat.BackColor = Color.Transparent;
            lblContentChat.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContentChat.ForeColor = Color.White;
            lblContentChat.Location = new Point(14, 8);
            lblContentChat.MaximumSize = new Size(255, 0);
            lblContentChat.Name = "lblContentChat";
            lblContentChat.Size = new Size(50, 22);
            lblContentChat.TabIndex = 17;
            lblContentChat.Text = "Name";
            lblContentChat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(15, 576);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(322, 41);
            txtContent.TabIndex = 16;
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
            btnSendContent.Location = new Point(335, 576);
            btnSendContent.Name = "btnSendContent";
            btnSendContent.Size = new Size(63, 41);
            btnSendContent.TabIndex = 17;
            btnSendContent.UseVisualStyleBackColor = false;
            // 
            // tpFriendlist
            // 
            tpFriendlist.BackColor = Color.FromArgb(16, 48, 99);
            tpFriendlist.Controls.Add(sctFriendView);
            tpFriendlist.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpFriendlist.Location = new Point(4, 31);
            tpFriendlist.Name = "tpFriendlist";
            tpFriendlist.Size = new Size(625, 632);
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
            sctFriendView.Panel2.Controls.Add(flpListUserRequest);
            sctFriendView.Panel2.Controls.Add(pnlTemplateAddFriend);
            sctFriendView.Panel2.Controls.Add(txtFindUser);
            sctFriendView.Panel2.Controls.Add(btnFind);
            sctFriendView.Size = new Size(619, 626);
            sctFriendView.SplitterDistance = 287;
            sctFriendView.TabIndex = 17;
            // 
            // flpListFriend
            // 
            flpListFriend.AutoScroll = true;
            flpListFriend.Controls.Add(pnlTemplateFriendView);
            flpListFriend.Location = new Point(14, 72);
            flpListFriend.Name = "flpListFriend";
            flpListFriend.Size = new Size(259, 542);
            flpListFriend.TabIndex = 19;
            // 
            // pnlTemplateFriendView
            // 
            pnlTemplateFriendView.Controls.Add(lblFriendNameList);
            pnlTemplateFriendView.Location = new Point(3, 3);
            pnlTemplateFriendView.Name = "pnlTemplateFriendView";
            pnlTemplateFriendView.Size = new Size(256, 45);
            pnlTemplateFriendView.TabIndex = 0;
            // 
            // lblFriendNameList
            // 
            lblFriendNameList.AutoSize = true;
            lblFriendNameList.BackColor = Color.Transparent;
            lblFriendNameList.ForeColor = Color.White;
            lblFriendNameList.Location = new Point(10, 12);
            lblFriendNameList.Name = "lblFriendNameList";
            lblFriendNameList.Size = new Size(50, 22);
            lblFriendNameList.TabIndex = 0;
            lblFriendNameList.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
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
            // flpListUserRequest
            // 
            flpListUserRequest.AutoScroll = true;
            flpListUserRequest.Controls.Add(pnlTemplateUserRequest);
            flpListUserRequest.Location = new Point(15, 277);
            flpListUserRequest.Name = "flpListUserRequest";
            flpListUserRequest.Size = new Size(300, 337);
            flpListUserRequest.TabIndex = 20;
            // 
            // pnlTemplateUserRequest
            // 
            pnlTemplateUserRequest.Controls.Add(btnRefuseUser);
            pnlTemplateUserRequest.Controls.Add(btnAcceptUser);
            pnlTemplateUserRequest.Controls.Add(lblUsernameRequest);
            pnlTemplateUserRequest.Location = new Point(3, 3);
            pnlTemplateUserRequest.Name = "pnlTemplateUserRequest";
            pnlTemplateUserRequest.Size = new Size(297, 45);
            pnlTemplateUserRequest.TabIndex = 0;
            // 
            // btnRefuseUser
            // 
            btnRefuseUser.AutoSize = true;
            btnRefuseUser.BackColor = Color.Transparent;
            btnRefuseUser.BackgroundImage = Properties.Resources.RefuseIcon;
            btnRefuseUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefuseUser.FlatAppearance.BorderSize = 0;
            btnRefuseUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnRefuseUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnRefuseUser.FlatStyle = FlatStyle.Flat;
            btnRefuseUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefuseUser.ForeColor = Color.White;
            btnRefuseUser.Location = new Point(242, 7);
            btnRefuseUser.Name = "btnRefuseUser";
            btnRefuseUser.Size = new Size(46, 32);
            btnRefuseUser.TabIndex = 19;
            btnRefuseUser.UseVisualStyleBackColor = false;
            // 
            // btnAcceptUser
            // 
            btnAcceptUser.AutoSize = true;
            btnAcceptUser.BackColor = Color.Transparent;
            btnAcceptUser.BackgroundImage = Properties.Resources.AcceptIcon;
            btnAcceptUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAcceptUser.FlatAppearance.BorderSize = 0;
            btnAcceptUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnAcceptUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnAcceptUser.FlatStyle = FlatStyle.Flat;
            btnAcceptUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceptUser.ForeColor = Color.White;
            btnAcceptUser.Location = new Point(186, 7);
            btnAcceptUser.Name = "btnAcceptUser";
            btnAcceptUser.Size = new Size(49, 32);
            btnAcceptUser.TabIndex = 18;
            btnAcceptUser.UseVisualStyleBackColor = false;
            // 
            // lblUsernameRequest
            // 
            lblUsernameRequest.AutoSize = true;
            lblUsernameRequest.BackColor = Color.Transparent;
            lblUsernameRequest.ForeColor = Color.White;
            lblUsernameRequest.Location = new Point(10, 12);
            lblUsernameRequest.Name = "lblUsernameRequest";
            lblUsernameRequest.Size = new Size(50, 22);
            lblUsernameRequest.TabIndex = 0;
            lblUsernameRequest.Text = "Name";
            // 
            // pnlTemplateAddFriend
            // 
            pnlTemplateAddFriend.Controls.Add(btnAddUser);
            pnlTemplateAddFriend.Controls.Add(lblUsernameFind);
            pnlTemplateAddFriend.Location = new Point(15, 75);
            pnlTemplateAddFriend.Name = "pnlTemplateAddFriend";
            pnlTemplateAddFriend.Size = new Size(300, 45);
            pnlTemplateAddFriend.TabIndex = 16;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSize = true;
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BackgroundImage = Properties.Resources.AddIcon;
            btnAddUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 94, 128);
            btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 140, 178);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(245, 7);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(45, 32);
            btnAddUser.TabIndex = 17;
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // lblUsernameFind
            // 
            lblUsernameFind.AutoSize = true;
            lblUsernameFind.BackColor = Color.Transparent;
            lblUsernameFind.ForeColor = Color.White;
            lblUsernameFind.Location = new Point(10, 12);
            lblUsernameFind.Name = "lblUsernameFind";
            lblUsernameFind.Size = new Size(50, 22);
            lblUsernameFind.TabIndex = 0;
            lblUsernameFind.Text = "Name";
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
            // 
            // tpNotification
            // 
            tpNotification.BackColor = Color.FromArgb(16, 48, 99);
            tpNotification.Controls.Add(flpNotificationView);
            tpNotification.Controls.Add(btnReloadNotification);
            tpNotification.Controls.Add(label3);
            tpNotification.Controls.Add(pictureBox4);
            tpNotification.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpNotification.Location = new Point(4, 31);
            tpNotification.Name = "tpNotification";
            tpNotification.Size = new Size(625, 632);
            tpNotification.TabIndex = 3;
            tpNotification.Text = "Thông báo";
            // 
            // flpNotificationView
            // 
            flpNotificationView.AutoScroll = true;
            flpNotificationView.Controls.Add(pnlTemplateNotification);
            flpNotificationView.Location = new Point(19, 93);
            flpNotificationView.Name = "flpNotificationView";
            flpNotificationView.Size = new Size(584, 530);
            flpNotificationView.TabIndex = 19;
            // 
            // pnlTemplateNotification
            // 
            pnlTemplateNotification.Controls.Add(lblNotificationname);
            pnlTemplateNotification.Location = new Point(3, 3);
            pnlTemplateNotification.Name = "pnlTemplateNotification";
            pnlTemplateNotification.Size = new Size(581, 45);
            pnlTemplateNotification.TabIndex = 0;
            // 
            // lblNotificationname
            // 
            lblNotificationname.AutoSize = true;
            lblNotificationname.BackColor = Color.Transparent;
            lblNotificationname.ForeColor = Color.White;
            lblNotificationname.Location = new Point(10, 12);
            lblNotificationname.Name = "lblNotificationname";
            lblNotificationname.Size = new Size(50, 22);
            lblNotificationname.TabIndex = 0;
            lblNotificationname.Text = "Name";
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 26);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
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
            tpSetting.Controls.Add(groupBox1);
            tpSetting.Controls.Add(label4);
            tpSetting.Controls.Add(pictureBox5);
            tpSetting.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpSetting.Location = new Point(4, 31);
            tpSetting.Name = "tpSetting";
            tpSetting.Size = new Size(625, 632);
            tpSetting.TabIndex = 4;
            tpSetting.Text = "Cài đặt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDisplayname);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnChangeInfo);
            groupBox1.Controls.Add(btnSetavt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(17, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 303);
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
            txtDisplayname.Size = new Size(385, 22);
            txtDisplayname.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 78);
            label10.Name = "label10";
            label10.Size = new Size(130, 22);
            label10.TabIndex = 28;
            label10.Text = "Tên hiển thị";
            label10.TextAlign = ContentAlignment.MiddleCenter;
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
            btnChangeInfo.Location = new Point(362, 256);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(200, 32);
            btnChangeInfo.TabIndex = 27;
            btnChangeInfo.Text = "Thay đổi thông tin";
            btnChangeInfo.UseVisualStyleBackColor = false;
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
            btnSetavt.Location = new Point(177, 202);
            btnSetavt.Name = "btnSetavt";
            btnSetavt.Size = new Size(131, 32);
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
            label9.Location = new Point(10, 207);
            label9.Name = "label9";
            label9.Size = new Size(130, 22);
            label9.TabIndex = 26;
            label9.Text = "Ảnh đại diện";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(177, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(385, 22);
            txtPassword.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 164);
            label8.Name = "label8";
            label8.Size = new Size(90, 22);
            label8.TabIndex = 24;
            label8.Text = "Mật khẩu";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(177, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(385, 22);
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
            label7.Size = new Size(60, 22);
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
            txtUsername.Size = new Size(385, 22);
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
            label6.Size = new Size(150, 22);
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
            label4.Size = new Size(103, 27);
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
            btnLogoutMain.Location = new Point(-2, 626);
            btnLogoutMain.Name = "btnLogoutMain";
            btnLogoutMain.Size = new Size(151, 39);
            btnLogoutMain.TabIndex = 13;
            btnLogoutMain.Text = "Đăng xuất";
            btnLogoutMain.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(27, 239);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 23);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "USERNAME";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.AvatarIcon;
            pictureBox2.Location = new Point(12, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // MainHomeUI
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 29, 60);
            ClientSize = new Size(783, 664);
            Controls.Add(pictureBox2);
            Controls.Add(lblUsername);
            Controls.Add(btnLogoutMain);
            Controls.Add(tabMenu);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainHomeUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMenu.ResumeLayout(false);
            tpHome.ResumeLayout(false);
            tpHome.PerformLayout();
            pnlPostView.ResumeLayout(false);
            pnlPostView.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            tpChat.ResumeLayout(false);
            sctChatView.Panel1.ResumeLayout(false);
            sctChatView.Panel1.PerformLayout();
            sctChatView.Panel2.ResumeLayout(false);
            sctChatView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sctChatView).EndInit();
            sctChatView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flpListFriendChat.ResumeLayout(false);
            pnlTemplateChatView.ResumeLayout(false);
            pnlTemplateChatView.PerformLayout();
            flpChatHistory.ResumeLayout(false);
            flpChatHistory.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tpFriendlist.ResumeLayout(false);
            sctFriendView.Panel1.ResumeLayout(false);
            sctFriendView.Panel1.PerformLayout();
            sctFriendView.Panel2.ResumeLayout(false);
            sctFriendView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sctFriendView).EndInit();
            sctFriendView.ResumeLayout(false);
            flpListFriend.ResumeLayout(false);
            pnlTemplateFriendView.ResumeLayout(false);
            pnlTemplateFriendView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flpListUserRequest.ResumeLayout(false);
            pnlTemplateUserRequest.ResumeLayout(false);
            pnlTemplateUserRequest.PerformLayout();
            pnlTemplateAddFriend.ResumeLayout(false);
            pnlTemplateAddFriend.PerformLayout();
            tpNotification.ResumeLayout(false);
            tpNotification.PerformLayout();
            flpNotificationView.ResumeLayout(false);
            pnlTemplateNotification.ResumeLayout(false);
            pnlTemplateNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tpSetting.ResumeLayout(false);
            tpSetting.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lblUsername;
        private Button btnOpenChat;
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
        private FlowLayoutPanel flpListFriendChat;
        private Panel pnlTemplateChatView;
        private Label lblFriendNameChat;
        private FlowLayoutPanel flpChatHistory;
        private Panel panel2;
        private Label lblContentChat;
        private SplitContainer sctFriendView;
        private FlowLayoutPanel flpListFriend;
        private Panel pnlTemplateFriendView;
        private Label lblFriendNameList;
        private TextBox txtFindUser;
        private Button btnFind;
        private FlowLayoutPanel flpListUserRequest;
        private Panel pnlTemplateUserRequest;
        private Button btnRefuseUser;
        private Button btnAcceptUser;
        private Label lblUsernameRequest;
        private Panel pnlTemplateAddFriend;
        private Button btnAddUser;
        private Label lblUsernameFind;
        private FlowLayoutPanel flpNotificationView;
        private Panel pnlTemplateNotification;
        private Label lblNotificationname;
        private TabPage tpHome;
        private Panel pnlPostView;
        private TextBox txtReactChat;
        private TextBox txtUsernamePostImage;
        private Panel panel1;
        private Button btnSendReactChat;
        private Button btnReactSad;
        private Button btnReactHaha;
        private Button btnReactHeart;
        private Button btnReactHug;
        private TextBox txtShowCaption;
        private PictureBox picImage;
        private Button btnPostimage;
        private Button btnLoadimage;
        private TextBox txtInputCaption;
        private Button btnDown;
        private Button btnUp;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtUsername;
        private Button btnSetavt;
        private Button btnChangeInfo;
        private PictureBox pictureBox2;
        private TextBox txtDisplayname;
        private Label label10;
    }
}