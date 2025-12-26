using MEnU.Models;
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
    public partial class ConfirmDeleteAccountUI : Form
    {
        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        User me = new User();

        public ConfirmDeleteAccountUI()
        {
            InitializeComponent();
        }

        private async void btnConfirmDeleteAccount_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != me.username)
            {
                MessageBox.Show("Tên tài khoản không khớp. Vui lòng thử lại.");
                return;
            }

            var result = MessageBox.Show("Bạn vẫn quyết định xóa tài khoản này?", "Xác nhận",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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

                        var response = await client.DeleteAsync(@$"{baseUrl}api/user/me");
                        var responseJson = await response.Content.ReadAsStringAsync();

                        var root = JObject.Parse(responseJson);

                        bool success = (bool)root["success"];
                        string message = root["message"].ToString();

                        if (!success)
                        {
                            MessageBox.Show($"{message}");
                            return;
                        }

                        MessageBox.Show("Xóa tài khoản thành công");
                        this.Hide();
                        new LoginUI().Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                return;
            }
        }

        private async void ConfirmDeleteAccountUI_Load(object sender, EventArgs e)
        {
            me = await GetMyInfo();
        }

        private async Task<Models.User> GetMyInfo()
        {
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
                            throw new Exception("Session expired. Please log in again.");
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    var response = await client.GetAsync(@$"{baseUrl}api/user/profile");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        throw new Exception("Không thể lấy thông tin người dùng.");
                    }

                    var user = root["data"].ToObject<Models.User>();

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
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


    }
}
