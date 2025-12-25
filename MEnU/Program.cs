using MEnU.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

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
            //if (args.Length > 0)
            //{
            //    // args[0] sẽ là: menuapp://reset-password?token=ABC123
            //    var uri = new Uri(args[0]);
            //    var token = HttpUtility.ParseQueryString(uri.Query).Get("token");

            //    //Chỗ này mở form reset password bằng deeplink và truyền token vào, chưa làm
            //    return;
            //}

            //if (LoadToken(out string accessToken, out string refreshToken))
            //{
            //    var success = VerifyToken(accessToken).GetAwaiter().GetResult();
            //    if (success)
            //    {
            //        Application.Run(new MainHomeUI());
            //        return;
            //    }
            //}

            Application.Run(new MainHomeUI());
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
    }
}