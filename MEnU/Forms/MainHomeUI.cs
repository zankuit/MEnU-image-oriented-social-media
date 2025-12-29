using MEnU.Models;
using MEnU.Services;
using MEnU.UserControl;
using MEnU.UserControls;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design.Serialization;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MEnU.Forms
{
    public partial class MainHomeUI : Form
    {
        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public MainHomeUI()
        {
            InitializeComponent();

            // Ẩn tab bar
            //tabMenu.Appearance = TabAppearance.FlatButtons;
            //tabMenu.ItemSize = new Size(0, 1);
            //tabMenu.SizeMode = TabSizeMode.Fixed;
            rtxLog.Hide();

            //flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;
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

        //
        // HOME TAB (photo)
        //

        long currentPhotoPage = -1;
        long currentPhotoId = -1;

        private async void btnDown_Click(object sender, EventArgs e)
        {
            //DisableHomeComponent();
            picAvatarPost.Image = Properties.Resources.AvatarIcon;

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

                    var response = await client.GetAsync($@"{baseUrl}api/photos/move?currentPhotoId={currentPhotoId}&direction={"down"}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Lỗi xảy ra khi load ảnh: {message}");
                        return;
                    }

                    if (message[0] == 'N')
                    {
                        //EnableHomeComponent();

                        return;
                    }

                    var photo = root["data"].ToObject<Photo>();

                    currentPhotoId = photo.photoId;
                    currentPhotoPage++;

                    picImage.LoadAsync(photo.photoURL);
                    txtShowCaption.Text = photo.caption;

                    if (photo.ownerAvatarURL != null) picAvatarPost.LoadAsync(photo.ownerAvatarURL);
                    lblDisplayNamePost.Text = photo.ownerDisplayName;
                    lblTimePost.Text = ToTimeAgo(photo.createdAt);

                    //EnableHomeComponent();
                    lblNoPhotoYet.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnUp_Click(object sender, EventArgs e)
        {
            //DisableHomeComponent();
            picAvatarPost.Image = Properties.Resources.AvatarIcon;

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

                    var response = await client.GetAsync($@"{baseUrl}api/photos/move?currentPhotoId={currentPhotoId}&direction={"up"}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Lỗi xảy ra khi load ảnh: {message}");
                        return;
                    }

                    if (message[0] == 'N')
                    {
                        //EnableHomeComponent();

                        return;
                    }

                    var photo = root["data"].ToObject<Photo>();

                    currentPhotoId = photo.photoId;
                    currentPhotoPage--;

                    picImage.LoadAsync(photo.photoURL);
                    txtShowCaption.Text = photo.caption;

                    if (photo.ownerAvatarURL != null) picAvatarPost.LoadAsync(photo.ownerAvatarURL);
                    lblDisplayNamePost.Text = photo.ownerDisplayName;
                    lblTimePost.Text = ToTimeAgo(photo.createdAt);

                    //EnableHomeComponent();
                    lblNoPhotoYet.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //
        // CHAT TAB
        //
        bool isInChatTab = false;

        long currentChatUserId;
        int currentPage;
        bool isLoadingOldMessages;
        bool hasMoreMessages = true;

        string myAvatarUrl;
        string myUsername;

        string friendAvatarUrl;
        string friendDisplayName;
        string currentFriendUsername;
        long currentFriendId;

        private async void OpenChat(long userId)
        {
            flowLayoutPanel1.Visible = true;

            currentChatUserId = userId;
            currentPage = 0;
            isLoadingOldMessages = false;
            hasMoreMessages = true;

            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.ResumeLayout();
            currentPage = 0;

            try
            {
                // 3. Load info của mình (1 lần)
                var me = await GetMyInfo();
                myAvatarUrl = me.avatarURL;
                myUsername = me.username;

                // 4. Load profile friend
                await LoadFriendProfile(userId);

                // 5. Load page 0 (20 tin gần nhất)
                await LoadMessagesPage(
                    userId,
                    page: 0,
                    isFirstLoad: true
                );

                btnSendContent.Visible = true;
                txtContent.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở cuộc trò chuyện: " + ex.Message);
            }
        }

        private async Task<List<Messsage>> FetchMessages(long friendId, int page)
        {
            using (HttpClient client = new HttpClient())
            {
                LoadToken(out string accessToken, out _);
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

                var builder = new UriBuilder(
                    $"{baseUrl}api/message/{friendId}/messages"
                );

                var query = HttpUtility.ParseQueryString(builder.Query);
                query["page"] = page.ToString();
                query["size"] = "20";
                builder.Query = query.ToString();

                var response = await client.GetAsync(builder.Uri);

                var json = await response.Content.ReadAsStringAsync();
                var root = JObject.Parse(json);

                if (!(bool)root["success"])
                    throw new Exception((string)root["message"]);

                return root["data"]["content"].ToObject<List<Messsage>>();
            }
        }

        private async Task LoadMessagesPage(long friendId, int page, bool isFirstLoad)
        {
            if (isLoadingOldMessages) return;
            if (!hasMoreMessages) return;

            isLoadingOldMessages = true;

            try
            {
                var messages = await FetchMessages(friendId, page);

                // TRƯỜNG HỢP QUAN TRỌNG NHẤT
                if (messages.Count == 0 || messages == null)
                {
                    hasMoreMessages = false;
                    isLoadingOldMessages = false;
                    return;
                }

                messages.Reverse(); // oldest → newest

                int oldHeight = flowLayoutPanel1.DisplayRectangle.Height;

                flowLayoutPanel1.SuspendLayout();

                if (isFirstLoad)
                {
                    foreach (var msg in messages)
                    {
                        flowLayoutPanel1.Controls.Add(
                            await CreateMessageBubble(msg)
                        );
                    }
                }
                else
                {
                    int index = 0;
                    foreach (var msg in messages)
                    {
                        var bubble = await CreateMessageBubble(msg);
                        flowLayoutPanel1.Controls.Add(bubble);
                        flowLayoutPanel1.Controls.SetChildIndex(bubble, index++);
                    }
                }

                flowLayoutPanel1.ResumeLayout();

                if (isFirstLoad)
                {
                    flowLayoutPanel1.ScrollControlIntoView(
                        flowLayoutPanel1.Controls[^1]
                    );
                }
                else
                {
                    int newHeight = flowLayoutPanel1.DisplayRectangle.Height;
                    flowLayoutPanel1.VerticalScroll.Value +=
                        (newHeight - oldHeight);
                }

                // Nếu ít hơn size (20) → cũng là hết
                if (messages.Count < 20)
                    hasMoreMessages = false;

            }
            finally
            {
                isLoadingOldMessages = false;
            }

        }


        //
        // FRIENDS TAB
        //

        private async Task GetAndDisplayFriends()
        {
            flpListFriend.Controls.Clear();
            lblNoFriend.Visible = true;

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

                    var response = await client.GetAsync($@"{baseUrl}api/user/friends");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Lỗi: {message}");
                        return;
                    }

                    var friends = root["data"].ToObject<List<User>>();

                    if (friends.Count == 0)
                    {
                        lblNoFriend.Visible = true;
                        flpListFriend.Controls.Add(lblNoFriend);
                        return;
                    }

                    for (int i = 0; i < friends.Count; i++)
                    {
                        User user = friends[i];

                        FriendControl item = new FriendControl();

                        item.ChatClicked += f =>
                        {
                            // dùng OpenChat;
                            tabMenu.SelectedIndex = 1;
                            OpenChat(f.id);
                        };

                        item.BindData(user);

                        flpListFriend.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<User>> GetFriends()
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
                            return new List<User>();
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    var response = await client.GetAsync($@"{baseUrl}api/user/friends");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Lỗi: {message}");
                        return new List<User>();
                    }

                    var friends = root["data"].ToObject<List<User>>();

                    if (friends.Count == 0)
                    {
                        return new List<User>();
                    }

                    return friends;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private async Task DisplayFriendsWhoAreRequesting()
        {
            flpListUserRequest.Controls.Clear();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    LoadToken(out string accessToken, out _);
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

                    var response = await client.GetAsync($"{baseUrl}api/friends/pending");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    var success = (bool)root["success"];
                    var message = root["message"].ToString();

                    var friendRequests = root["data"].ToObject<List<FriendRequest>>();

                    if (!success)
                    {
                        MessageBox.Show("Không thể load yêu cầu kết bạn: " + message);
                    }

                    if (friendRequests.Count == 0 || friendRequests == null) return;

                    foreach (var fr in friendRequests)
                    {
                        var item = new FrienRequestControl();
                        item.BindData(fr);

                        item.AcceptClicked += friendId =>
                        {
                            BeginInvoke(new Action(async () =>
                            {
                                await AcceptRequest(friendId);
                                await DisplayFriendsWhoAreRequesting();
                            }));
                        };

                        item.RejectClicked += friendId =>
                        {
                            BeginInvoke(new Action(async () =>
                            {
                                await RejectRequest(friendId);
                                await DisplayFriendsWhoAreRequesting();
                            }));
                        };

                        flpListUserRequest.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load yêu cầu kết bạn: " + ex.Message);
            }

        }

        //
        // NOTIFICATIONS TAB
        //



        //
        // SETTINGS TAB
        //
        string usernameSetting;
        string displayNameSetting;
        string emailSetting;
        string avatarUrlSetting;

        private async Task DisplayUserInfoInSetting()
        {
            try
            {
                User me = await GetMyInfo();

                usernameSetting = me.username;
                displayNameSetting = me.displayName;
                emailSetting = me.email;
                avatarUrlSetting = me.avatarURL;

                if (me.avatarURL != null) picAvatarSetting.LoadAsync(me.avatarURL);

                txtUsername.Text = me.username;
                txtDisplayname.Text = me.displayName;
                txtEmail.Text = me.email;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load thông tin người dùng " + ex.Message);
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var f = new ConfirmDeleteAccountUI();

            f.AccountDeleted += () =>
            {
                this.Hide();
                new LoginUI().Show();
            };

            f.ShowDialog();
        }


        //
        // LINH TINH
        //
        RealtimeService _realtime;


    }
}
