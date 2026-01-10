using MEnU.Forms;
using MEnU.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MEnU.UserControls
{
    public partial class FriendControl : System.Windows.Forms.UserControl
    {
        long id;
        string? username;
        string? displayName;
        string? email;
        string? avatarURL;
        int status;

        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public FriendControl()
        {
            InitializeComponent();
        }

        //
        // FUNCTIONS
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

        public void BindData(MEnU.Models.User user)
        {
            id = user.id; // Lưu id để dùng khi gọi API 
            username = user.username;
            displayName = user.displayName;

            llbDisplayName.Text = displayName;
            lblUsername.Text = "@" + username;

            if (user.avatarURL != null) picAvatar.LoadAsync(user.avatarURL);
        }

        private async void llbDisplayName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    LoadToken(out string accessToken, out string refreshToken);
                    bool isValid = await VerifyToken(accessToken);

                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", accessToken);

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

                    var response = await client.GetAsync($"{baseUrl}api/friends/profile/{id}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    var success = (bool)root["success"];
                    var message = (string)root["message"];

                    if (!success)
                    {
                        MessageBox.Show("Failed to retrieve user profile: " + message);
                        return;
                    }

                    var userData = root["data"];

                    username = (string?)userData["username"];
                    displayName = (string?)userData["displayName"];
                    email = (string?)userData["email"];
                    avatarURL = (string?)userData["avatarURL"];
                    status = (int)userData["status"];


                    new UserProfileUI(id, username, displayName, email, avatarURL, status).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while verifying the session. Please log in again.\r\n{ex.Message}");
                return;
            }
        }

        public event Action<User> ChatClicked;
        private async void btnChat_Click(object sender, EventArgs e)
        {
            MEnU.Models.User friend = new MEnU.Models.User();
            friend.id = id;
            friend.username = username;
            friend.displayName = displayName;
            friend.email = email;
            friend.avatarURL = avatarURL;

            await Seen(friend.id);

            ChatClicked?.Invoke(friend);
        }

        private async Task Seen(long friendId)
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

                var request = new HttpRequestMessage(
                    HttpMethod.Put,
                    $"{baseUrl}api/message/{friendId}/seen"
                );

                request.Content = null;

                var response = await client.SendAsync(request);
            }
        }
    }
}
