using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MEnU.Forms
{
    public partial class UploadPhotoUI : Form
    {
        string baseUrl = @"https://unvulgarly-unfueled-mozella.ngrok-free.dev/";

        public UploadPhotoUI()
        {
            InitializeComponent();
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

        string selectedImagePath;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;

                    // Load ảnh lên PictureBox
                    picPhoto.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private async void btnSendReactChat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Chưa chọn ảnh");
                return;
            }

            string caption = txtReactChat.Text;

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
                        }

                        LoadToken(out string newAccess, out string _);

                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", newAccess);
                    }
                    
                    using (MultipartFormDataContent form = new MultipartFormDataContent())
                    {
                        form.Add(new StringContent(caption), "caption");

                        byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                        ByteArrayContent imageContent = new ByteArrayContent(imageBytes);

                        imageContent.Headers.ContentType =
                            new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                        form.Add(imageContent, "image", Path.GetFileName(selectedImagePath));
                        
                        var response = await client.PostAsync($@"{baseUrl}api/photos", form);
                        var responseJson = await response.Content.ReadAsStringAsync();

                        var root = JObject.Parse(responseJson);
                        bool success = (bool)root["success"];
                        string message = root["message"].ToString();

                        if (!success)
                        {
                            MessageBox.Show($"Không thể đăng ảnh: " + message);
                            return;
                        }

                        MessageBox.Show($"Đăng ảnh thành công!");
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: " + ex.Message);
            }
        }
    }
}
