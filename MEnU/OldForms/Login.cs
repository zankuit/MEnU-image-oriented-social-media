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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegisterLinker_Click(object sender, EventArgs e)
        {
            var f = new frmRegister();
            f.Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text.Trim();
            string password = txtPasswordLogin.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Email và Mật khẩu!");
                return;
            }

            try
            {
                var user = await FirebaseAuthService.LoginAsync(email, password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    var f = new frmHome();
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
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

        private async void btnForgetPassword_Click(object sender, EventArgs e)
        {
            var f = new frmForgetPassword();
            f.Show();
            this.Hide();
        }
    }
}
