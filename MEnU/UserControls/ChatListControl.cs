using MEnU.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MEnU.UserControls
{
    public partial class ChatListControl : System.Windows.Forms.UserControl
    {
        public long friendId { get; set; }
        public string? username { get; set; }
        public string? displayName { get; set; }
        public string? email { get; set; }
        public string? avatarURL { get; set; }
        public bool hasUnread { get; set; }

        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public ChatListControl()
        {
            InitializeComponent();
        }

        //
        // FUNCTIONS
        //
        public void UpdateLastedMessageRealtime(string lastedMessage)
        {
            if (lastedMessage != null && lastedMessage.Length > 15)
            {
                lastedMessage = lastedMessage.Substring(0, 15) + "...";
            }

            lblLastMessage.Text = lastedMessage;
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

        public void SetSeen(bool hasUnread)
        {
            lblLastMessage.ForeColor = hasUnread ? Color.White : Color.Silver;

            // Đổi Bold
            FontStyle style = hasUnread ? FontStyle.Bold : FontStyle.Regular;

            lblUnseenStatus.Visible = hasUnread ? true : false;

            if (lblLastMessage.Font.Style != style)
            {
                lblLastMessage.Font = new Font(lblLastMessage.Font, style);
            }
        }

        public async Task BindData(MEnU.Models.ConversationPreview conversationPreview)
        {
            friendId = conversationPreview.friendId;
            username = conversationPreview.username;
            hasUnread = conversationPreview.hasUnread;

            string lastMessage = conversationPreview.lastMessage;

            if (lastMessage != null && lastMessage.Length > 15)
            {
                lastMessage = lastMessage.Substring(0, 15) + "...";
            }

            SetSeen(conversationPreview.hasUnread);

            llbDisplayName.Text = conversationPreview.displayName;
            lblLastMessage.Text = lastMessage;

            if (conversationPreview.avatarURL != null) picAvatar.LoadAsync(conversationPreview.avatarURL);
        }

        public event Action<User> ChatClicked;

        private async void llbDisplayName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (hasUnread == true) await Seen(friendId);

            MEnU.Models.User friend = new MEnU.Models.User();
            friend.id = friendId;
            friend.username = username;
            friend.displayName = displayName;
            friend.email = email;
            friend.avatarURL = avatarURL;

            SetSeen(false);

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
