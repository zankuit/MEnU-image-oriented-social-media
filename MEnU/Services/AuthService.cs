using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MEnU.Services
{
    public class AuthService
    {
        private System.Windows.Forms.Timer _timer;
        private bool _isRefreshing = false;

        // số phút giữa mỗi lần check
        private const int REFRESH_INTERVAL_MINUTES = 5;

        public void Start()
        {
            if (_timer != null) return;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = REFRESH_INTERVAL_MINUTES * 60 * 1000;
            _timer.Tick += async (s, e) => await HandleRefreshTick();
            _timer.Start();
        }

        public void Stop()
        {
            _timer?.Stop();
            _timer = null;
        }

        private async Task HandleRefreshTick()
        {
            if (_isRefreshing) return; // chống refresh chồng
            _isRefreshing = true;

            try
            {
                LoadToken(out string accessToken, out _);

                bool isValid = await VerifyToken(accessToken);
                if (!isValid)
                {
                    bool refreshed = await Refresh();
                    if (!refreshed)
                    {
                        Stop();
                        ClearToken();

                        MessageBox.Show(
                            "Phiên đăng nhập đã hết hạn. Vui lòng đăng nhập lại.",
                            "Hết phiên",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        Application.Restart();
                    }
                }
            }
            catch
            {
                // im lặng, tick sau xử tiếp
            }
            finally
            {
                _isRefreshing = false;
            }
        }

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

        private void ClearToken()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");
            string filePath = Path.Combine(folderPath, "token.txt");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

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

            var response = await client.PostAsJsonAsync("https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/refresh", body);

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
