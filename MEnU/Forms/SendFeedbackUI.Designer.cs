namespace MEnU.Forms
{
    partial class SendFeedbackUI
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
            rtxContentFeedback = new RichTextBox();
            btnSendFeedback = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 203, 253);
            label2.Location = new Point(79, 25);
            label2.Name = "label2";
            label2.Size = new Size(431, 36);
            label2.TabIndex = 6;
            label2.Text = "Gửi phản hồi cho chúng tôi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtxContentFeedback
            // 
            rtxContentFeedback.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxContentFeedback.Location = new Point(12, 85);
            rtxContentFeedback.Name = "rtxContentFeedback";
            rtxContentFeedback.Size = new Size(564, 259);
            rtxContentFeedback.TabIndex = 7;
            rtxContentFeedback.Text = "";
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
            btnSendFeedback.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendFeedback.ForeColor = Color.White;
            btnSendFeedback.Location = new Point(186, 349);
            btnSendFeedback.Margin = new Padding(3, 2, 3, 2);
            btnSendFeedback.Name = "btnSendFeedback";
            btnSendFeedback.Size = new Size(217, 29);
            btnSendFeedback.TabIndex = 19;
            btnSendFeedback.Text = "Gửi phản hồi";
            btnSendFeedback.UseVisualStyleBackColor = false;
            btnSendFeedback.Click += btnSendFeedback_Click;
            // 
            // SendFeedbackUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 48, 99);
            ClientSize = new Size(588, 403);
            Controls.Add(btnSendFeedback);
            Controls.Add(rtxContentFeedback);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SendFeedbackUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SendFeedbackUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RichTextBox rtxContentFeedback;
        private Button btnSendFeedback;
    }
}