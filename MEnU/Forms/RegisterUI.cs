using Newtonsoft.Json.Linq;
using System.Text;

namespace MEnU.Forms
{
    public partial class RegisterUI : Form
    {
        public RegisterUI()
        {
            InitializeComponent();
        }

        private async void btnSignupSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsernameSignup.Text.Trim();
            string displayName = txtDisplaynameSignup.Text.Trim();
            string email = txtEmailSignup.Text.Trim();
            string password = txtPasswordSignup.Text;
            string confirmedPassword = txtConfirmpasswordSignup.Text;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new
                    {
                        username = username,
                        displayName = displayName,
                        email = email,
                        password = password,
                        confirmPassword = confirmedPassword
                    };

                    var content = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(body),
                        Encoding.UTF8,
                        "application/json"
                        );

                    var response = await client.PostAsync(@"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/register", content);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    var root = JObject.Parse(responseJson);

                    bool success = (bool)root["success"];
                    var message = root["message"].ToString();

                    if (success)
                    {
                        MessageBox.Show($"{message}", "Thông báo");
                        this.Hide();
                        new LoginUI().Show();
                    }
                    else
                    {
                        MessageBox.Show($"{message}", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLoginSignnup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginUI().Show();
        }
    }
}
