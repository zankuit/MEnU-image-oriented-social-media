

namespace MEnU.Models
{
    public class RealtimeMessageDto
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public string FromUsername { get; set; }
        public string ToUsername { get; set; }
        public DateTime CreatedAt { get; set; }
        public Messsage ToMessage()
        {
            return new Messsage
            {
                id = Id,
                content = Content,
                fromUsername = FromUsername,
                createdAt = CreatedAt
            };
        }
    }
}
