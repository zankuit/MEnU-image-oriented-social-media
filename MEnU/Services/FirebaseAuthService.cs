using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnU
{
    public static class FirebaseAuthService
    {
        private static FirebaseAuthClient _client;

        // Gọi hàm này 1 lần ở Program.cs khi app khởi động
        public static void Initialize()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAXNi2gzQEy6LKMcC7wOv7gC1bScE0tTAY",
                AuthDomain = "testingauth-2b562.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("MEnU") // lưu token cục bộ
            };

            _client = new FirebaseAuthClient(config);
        }

        //Đăng ký tài khoản
        public static async Task<bool> RegisterAsync(string email, string password, string displayName)
        {
            try
            {
                await _client.CreateUserWithEmailAndPasswordAsync(email, password, displayName);
                return true;
            }
            catch (FirebaseAuthException ex)
            {
                // Kiểm tra mã lỗi cụ thể
                if (ex.Reason == AuthErrorReason.EmailExists)
                {
                    MessageBox.Show("Email này đã được đăng ký rồi!");
                }
                else if (ex.Reason == AuthErrorReason.WeakPassword)
                {
                    MessageBox.Show("Mật khẩu quá yếu. Vui lòng chọn mật khẩu mạnh hơn!");
                }
                else if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ!");
                }
                else
                {
                    MessageBox.Show($"Lỗi đăng ký: {ex.Reason}");
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}");
                return false;
            }
        }

        //Đăng nhập
        public static async Task<User> LoginAsync(string email, string password)
        {
            try
            {
                var userCredential = await _client.SignInWithEmailAndPasswordAsync(email, password);
                return userCredential.User;
            }
            catch (FirebaseAuthException ex)
            {
                //string message = ex.Reason switch
                //{
                //    AuthErrorReason.UnknownEmailAddress => "Email này chưa được đăng ký!",
                //    AuthErrorReason.WrongPassword => "Sai mật khẩu, vui lòng thử lại!",
                //    AuthErrorReason.InvalidEmailAddress => "Email không hợp lệ!",
                //    AuthErrorReason.UserDisabled => "Tài khoản này đã bị vô hiệu hóa!",
                //    AuthErrorReason.TooManyAttemptsTryLater => "Bạn đăng nhập sai quá nhiều lần. Vui lòng thử lại sau!",
                //    _ => $"Lỗi không xác định: {ex.Reason}"
                //};

                //MessageBox.Show(message, "Lỗi đăng nhập",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //return null;
                string message;
                if (ex.Message.Contains("INVALID_PASSWORD"))
                    message = "Sai mật khẩu, vui lòng thử lại!";
                else if (ex.Message.Contains("EMAIL_NOT_FOUND"))
                    message = "Email này chưa được đăng ký!";
                else if (ex.Message.Contains("INVALID_EMAIL"))
                    message = "Địa chỉ email không hợp lệ!";
                else
                    message = $"Lỗi đăng nhập không xác định: {ex.Message}";
                MessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Đăng xuất
        public static void Logout()
        {
            _client.SignOut(); // xoá thông tin đăng nhập cục bộ
        }

        //Gửi email khôi phục mật khẩu
        public static async Task<bool> SendPasswordResetEmailAsync(string email)
        {
            try
            {
                await _client.ResetEmailPasswordAsync(email);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }

        // Tự động đăng nhập lại (nếu còn token)
        public static User GetCurrentUser()
        {
            return _client.User; // null nếu chưa đăng nhập
        }
    }
}
