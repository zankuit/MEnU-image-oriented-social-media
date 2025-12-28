using MEnU.Models;

namespace MEnU.UserControls
{
    public partial class ReactListControl : System.Windows.Forms.UserControl
    {
        public ReactListControl()
        {
            InitializeComponent();
            flpReactions.Controls.Clear();
        }

        public void BindData(Reaction reaction, string userReactDisplayName, string userReactAvatarUrl)
        {
            if (userReactAvatarUrl != null && userReactAvatarUrl != "")
                picAvtarReact.LoadAsync(userReactAvatarUrl);

            lblNameReact.Text = userReactDisplayName;

            foreach (var r in reaction.emoji)
            {
                switch (r)
                {
                    case "heart":
                        flpReactions.Controls.Add(picHeart);
                        break;

                    case "haha":
                        flpReactions.Controls.Add(picHaha);
                        break;
                    
                    case "hug":
                        flpReactions.Controls.Add(picHug);
                        break;
                    
                    case "sad":
                        flpReactions.Controls.Add(picSad);
                        break;
                }
            }
        }
    }
}
