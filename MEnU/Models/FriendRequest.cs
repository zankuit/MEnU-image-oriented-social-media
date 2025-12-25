using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MEnU.Models
{
    public class FriendRequest
    {
        public long id { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }
        public string avatarURL { get; set; }
    }
}
