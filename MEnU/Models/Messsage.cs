

namespace MEnU.Models
{
    public class Messsage
    {
        public long id { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string fromUsername { get; set; }
        public string toUsername { get; set; }
        public int? photoId { get; set; }
        public DateTime createdAt { get; set; }
        public bool seen { get; set; }
    }
}