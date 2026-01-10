using MEnU.Forms;
using MEnU.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Web;

namespace MEnU
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (args.Length > 0)
            {
                // args[0] sẽ là: menuapp://reset-password?token=ABC123
                var uri = new Uri(args[0]);
                var token = HttpUtility.ParseQueryString(uri.Query).Get("token");

                //Chỗ này mở form reset password bằng deeplink
                Application.Run(new ResetPasswordUI(token));
                return;
            }

            if (LoadToken(out string accessToken, out string refreshToken))
            {
                var success = VerifyToken(accessToken).GetAwaiter().GetResult();
                if (success)
                {
                    Application.Run(new MainHomeUI());
                    return;
                }
            }

            Application.Run(new LoginUI()); 
        }
        static async Task<bool> VerifyToken(string accessToken)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        static bool LoadToken(out string accessToken, out string refreshToken)
        {
            accessToken = refreshToken = "";

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");
            string filePath = Path.Combine(folderPath, "token.txt");

            if (!File.Exists(filePath))
                return false;

            var jwtToken = File.ReadAllText(filePath);

            string[] parts = jwtToken.Split(';');

            accessToken = parts[0];
            refreshToken = parts[1];

            return true;
        }

        static void SaveToken(string accessToken, string refreshToken)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "token.txt");

            string token = $"{accessToken};{refreshToken}";

            File.WriteAllText(filePath, token);
        }

        static async Task<bool> Refresh()
        {
            var load = LoadToken(out string AccessToken, out string RefreshToken);

            using var client = new HttpClient();
            var body = new
            {
                refreshToken = RefreshToken
            };

            var response = await client.PostAsJsonAsync($"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/refresh", body);

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