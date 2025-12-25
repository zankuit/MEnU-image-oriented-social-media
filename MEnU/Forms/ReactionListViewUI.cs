using MEnU.Models;
using MEnU.UserControls;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MEnU.Forms
{
    public partial class ReactionListViewUI : Form
    {
        List<Reaction> _reactions;

        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public ReactionListViewUI(List<Reaction> reactions)
        {
            InitializeComponent();
            flpReactionList.Controls.Clear();
            _reactions = reactions;
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

        
        private async void ReactionListViewUI_Load(object sender, EventArgs e)
        {
            if (_reactions == null || _reactions.Count == 0)
            {
                flpReactionList.Controls.Add(lblNoReactionYet);
                return;
            }

            List<int> danhsach = new List<int>();

            foreach (int n in danhsach)
            {
                
            }

            foreach (var reaction in _reactions)
            {
                User userReact = await GetUserInfo(reaction.userId);

                if (userReact == null) continue;

                var item = new ReactListControl();
                item.BindData(reaction, $"{userReact.displayName}", $"{userReact.avatarURL}");

                flpReactionList.Controls.Add(item);
            }
        }

        private async Task<User> GetUserInfo(long userId)
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
                            return null;
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    var response = await client.GetAsync($"{baseUrl}api/friends/profile/{userId}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    var success = (bool)root["success"];
                    var message = (string)root["message"];

                    if (!success)
                    {
                        MessageBox.Show("Failed to retrieve user profile: " + message);
                        return null;
                    }

                    var user = root["data"].ToObject<User>();

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error\r\n{ex.Message}");
                return null;
            }
        }
    
    }
}
