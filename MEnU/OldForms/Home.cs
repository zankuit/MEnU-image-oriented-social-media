using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            var user = FirebaseAuthService.GetCurrentUser();
            lblUsername.Text = user.Info.DisplayName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FirebaseAuthService.Logout();

            var f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnCloseHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn chắc chắn muốn thoát ứng dụng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }

    }
}
