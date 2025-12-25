

namespace MEnU.Models
{
    public class Photo
    {
        public long photoId { get; set; }
        public DateTimeOffset createdAt { get; set; }
        public long ownerId { get; set; }
        public string ownerDisplayName { get; set; }
        public string ownerAvatarURL { get; set; }
        public string photoURL { get; set; }
        public string caption { get; set; }
    }
}
    //"photoId": "1",
    //"createdAt": "2025-12-21T00:13:26.928793",
    //"ownerId": 13,
    //"ownerDisplayName": "DanhTest11",
    //"ownerAvatarURL": null,
    //"caption": "Bức ảnh đầu tiên",
    //"photoURL": "https://res.cloudinary.com/dxnfzumzp/image/upload/v1766250806/avatars/hebg6wqq5luwalbc9gbz.png"