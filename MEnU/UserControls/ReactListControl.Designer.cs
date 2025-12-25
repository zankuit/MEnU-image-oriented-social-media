namespace MEnU.UserControls
{
    partial class ReactListControl
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
            picAvtarReact = new PictureBox();
            lblNameReact = new Label();
            flpReactions = new FlowLayoutPanel();
            picSad = new PictureBox();
            picHug = new PictureBox();
            picHaha = new PictureBox();
            picHeart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAvtarReact).BeginInit();
            flpReactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHug).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHaha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHeart).BeginInit();
            SuspendLayout();
            // 
            // picAvtarReact
            // 
            picAvtarReact.BackColor = Color.Transparent;
            picAvtarReact.BackgroundImageLayout = ImageLayout.Zoom;
            picAvtarReact.Image = Properties.Resources.AvatarIcon;
            picAvtarReact.Location = new Point(0, 0);
            picAvtarReact.Name = "picAvtarReact";
            picAvtarReact.Size = new Size(30, 30);
            picAvtarReact.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvtarReact.TabIndex = 20;
            picAvtarReact.TabStop = false;
            // 
            // lblNameReact
            // 
            lblNameReact.AutoSize = true;
            lblNameReact.ForeColor = SystemColors.HighlightText;
            lblNameReact.Location = new Point(33, 9);
            lblNameReact.Name = "lblNameReact";
            lblNameReact.Size = new Size(135, 15);
            lblNameReact.TabIndex = 21;
            lblNameReact.Text = "Nameeeeeeeeeeeeeeeee";
            // 
            // flpReactions
            // 
            flpReactions.Controls.Add(picSad);
            flpReactions.Controls.Add(picHug);
            flpReactions.Controls.Add(picHaha);
            flpReactions.Controls.Add(picHeart);
            flpReactions.FlowDirection = FlowDirection.RightToLeft;
            flpReactions.Location = new Point(183, 0);
            flpReactions.Name = "flpReactions";
            flpReactions.Size = new Size(124, 30);
            flpReactions.TabIndex = 22;
            flpReactions.WrapContents = false;
            // 
            // picSad
            // 
            picSad.Image = Properties.Resources.SadIcon;
            picSad.Location = new Point(96, 3);
            picSad.Name = "picSad";
            picSad.Size = new Size(25, 25);
            picSad.SizeMode = PictureBoxSizeMode.StretchImage;
            picSad.TabIndex = 24;
            picSad.TabStop = false;
            // 
            // picHug
            // 
            picHug.Image = Properties.Resources.HugIcon;
            picHug.Location = new Point(65, 3);
            picHug.Name = "picHug";
            picHug.Size = new Size(25, 25);
            picHug.SizeMode = PictureBoxSizeMode.StretchImage;
            picHug.TabIndex = 24;
            picHug.TabStop = false;
            // 
            // picHaha
            // 
            picHaha.Image = Properties.Resources.HahaIcon;
            picHaha.Location = new Point(34, 3);
            picHaha.Name = "picHaha";
            picHaha.Size = new Size(25, 25);
            picHaha.SizeMode = PictureBoxSizeMode.StretchImage;
            picHaha.TabIndex = 24;
            picHaha.TabStop = false;
            // 
            // picHeart
            // 
            picHeart.Image = Properties.Resources.HeartIcon;
            picHeart.Location = new Point(3, 3);
            picHeart.Name = "picHeart";
            picHeart.Size = new Size(25, 25);
            picHeart.SizeMode = PictureBoxSizeMode.StretchImage;
            picHeart.TabIndex = 23;
            picHeart.TabStop = false;
            // 
            // ReactListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            Controls.Add(flpReactions);
            Controls.Add(lblNameReact);
            Controls.Add(picAvtarReact);
            Name = "ReactListControl";
            Size = new Size(310, 30);
            ((System.ComponentModel.ISupportInitialize)picAvtarReact).EndInit();
            flpReactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHug).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHaha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHeart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvtarReact;
        private Label lblNameReact;
        private FlowLayoutPanel flpReactions;
        private PictureBox picHeart;
        private PictureBox picHaha;
        private PictureBox picSad;
        private PictureBox picHug;
    }
}
