using MEnU.Models;
using MEnU.Services;
using MEnU.UserControl;
using MEnU.UserControls;
using Microsoft.VisualBasic;
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

            DisableHomeComponent();
            btnDownloadPost.Visible = false;
            btnDeletePost.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;

            flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;
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
        long currentOnwerId = -1;

        private async void btnDown_Click(object sender, EventArgs e)
        {
            //DisableHomeComponent();

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

                    picAvatarPost.Image = Properties.Resources.AvatarIcon;
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

                    picAvatarPost.Image = Properties.Resources.AvatarIcon;
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

        private void btnLoadimage_Click(object sender, EventArgs e)
        {
            new UploadPhotoUI().ShowDialog();
        }

        private async Task LoadHomeData()
        {
            DisableHomeComponent();
            btnDownloadPost.Visible = false;
            btnDeletePost.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            lblNoPhotoYet.Visible = false;

            currentPhotoPage = 0;

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

                    var response = await client.GetAsync($@"{baseUrl}api/photos/home");
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
                        lblNoPhotoYet.Visible = true;
                        return;
                    }

                    lblNoPhotoYet.Visible = false;

                    var photo = root["data"].ToObject<Photo>();

                    currentPhotoId = photo.photoId;
                    currentOnwerId = photo.ownerId;

                    picImage.LoadAsync(photo.photoURL);
                    txtShowCaption.Text = photo.caption;

                    if (photo.ownerAvatarURL != null) picAvatarPost.LoadAsync(photo.ownerAvatarURL);
                    lblDisplayNamePost.Text = photo.ownerDisplayName;
                    lblTimePost.Text = ToTimeAgo(photo.createdAt);

                    EnableHomeComponent();
                    btnDownloadPost.Visible = true;
                    btnDeletePost.Visible = true;
                    btnUp.Visible = true;
                    btnDown.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnRefreshHome_Click(object sender, EventArgs e)
        {
            await LoadHomeData();
        }

        private void DisableHomeComponent()
        {
            picImage.Visible = false;
            picAvatarPost.Visible = false;
            lblDisplayNamePost.Visible = false;
            lblTimePost.Visible = false;
            llbViewReactions.Visible = false;
            txtShowCaption.Visible = false;
            txtReactChat.Visible = false;
            btnReactHaha.Visible = false;
            btnReactHeart.Visible = false;
            btnReactHug.Visible = false;
            btnReactSad.Visible = false;
            btnSendReactChat.Visible = false;
        }

        private void EnableHomeComponent()
        {
            picImage.Visible = true;
            picAvatarPost.Visible = true;
            lblDisplayNamePost.Visible = true;
            lblTimePost.Visible = true;
            llbViewReactions.Visible = true;
            txtShowCaption.Visible = true;
            txtReactChat.Visible = true;
            btnReactHaha.Visible = true;
            btnReactHeart.Visible = true;
            btnReactHug.Visible = true;
            btnReactSad.Visible = true;
            btnSendReactChat.Visible = true;
        }

        private async void btnSendReactChat_Click(object sender, EventArgs e)
        {
            string comment = txtReactChat.Text.Trim();

            if (String.IsNullOrEmpty(comment)) return;

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

                    var body = new
                    {
                        comment = comment
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json");

                    var response = await client.PostAsync($"{baseUrl}api/photos/{currentPhotoId}/comment", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show("Lỗi khi gửi comment" + message);
                        return;
                    }

                    MessageBox.Show("Gửi tin nhắn thành công");
                    await Seen(currentOnwerId);
                    txtReactChat.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnReactHeart_Click(object sender, EventArgs e)
        {
            await ReactPhoto(currentPhotoId, "heart");
        }

        private async void btnReactHaha_Click(object sender, EventArgs e)
        {
            await ReactPhoto(currentPhotoId, "haha");
        }

        private async void btnReactHug_Click(object sender, EventArgs e)
        {
            await ReactPhoto(currentPhotoId, "hug");
        }

        private async void btnReactSad_Click(object sender, EventArgs e)
        {
            await ReactPhoto(currentPhotoId, "sad");
        }

        private async Task ReactPhoto(long photoId, string reaction)
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

                    var response = await client.PostAsync(
                        $"{baseUrl}api/photos/reactions/{photoId}?emoji={reaction}", null);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show("Lỗi khi gửi reaction" + message);
                        return;
                    }

                    MessageBox.Show("Đã gửi react!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void llbViewReactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

                    var response = await client.GetAsync($"{baseUrl}api/photos/reaction/{currentPhotoId}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show("Không thể xem reactions" + message);
                        return;
                    }

                    var reactions = root["data"].ToObject<List<Reaction>>();

                    new ReactionListViewUI(reactions).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnDownloadPost_Click(object sender, EventArgs e)
        {
            long photoId = currentPhotoId;

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Chọn nơi lưu ảnh";
                saveDialog.Filter = "JPEG Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png|All files (*.*)|*.*";
                saveDialog.FileName = $"photo_{photoId}.jpg";

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                btnDownloadPost.Enabled = false;

                try
                {
                    await DownloadPhotoAsync(photoId, saveDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi tải ảnh: {ex.Message}");
                }
                finally
                {
                    btnDownloadPost.Enabled = true;
                }
            }
        }

        private async Task DownloadPhotoAsync(long photoId, string filePath)
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

                    LoadToken(out string newAccess, out _);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", newAccess);
                }

                using (var response = await client.GetAsync(
                    @$"{baseUrl}api/photos/{photoId}/download",
                    HttpCompletionOption.ResponseHeadersRead))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Không thể tải ảnh");
                        return;
                    }

                    using (var stream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(
                        filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }

                MessageBox.Show("Lưu ảnh thành công");
            }
        }

        private async void btnDeletePost_Click(object sender, EventArgs e)
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
                        $"{baseUrl}api/photos/photos/{currentPhotoId}"
                    );

                    var response = await client.SendAsync(request);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    var message = root["message"].ToString();

                    if (!success)
                    {
                        MessageBox.Show("Không thể xóa ảnh: " + message);
                        return;
                    }

                    MessageBox.Show("Đã xóa ảnh!");
                    await LoadHomeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
        bool isSelfChat;

        string friendAvatarUrl;
        string friendDisplayName;
        string currentFriendUsername;
        long currentFriendId;

        private async void OpenChat(long userId)
        {
            Cursor.Current = Cursors.WaitCursor;

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

                if (currentFriendUsername == me.username)
                    isSelfChat = true;

                // 5. Load page 0 (20 tin gần nhất)
                await LoadMessagesPage(
                    userId,
                    page: 0,
                    isFirstLoad: true
                );

                btnSendContent.Visible = true;
                txtContent.Visible = true;

                Cursor.Current = Cursors.Default;
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

        private async Task<MessageBubbleControl> CreateMessageBubble(Messsage msg)
        {
            var item = new MessageBubbleControl();

            if (msg.fromUsername == myUsername)
                await item.SetMessage(msg, myAvatarUrl);
            else
                await item.SetMessage(msg, friendAvatarUrl);

            return item;
        }

        private async Task AddMessageToUI(Messsage msg, bool scrollToBottom = false)
        {
            var bubble = new MessageBubbleControl();

            if (msg.fromUsername == myUsername)
                await bubble.SetMessage(msg, myAvatarUrl);
            else
                await bubble.SetMessage(msg, friendAvatarUrl);

            flowLayoutPanel1.Controls.Add(bubble);

            if (scrollToBottom)
                flowLayoutPanel1.ScrollControlIntoView(bubble);
        }

        private async void FlowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (currentChatUserId == -1) return;
            if (isLoadingOldMessages) return;
            if (!hasMoreMessages) return;

            if (flowLayoutPanel1.VerticalScroll.Value != 0) return;

            currentPage++;

            await LoadMessagesPage(
                currentChatUserId,
                currentPage,
                isFirstLoad: false
            );
        }

        private async Task GetAndDisplayConversation()
        {
            flpListFriendChat.Controls.Clear();

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

                    var response = await client.GetAsync($@"{baseUrl}api/message/chats");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();


                    if (!success)
                    {
                        MessageBox.Show($"Lỗi: {message}");
                        return;
                    }

                    if (!responseJson.Contains("data"))
                    {
                        flpListFriendChat.Controls.Add(llbStartChat);
                        return;
                    }

                    var conversations = root["data"].ToObject<List<ConversationPreview>>();

                    for (int i = 0; i < conversations.Count; i++)
                    {
                        ConversationPreview conversation = conversations[i];

                        ChatListControl item = new ChatListControl();
                        item.BindData(conversation);

                        flpListFriendChat.Controls.Add(item);

                        item.ChatClicked += f =>
                        {
                            // dùng OpenChat;
                            OpenChat(f.id);
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void llbStartChat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var friends = await GetFriends();

            var f = new SelectFriendToChatUI(friends);

            f.FriendSelected += (user) =>
            {
                // Open chat with selected friend
                OpenChat(user.id);
            };

            f.ShowDialog();
        }

        private async Task LoadFriendProfile(long friendId)
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
                        throw new Exception("Session expired");

                    LoadToken(out string newAccess, out _);
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", newAccess);
                }

                var response = await client.GetAsync(
                    $"{baseUrl}api/friends/profile/{friendId}"
                );

                var json = await response.Content.ReadAsStringAsync();
                var root = JObject.Parse(json);

                if (!(bool)root["success"])
                    throw new Exception((string)root["message"]);

                var data = root["data"];
                friendAvatarUrl = (string?)data["avatarURL"];
                friendDisplayName = (string)data["displayName"];
                currentFriendUsername = (string)data["username"];
                currentFriendId = (long)data["id"];
                // Update UI
                picAvatarTitleChat.Image = Properties.Resources.AvatarIcon;
                picAvatarTitleChat.Visible = true;
                lblDisplayNameTitleChat.Visible = true;
                lblDisplayNameTitleChat.Text = friendDisplayName;

                if (!string.IsNullOrEmpty(friendAvatarUrl))
                    picAvatarTitleChat.LoadAsync(friendAvatarUrl);
            }
        }

        private async void HandleRealtimeChat(RealtimeMessageDto rtMsg)
        {
            if (isSelfChat) return;

            if (rtMsg.FromUsername != currentFriendUsername &&
                rtMsg.ToUsername != currentFriendUsername)
                return;

            var msg = rtMsg.ToMessage();

            var bubble = new MessageBubbleControl();

            if (msg.fromUsername == myUsername)
                await bubble.SetMessage(msg, myAvatarUrl);
            else
                await bubble.SetMessage(msg, friendAvatarUrl);

            flowLayoutPanel1.Controls.Add(bubble);
            flowLayoutPanel1.ScrollControlIntoView(bubble);
        }

        private async void btnSendContent_Click(object sender, EventArgs e)
        {
            var content = txtContent.Text.Trim();
            if (string.IsNullOrEmpty(content)) return;

            var msg = new RealtimeMessageDto
            {
                Content = content,
                FromUsername = myUsername,
                ToUsername = currentFriendUsername,
                CreatedAt = DateTime.Now
            };

            await AddMessageToUI(msg.ToMessage(), scrollToBottom: true);

            txtContent.Clear();

            // 3. Gửi lên server (API hoặc WS)
            try
            {
                await SendMessageAsync(currentFriendId, content);
                await Seen(currentFriendId);
                await HandleChatUI(msg, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi tin nhắn thất bại: " + ex.Message);
            }
        }

        private async Task SendMessageAsync(long friendId, string content)
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

                var body = new
                {
                    friendId = friendId,
                    message = content
                };

                var response = await client.PostAsJsonAsync(
                    $"{baseUrl}api/message/chat/{friendId}",
                    body
                );

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Server error");
            }
        }

        private async Task HandleChatUI(RealtimeMessageDto rtMsg, bool fromOther)
        {
            bool existFriendInList = false;

            if (!isInChatTab) return;

            if (!fromOther) // mình gửi
            {
                foreach (ChatListControl c in flpListFriendChat.Controls)
                {
                    if (c.username == rtMsg.ToUsername)
                    {
                        c.SetSeen(false);
                        c.UpdateLastedMessageRealtime(rtMsg.Content);
                        flpListFriendChat.Controls.SetChildIndex(c, 0);
                        existFriendInList = true;
                        break;
                    }
                }
            }
            else // người khác gửi
            {
                foreach (ChatListControl c in flpListFriendChat.Controls)
                {
                    if (c.username == rtMsg.FromUsername)
                    {
                        if (rtMsg.FromUsername != currentFriendUsername) c.SetSeen(true);

                        c.UpdateLastedMessageRealtime(rtMsg.Content);
                        flpListFriendChat.Controls.SetChildIndex(c, 0);
                        existFriendInList = true;
                        break;
                    }
                }
            }

            if (!existFriendInList)
            {
                await GetAndDisplayConversation();
            }
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

        private async void btnFind_Click(object sender, EventArgs e) // nút Search user
        {
            List<User> users = new List<User>();
            flpUserSeachedList.Controls.Clear();

            string keyword = txtFindUser.Text.Trim();
            if (keyword == null || keyword == "") return;

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

                    var response = await client.GetAsync($@"{baseUrl}api/user/search?keyword={keyword}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    users = root["data"].ToObject<List<User>>();

                    if (users.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy người dùng nào.");
                        return;
                    }

                    for (int i = 0; i < users.Count; i++)
                    {
                        User user = users[i];

                        SearchedUsers item = new SearchedUsers();
                        item.BindData(user);

                        flpUserSeachedList.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task AcceptRequest(long friendId)
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
                        $"{baseUrl}api/friends/accept/{friendId}"
                    );

                    request.Content = null;

                    var response = await client.SendAsync(request);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    var message = root["message"].ToString();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi khi đồng ý kết bạn: " + message);
                    }

                    await GetAndDisplayFriends();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private async Task RejectRequest(long friendId)
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
                        $"{baseUrl}api/friends/reject/{friendId}"
                    );

                    request.Content = null;

                    var response = await client.SendAsync(request);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    var message = root["message"].ToString();

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi khi từ chối kết bạn: " + message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //
        // NOTIFICATIONS TAB
        //

        private async Task<List<Notification>> FetchNotifications()
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

                var response = await client.GetAsync($"{baseUrl}api/notifications");
                var responseJson = await response.Content.ReadAsStringAsync();

                var root = JObject.Parse(responseJson);
                var success = (bool)root["success"];
                var message = root["message"].ToString();

                if (!success)
                {
                    MessageBox.Show("Không thể load thông báo: " + message);
                }

                return root["data"].ToObject<List<Notification>>();
            }
        }

        private async void btnReloadNotification_Click(object sender, EventArgs e)
        {
            await LoadNotifications();
        }

        private async Task LoadNotifications()
        {
            flpNotificationView.Controls.Clear();

            try
            {
                var notifications = await FetchNotifications();

                if (notifications == null || notifications.Count == 0)
                {
                    btnDeleleAllNoti.Visible = false;
                    return;
                }

                foreach (var n in notifications)
                {
                    var item = new NotificationsControl();
                    item.SetNotificationData(n);

                    flpNotificationView.Controls.Add(item);
                    btnDeleleAllNoti.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load thông báo: " + ex.Message);
            }
        }

        private async Task HandleFriendNotificationAsync(Notification friendNotification)
        {
            if (friendNotification.message[0] == 's')
            {
                await DisplayFriendsWhoAreRequesting();
            }

            var item = new NotificationsControl();
            item.SetNotificationData(friendNotification);
            flpNotificationView.Controls.Add(item);
        }

        private async void btnDeleleAllNoti_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa tất cả thông báo?", "Xác nhận",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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

                        var response = await client.DeleteAsync($"{baseUrl}api/notifications");
                        var responseJson = await response.Content.ReadAsStringAsync();

                        var root = JObject.Parse(responseJson);
                        var success = (bool)root["success"];
                        var message = root["message"].ToString();

                        if (!success)
                        {
                            MessageBox.Show("Không thể xóa thông báo: " + message);
                        }

                        MessageBox.Show("Đã xóa tất cả thông báo");
                        await LoadNotifications();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                return;
            }

        }
        
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

                if (me.avatarURL != null) picAvatarSetting.LoadAsync(me.avatarURL);
                avatarUrlSetting = me.avatarURL;

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

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            btnChangeInfo.Enabled = false;
            btnCancelUpdateInfo.Visible = true;
            btnSaveUpdateInfo.Visible = true;
            btnSetavt.Visible = true;

            txtNewAvatarPath.Visible = true;

            txtDisplayname.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }

        private async void btnSaveUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    LoadToken(out string accessToken, out string refreshToken);
                    bool isValid = await VerifyToken(accessToken);

                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

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
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    // ====== Build multipart/form-data ======
                    using (var form = new MultipartFormDataContent())
                    {
                        // profile JSON string
                        var profileObj = new
                        {
                            username = txtUsername.Text.Trim(),
                            displayName = txtDisplayname.Text.Trim(),
                            email = txtEmail.Text.Trim()
                        };

                        string profileJson = Newtonsoft.Json.JsonConvert.SerializeObject(profileObj);

                        form.Add(
                            new StringContent(profileJson, Encoding.UTF8),
                            "profile"
                        );

                        // avatar (optional)
                        if (!string.IsNullOrEmpty(txtNewAvatarPath.Text) && File.Exists(txtNewAvatarPath.Text))
                        {
                            byte[] imageBytes = File.ReadAllBytes(txtNewAvatarPath.Text);
                            var fileContent = new ByteArrayContent(imageBytes);

                            fileContent.Headers.ContentType =
                                new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                            form.Add(
                                fileContent,
                                "avatar",
                                Path.GetFileName(txtNewAvatarPath.Text)
                            );
                        }

                        // ====== Call API ======
                        var response = await client.PutAsync(
                            @$"{baseUrl}api/user/update-profile",
                            form
                        );

                        var responseJson = await response.Content.ReadAsStringAsync();
                        var root = JObject.Parse(responseJson);

                        bool success = (bool)root["success"];
                        string message = root["message"]?.ToString();

                        if (!success)
                        {
                            MessageBox.Show(message);
                            return;
                        }

                        btnChangeInfo.Enabled = true;
                        btnCancelUpdateInfo.Visible = false;
                        btnSaveUpdateInfo.Visible = false;
                        btnSetavt.Visible = false;

                        txtNewAvatarPath.Visible = false;

                        txtDisplayname.ReadOnly = true;
                        txtEmail.ReadOnly = true;

                        MessageBox.Show("Cập nhật thông tin thành công.");

                        await DisplayUserInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnSetavt_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh đại diện";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = ofd.FileName;

                        txtNewAvatarPath.Text = selectedPath;

                        picAvatarSetting.Image = Image.FromFile(selectedPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: " + ex.Message + "\n\rVui lòng chọn đúng định dạng ảnh");
            }
        }

        private void btnCancelUpdateInfo_Click(object sender, EventArgs e)
        {
            btnChangeInfo.Enabled = true;
            btnCancelUpdateInfo.Visible = false;
            btnSaveUpdateInfo.Visible = false;
            btnSetavt.Visible = false;

            txtNewAvatarPath.Clear();
            txtNewAvatarPath.Visible = false;

            txtDisplayname.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtDisplayname.Text = displayNameSetting;
            txtEmail.Text = emailSetting;

            picAvatarSetting.Image = Properties.Resources.AvatarIcon;

            if (avatarUrlSetting != null) 
                picAvatarSetting.LoadAsync(avatarUrlSetting);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordUI().ShowDialog();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            new SendFeedbackUI().ShowDialog();
        }

        //
        // LINH TINH
        //

        User me;
        
        RealtimeService _realtime;

        private async void MainHomeUI_Load(object sender, EventArgs e)
        {
            try
            {
                await DisplayUserInfo();
                await LoadHomeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading main UI " + ex.Message);
            }

        }

        private async void MainHomeUI_Shown(object sender, EventArgs e)
        {
            LoadToken(out string accessToken, out string refreshToken);

            _realtime = new RealtimeService();

            _realtime.OnConnected += () =>
            {
                BeginInvoke(new Action(() =>
                {
                    rtxLog.AppendText("Connected to WebSocket server.\n");

                }));
            };

            _realtime.OnDisconnected += () =>
            {
                BeginInvoke(new Action(() =>
                {
                    rtxLog.AppendText("Disconnected from WebSocket server.\n");
                }));
            };

            _realtime.OnRawMessage += (msg) =>
            {
                BeginInvoke(new Action(() =>
                {
                    rtxLog.AppendText($"Received: {msg}\n");
                }));
            };

            _realtime.OnChatReceived += (rtMsg) =>
            {
                BeginInvoke(new Action(async () =>
                {
                    HandleRealtimeChat(rtMsg);
                    await HandleChatUI(rtMsg, true);
                }));
            };

            _realtime.OnFriendReceived += async (friendNotification) =>
            {
                BeginInvoke(new Action(async () =>
                {
                    await HandleFriendNotificationAsync(friendNotification);
                    new PopUpNotificationUI(friendNotification).Show();
                }));
            };

            _realtime.OnReactionReceived += (reactNoti) =>
            {
                BeginInvoke(new Action(() =>
                {
                    var item = new NotificationsControl();
                    item.SetNotificationData(reactNoti);

                    flpNotificationView.Controls.Add(item);
                    new PopUpNotificationUI(reactNoti).Show();
                }));
            };

            await _realtime.StartAsync(accessToken);
        }

        private async void btnExit_Click(object sender, EventArgs e)
        {
            await _realtime.StopAsync();
            Application.Exit();
        }

        private async void btnLogoutMain_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    LoadToken(out string accessToken, out string refreshToken);
                    bool isValid = await VerifyToken(accessToken);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", $"{accessToken}");

                        if (!isValid)
                        {
                            var refreshed = await Refresh();
                            if (!refreshed)
                            {
                                throw new Exception("Session expired. Please log in again.");
                            }

                            LoadToken(out string newAccess, out string _);

                            client.DefaultRequestHeaders.Authorization =
                                new AuthenticationHeaderValue("Bearer", newAccess);
                        }

                        var body = new
                        {
                            refreshToken = refreshToken
                        };

                        var content = new StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(body),
                            Encoding.UTF8,
                            "application/json"
                            );

                        var response = await client.PostAsync(@$"{baseUrl}api/user/logout", content);
                        var responseJson = await response.Content.ReadAsStringAsync();

                        var root = JObject.Parse(responseJson);

                        bool success = (bool)root["success"];
                        string message = root["message"].ToString();

                        if (!success)
                        {
                            MessageBox.Show($"Đăng xuất thất bại: {message}");
                            return;
                        }

                        MessageBox.Show("Đăng xuất thành công!");
                        await _realtime.StopAsync();
                        ClearToken();
                        this.Hide();
                        new LoginUI().Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                return;
            }
        }

        private async Task<Models.User> GetMyInfo()
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
                            throw new Exception("Session expired. Please log in again.");
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }

                    var response = await client.GetAsync(@$"{baseUrl}api/user/profile");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);
                    bool success = (bool)root["success"];
                    string message = root["message"].ToString();

                    if (!success)
                    {
                        throw new Exception("Không thể lấy thông tin người dùng.");
                    }

                    var user = root["data"].ToObject<Models.User>();

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private async Task DisplayUserInfo()
        {
            try
            {
                Models.User user = await GetMyInfo();

                if (user == null) return;

                me = user;

                lblUsername.Text = user.displayName;
                if (user.avatarURL != null)
                    pictureBox2.LoadAsync(user.avatarURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when displaying user info: " + ex.Message);
            }

        }

        private async void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pageIndex = tabMenu.SelectedIndex;
            isInChatTab = false;

            switch (pageIndex)
            {
                case 0: //Tab Home
                    LoadHomeData();
                    break;

                case 1: // Tab Chat
                    isInChatTab = true;
                    isSelfChat = false;

                    picAvatarTitleChat.Visible = false;
                    lblDisplayNameTitleChat.Visible = false;

                    txtContent.Visible = false;
                    btnSendContent.Visible = false;

                    flowLayoutPanel1.Visible = false;
                    await GetAndDisplayConversation();

                    flowLayoutPanel1.Controls.Clear();

                    break;

                case 2: // Tab Friends
                    await GetAndDisplayFriends();
                    await DisplayFriendsWhoAreRequesting();

                    break;

                case 3: // Tab Notifications
                    flpNotificationView.Controls.Clear();
                    btnDeleleAllNoti.Visible = false;
                    await LoadNotifications();
                    break;

                case 4: // Tab Setting
                    btnCancelUpdateInfo.Visible = false;
                    btnSaveUpdateInfo.Visible = false;
                    btnSetavt.Visible = false;

                    txtNewAvatarPath.Visible = false;
                    await DisplayUserInfoInSetting();

                    break;
            }
        }

        public static string ToTimeAgo(DateTimeOffset createdAtUtc)
        {
            var now = DateTimeOffset.UtcNow;
            var diff = now - createdAtUtc;

            if (diff.TotalSeconds < 60)
                return "Vừa xong";

            if (diff.TotalMinutes < 60)
                return $"{(int)diff.TotalMinutes} phút trước";

            if (diff.TotalHours < 24)
                return $"{(int)diff.TotalHours} giờ trước";

            if (diff.TotalDays < 7)
                return $"{(int)diff.TotalDays} ngày trước";

            return createdAtUtc.ToLocalTime().ToString("dd/MM/yyyy");
        }

        private async void MainHomeUI_Closing(object sender, FormClosingEventArgs e)
        {
            await _realtime.StopAsync();
            Application.Exit();
        }

    }
}
