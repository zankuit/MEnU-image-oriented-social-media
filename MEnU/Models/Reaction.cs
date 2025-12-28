

namespace MEnU.Models
{
    public class Reaction
    {
        public long userId { get; set; }
        public long photoId { get; set; }
        public List<string> emoji { get; set; }
    }
}
