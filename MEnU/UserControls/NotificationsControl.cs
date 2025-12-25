using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU.UserControls
{
    public partial class NotificationsControl : System.Windows.Forms.UserControl
    {
        public NotificationsControl()
        {
            InitializeComponent();
        }

        public void SetNotificationData(Models.Notification notification)
        {
            lblUsername.Text = notification.fromUsername;
            lblNotificationMessage.Text = notification.message;
            lblTime.Text = ToTimeAgo(notification.createdAt);
        }

        public static string ToTimeAgo(DateTimeOffset createdAtUtc)
        {
            var now = DateTimeOffset.UtcNow;
            var diff = now - createdAtUtc;

            if (diff.TotalSeconds < 60)
                return "Vừa xong";

            if (diff.TotalMinutes < 60)
                return $"{(int)diff.TotalMinutes} phút trước";

            if (diff.TotalHours < 24)
                return $"{(int)diff.TotalHours} giờ trước";

            if (diff.TotalDays < 7)
                return $"{(int)diff.TotalDays} ngày trước";

            return createdAtUtc.ToLocalTime().ToString("dd/MM/yyyy");
        }
    }
}
