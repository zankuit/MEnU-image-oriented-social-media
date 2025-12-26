using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU.Forms
{
    public partial class ChangePasswordUI : Form
    {
        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public ChangePasswordUI()
        {
            InitializeComponent();
            chkShowPassword.Checked = false;
        }

        private async void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string ConfirmNewPassword = txtConfirmNewPassword.Text;

            if (currentPassword == "" || newPassword == "" || ConfirmNewPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    LoadToken(out string accessToken, out string refreshToken);
                    bool isValid = await VerifyToken(accessToken);

                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", $"{accessToken}");

                    if (!isValid)
                    {
                        var refreshed = await Refresh();
                        if (!refreshed)
                        {
                            MessageBox.Show("Session expired. Please log in again.");
                            return;
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    var body = new
                    {
                        oldPassword = currentPassword,
                        newPassword = newPassword,
                        confirmNewPassword = ConfirmNewPassword
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await client.PostAsync(@$"{baseUrl}api/user/change-password", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"{message}");
                        return;
                    }

                    MessageBox.Show("Đổi mật khẩu thành công.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //
        // TOKEN-MANIPULATE FUNCTIONS
        //

        private void LoadToken(out string accessToken, out string refreshToken)
        {
            accessToken = refreshToken = "";

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");
            string filePath = Path.Combine(folderPath, "token.txt");

            var jwtToken = File.ReadAllText(filePath);

            string[] parts = jwtToken.Split(';');

            accessToken = parts[0];
            refreshToken = parts[1];
        }

        private void SaveToken(string accessToken, string refreshToken)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "token.txt");

            string token = $"{accessToken};{refreshToken}";

            File.WriteAllText(filePath, token);
        }

        private async Task<bool> VerifyToken(string accessToken)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);

                var response = await client.GetAsync(@"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/user/verify");
                var responseJson = await response.Content.ReadAsStringAsync();

                var root = JObject.Parse(responseJson);

                return (bool)root["success"];
            }
        }

        private async Task<bool> Refresh()
        {
            LoadToken(out string AccessToken, out string RefreshToken);

            using var client = new HttpClient();
            var body = new
            {
                refreshToken = RefreshToken
            };

            var response = await client.PostAsJsonAsync($"{baseUrl}api/auth/refresh", body);

            bool success = (bool)JObject.Parse(await response.Content.ReadAsStringAsync())["success"];

            if (!success) return false;

            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
            var data = json["data"];
            //AccessToken = json["accessToken"]!.ToString();
            //RefreshToken = json["refreshToken"]!.ToString();

            SaveToken(data["accessToken"]!.ToString(), data["refreshToken"]!.ToString());

            return true;
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
