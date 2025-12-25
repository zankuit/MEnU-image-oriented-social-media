using MEnU.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MEnU.UserControls
{
    public partial class ChatListControl : System.Windows.Forms.UserControl
    {
        public long friendId { get; set; }
        string? username;
        string? displayName;
        string? email;
        string? avatarURL;
        int status;

        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public ChatListControl()
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

        public void BindData(MEnU.Models.ConversationPreview conversationPreview)
        {
            friendId = conversationPreview.friendId;

            string lastMessage = conversationPreview.lastMessage;

            if (lastMessage != null && lastMessage.Length > 15)
            {
                lastMessage = lastMessage.Substring(0, 15) + "...";
            }

            lblLastMessage.Text = lastMessage;
            llbDisplayName.Text = conversationPreview.displayName;

            if (conversationPreview.avatarURL != null) picAvatar.LoadAsync(conversationPreview.avatarURL);
        }

        public void BindDataRealtime(string lastMessage, long friendIdThatNeedToBeUpdated)
        {
            
        }

        public event Action<User> ChatClicked;

        private void llbDisplayName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MEnU.Models.User friend = new MEnU.Models.User();
            friend.id = friendId;
            friend.username = username;
            friend.displayName = displayName;
            friend.email = email;
            friend.avatarURL = avatarURL;

            ChatClicked?.Invoke(friend);
        }
    }
}
