using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEnU.Forms
{
    public partial class ForgetUI : Form
    {
        public ForgetUI()
        {
            InitializeComponent();
        }

        private async void btnSendForget_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text.Trim();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new
                    {
                        email = email
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await client.PostAsync(@"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/forgot-password", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    var success = (bool)root["success"];

                    var message = root["message"]?.ToString();

                    var accessToken = root["data"]?["accessToken"]?.ToString();

                    var refreshToken = root["data"]?["refreshToken"]?.ToString();

                    if (!success)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {message}", "Lỗi");
                        return;
                    }

                    MessageBox.Show($"Kiểm tra inbox email của bạn", "Thông báo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errors: {ex.Message}", "Lỗi");
            }
        }

        private void btnLoginForget_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginUI().Show();
        }
    }
}
