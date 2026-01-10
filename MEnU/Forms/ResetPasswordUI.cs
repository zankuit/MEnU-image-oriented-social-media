using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MEnU.Forms
{
    public partial class ResetPasswordUI : Form
    {
        string _token;

        public ResetPasswordUI(string token)
        {
            InitializeComponent();
            _token = token;
            chkShowPassword.Checked = false;
        }

        private async void btnConfirmResetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmedNewPassword = txtConfirmNewPassword.Text;

            if (newPassword != confirmedNewPassword)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new
                    {
                        token = _token,
                        newPassword = newPassword,
                        confirmPassword = confirmedNewPassword
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                        );

                    var response = await client.PostAsync(@"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/reset-password", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    var message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Lỗi khi reset mật khẩu: {message}", "Thông báo");
                        return;
                    }

                    MessageBox.Show($"Reset mật khẩu thành công", "Thông báo");
                    this.Hide();
                    new LoginUI().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ResetPasswordUI_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmNewPassword.UseSystemPasswordChar = false;

                txtNewPassword.PasswordChar = '\0';
                txtConfirmNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmNewPassword.UseSystemPasswordChar = true;

                txtNewPassword.PasswordChar = '*';
                txtConfirmNewPassword.PasswordChar = '*';
            }
        }
    }
}
