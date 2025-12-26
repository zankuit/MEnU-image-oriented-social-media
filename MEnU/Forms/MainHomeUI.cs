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



        //
        // FRIENDS TAB
        //



        //
        // NOTIFICATIONS TAB
        //



        //
        // SETTINGS TAB
        //



        //
        // LINH TINH
        //



    }
}
