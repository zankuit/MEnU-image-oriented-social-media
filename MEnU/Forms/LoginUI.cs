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

namespace MEnU.Forms
{

    public partial class LoginUI : Form
    {
        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev";
        public LoginUI()
        {
            InitializeComponent();
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

        private async void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmailLogin.Text.Trim();
            string password = txtPasswordLogin.Text;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new
                    {
                        username = username,
                        password = password
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await client.PostAsync($"{baseUrl}/api/auth/login", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    var success = (bool)root["success"];

                    var message = root["message"]?.ToString();

                    var accessToken = root["data"]?["accessToken"]?.ToString();

                    var refreshToken = root["data"]?["refreshToken"]?.ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {message}", "Lỗi");
                        return;
                    }

                    SaveToken(accessToken, refreshToken);

                    MessageBox.Show($"Đăng nhập thành công", "Thông báo");

                    this.Hide();
                    new MainHomeUI().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errors: {ex.Message}", "Lỗi");
            }
        }

        private void btnSignupLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterUI().Show();
        }
    }
}
