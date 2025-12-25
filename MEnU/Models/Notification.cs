using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnU.Models
{
    public class Notification
    {
        public long id {  get; set; }
        public string type {  get; set; }
        public string message { get; set; }
        public string fromUsername { get; set; }
        public string toUsername { get; set; }
        public long photoId { get; set; }
        public bool seen {  get; set; }
        public DateTimeOffset createdAt {  get; set; }

    }
}

//      "id": 16,
//      "type": null,
//      "message": "sent you a friend request",
//      "fromUsername": "zankutest2",
//      "toUsername": "zankuit",
//      "photoId": null,
//      "seen": false,
//      "createdAt": "2025-12-23T23:54:04.607405"