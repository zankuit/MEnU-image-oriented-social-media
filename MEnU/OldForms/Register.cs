using Firebase.Auth;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmailRegister.Text.Trim();
            string displayName = txtDisplayNameRegister.Text.Trim();
            string password = txtPasswordRegister.Text;

            if (string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên hiển thị, Email và Mật khẩu!");
                return;
            }

            foreach (char c in displayName)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Tên không hợp lệ! Không được chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                var user = await FirebaseAuthService.RegisterAsync(email, password, displayName);

                if (user != false)
                {
                    MessageBox.Show("Đăng kí thành công");

                    var f = new frmLogin();
                    f.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginLinker_Click(object sender, EventArgs e)
        {
            var f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
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
