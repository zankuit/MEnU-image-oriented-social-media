namespace MEnU.Forms
{
    partial class ReactionListViewUI
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
            flpReactionList = new FlowLayoutPanel();
            lblNoReactionYet = new Label();
            flpReactionList.SuspendLayout();
            SuspendLayout();
            // 
            // flpReactionList
            // 
            flpReactionList.Controls.Add(lblNoReactionYet);
            flpReactionList.FlowDirection = FlowDirection.TopDown;
            flpReactionList.Location = new Point(10, 12);
            flpReactionList.Name = "flpReactionList";
            flpReactionList.Size = new Size(320, 300);
            flpReactionList.TabIndex = 0;
            flpReactionList.WrapContents = false;
            // 
            // lblNoReactionYet
            // 
            lblNoReactionYet.AutoSize = true;
            lblNoReactionYet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoReactionYet.ForeColor = SystemColors.Control;
            lblNoReactionYet.Location = new Point(3, 0);
            lblNoReactionYet.Name = "lblNoReactionYet";
            lblNoReactionYet.Size = new Size(156, 21);
            lblNoReactionYet.TabIndex = 0;
            lblNoReactionYet.Text = "Chưa có reaction nào";
            // 
            // ReactionListViewUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(342, 320);
            Controls.Add(flpReactionList);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReactionListViewUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reactions";
            Load += ReactionListViewUI_Load;
            flpReactionList.ResumeLayout(false);
            flpReactionList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpReactionList;
        private Label lblNoReactionYet;
    }
}