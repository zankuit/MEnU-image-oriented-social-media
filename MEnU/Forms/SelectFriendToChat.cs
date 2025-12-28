using MEnU.Models;
using MEnU.UserControls;

namespace MEnU.Forms
{
    public partial class SelectFriendToChatUI : Form
    {
        List<MEnU.Models.User> _friends;
        public event Action<User> FriendSelected;

        public SelectFriendToChatUI(List<MEnU.Models.User> friends)
        {
            InitializeComponent();
            lblNoFriend.Visible = false;
            _friends = friends;
        }

        private void SelectFriendToChatUI_Load(object sender, EventArgs e)
        {
            if (_friends.Count == 0 || _friends == null)
            {
                lblNoFriend.Visible = true;
                return;
            }

            for (int i = 0; i < _friends.Count; i++)
            {
                User friend = _friends[i];

                FriendControl item = new FriendControl();
                item.BindData(friend);

                item.ChatClicked += (f) =>
                {
                    FriendSelected?.Invoke(f);
                    this.Close();
                };

                flpFriendList.Controls.Add(item);
            }
        }
    }
}
