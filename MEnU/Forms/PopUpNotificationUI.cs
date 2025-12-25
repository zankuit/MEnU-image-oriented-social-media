using MEnU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU.Forms
{
    public partial class PopUpNotificationUI : Form
    {
        private System.Windows.Forms.Timer closeTimer;
        int durationMs = 5000;

        public PopUpNotificationUI(Notification notification)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Lấy vùng màn hình khả dụng (không tính taskbar)
            var screen = Screen.PrimaryScreen.WorkingArea;

            // Đặt form ở góc dưới phải
            this.Location = new Point(screen.Right - this.Width, screen.Bottom - this.Height);

            // Form luôn nổi trên cùng
            this.TopMost = true;

            // Tạo timer để tự đóng sau durationMs
            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = durationMs;
            closeTimer.Tick += (s, e) =>
            {
                closeTimer.Stop();
                this.Close();
            };

            notificationsControl1.SetNotificationData(notification);

            closeTimer.Start();
        }
    }
}
