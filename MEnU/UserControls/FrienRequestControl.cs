
namespace MEnU.UserControls
{
    public partial class FrienRequestControl : System.Windows.Forms.UserControl
    {
        public FrienRequestControl()
        {
            InitializeComponent();
        }

        public void BindData(string username, string avatarURL)
        {
            lblUsernameRequest.Text = username;

            if (avatarURL != null) picUserRequest.LoadAsync(avatarURL);
        }
    }
}
