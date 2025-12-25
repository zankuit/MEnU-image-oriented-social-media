using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dangky
{
    public partial class dangky : Form
    {
        private static string ApiKey = "AIzaSyBIq-qnrhYRutiBxgBoQoJ3uBlSW9S7z4Y";
        private FirebaseAuthClient client;

        // Danh sách tên người dùng đã đăng ký (vẫn giữ lại)
        private static List<string> danhSachTenNguoiDung = new List<string>();

        public dangky()
        {
            InitializeComponent();

            var config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = "menu-67064.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };

            client = new FirebaseAuthClient(config);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e) { }

        private void tbPassword_TextChanged(object sender, EventArgs e) { }

        private async void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();
                string tenNguoiDung = tbTennguoidung.Text.Trim();

                // ===== Kiểm tra nhập đầy đủ =====
                if (string.IsNullOrEmpty(tenNguoiDung) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("⚠️ Vui lòng nhập đầy đủ Tên, Email và Mật khẩu!");
                    return;
                }

                // ===== Kiểm tra tên chứa số =====
                foreach (char c in tenNguoiDung)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("❌ Tên không hợp lệ! Không được chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // (ĐÃ BỎ kiểm tra trùng tên tại đây)

                // ===== Đăng ký Firebase =====
                var user = await client.CreateUserWithEmailAndPasswordAsync(email, password);

                // Lưu tên vào danh sách (chỉ ghi nhận, không kiểm tra trùng)
                danhSachTenNguoiDung.Add(tenNguoiDung);

                MessageBox.Show("✅ Đăng ký thành công!");
            }
            catch (FirebaseAuthException ex)
            {
                switch (ex.Reason)
                {
                    case AuthErrorReason.EmailExists:
                        MessageBox.Show("❌ Email này đã tồn tại! Hãy thử email khác.");
                        break;
                    case AuthErrorReason.InvalidEmailAddress:
                        MessageBox.Show("⚠️ Địa chỉ email không hợp lệ!");
                        break;
                    case AuthErrorReason.WeakPassword:
                        MessageBox.Show("⚠️ Mật khẩu quá yếu! Hãy nhập ít nhất 6 ký tự.");
                        break;
                    default:
                        MessageBox.Show("❌ Lỗi khi đăng ký: " + ex.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi không xác định: " + ex.Message);
            }
        }

        private async void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("⚠️ Vui lòng nhập Email và Mật khẩu!");
                    return;
                }

                var userCredential = await client.SignInWithEmailAndPasswordAsync(email, password);
                MessageBox.Show("✅ Đăng nhập thành công!");
            }
            catch (FirebaseAuthHttpException ex)
            {
                if (ex.ResponseData != null && ex.ResponseData.Contains("INVALID_LOGIN_CREDENTIALS"))
                {
                    MessageBox.Show("❌ Email hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("⚠️ Lỗi Firebase: " + ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FirebaseAuthException ex)
            {
                switch (ex.Reason)
                {
                    case AuthErrorReason.EmailExists:
                        MessageBox.Show(" Email này đã tồn tại!");
                        break;
                    case AuthErrorReason.InvalidEmailAddress:
                        MessageBox.Show("Email không hợp lệ!");
                        break;
                    case AuthErrorReason.WeakPassword:
                        MessageBox.Show("Mật khẩu quá yếu!");
                        break;
                    default:
                        MessageBox.Show(" Firebase lỗi: " + ex.Reason);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi không xác định: " + ex.Message);
            }
        }

        private void tbTennguoidung_TextChanged(object sender, EventArgs e)
        {
            string tenNguoiDung = tbTennguoidung.Text.Trim();

            if (string.IsNullOrEmpty(tenNguoiDung))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (char c in tenNguoiDung)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("❌ Tên không hợp lệ! Tên không được chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
