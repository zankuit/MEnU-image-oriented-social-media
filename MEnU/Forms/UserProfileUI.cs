using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace MEnU.Forms
{
    public partial class UserProfileUI : Form
    {
        long _id;
        string _username;
        string _displayName;
        string _email;
        string _avatarURL;
        int _status;

        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        //
        // TOKEN-RELATED FUNCTIONS
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

        public UserProfileUI(long id, string username, string displayName, string email, string avatarURL, int status)
        {
            InitializeComponent();

            CheckAndLoadStatus(status);

            _id = id;
            _username = username;
            _displayName = displayName;
            _email = email;
            _avatarURL = avatarURL;
            _status = status;

            this.Text = $"{_displayName}'s Profile";
        }

        private void CheckAndLoadStatus(int status)
        {
            switch (status)
            {
                case 1:
                    lblStatus.Hide();
                    lblFriendRequestQuote.Hide();
                    btnAddFriend.Show();
                    btnAcceptFriendRequest.Hide();
                    btnDeclineFriendRequest.Hide();
                    btnDeleteFriend.Hide();
                    break;
                case 2:
                    lblStatus.Hide();
                    lblFriendRequestQuote.Hide();
                    btnAddFriend.Hide();
                    btnAcceptFriendRequest.Hide();
                    btnDeclineFriendRequest.Hide();
                    btnDeleteFriend.Show();
                    break;
                case 3:
                    lblStatus.Hide();
                    lblFriendRequestQuote.Show();
                    btnAddFriend.Hide();
                    btnAcceptFriendRequest.Show();
                    btnDeclineFriendRequest.Show();
                    btnDeleteFriend.Hide();
                    break;
                case 4:
                    lblStatus.Show();
                    lblFriendRequestQuote.Hide();
                    btnAddFriend.Hide();
                    btnAcceptFriendRequest.Hide();
                    btnDeclineFriendRequest.Hide();
                    btnDeleteFriend.Hide();
                    break;
            }
        }

        private async void UserProfileUI_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "@" + _username;
            lblDisplayName.Text = _displayName;
            lblEmail.Text = _email;
            if (!string.IsNullOrEmpty(_avatarURL))
            {
                picAvatar.LoadAsync(_avatarURL);
            }
        }

        private async void btnAddFriend_Click(object sender, EventArgs e)
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

                    var body = new
                    {
                        friendId = _id
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json");

                    var response = await client.PostAsync($"{baseUrl}api/friends/add", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    var success = (bool)root["success"];
                    var message = (string)root["message"];

                    if (!success)
                    {
                        MessageBox.Show("Failed to send friend request: " + message);
                        return;
                    }

                    CheckAndLoadStatus(4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnDeclineFriendRequest_Click(object sender, EventArgs e)
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

                    var request = new HttpRequestMessage(
                        HttpMethod.Post,
                        $"{baseUrl}api/friends/reject/{_id}"
                    );

                    request.Content = null;

                    var response = await client.SendAsync(request);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi khi đồng ý kết bạn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnAcceptFriendRequest_Click(object sender, EventArgs e)
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

                    var request = new HttpRequestMessage(
                        HttpMethod.Post,
                        $"{baseUrl}api/friends/accpet/{_id}"
                    );

                    request.Content = null;

                    var response = await client.SendAsync(request);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi khi từ chối kết bạn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnDeleteFriend_Click(object sender, EventArgs e)
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

                    var request = new HttpRequestMessage(
                        HttpMethod.Delete,
                        $"{baseUrl}api/friends/{_id}"
                    );

                    var response = await client.SendAsync(request);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi khi hủy kết bạn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
