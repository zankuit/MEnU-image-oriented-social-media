

namespace MEnU.Models
{
    public class ConversationPreview
    {
        public long friendId { get; set; }
        public string? username { get; set; }
        public string? displayName { get; set; }
        public string? avatarURL { get; set; }
        public string? lastMessage { get; set; }
        public string? lastMessageTime { get; set; }
        public bool hasUnread { get; set; }

    }
}
