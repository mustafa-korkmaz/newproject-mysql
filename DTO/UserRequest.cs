using System;
using Common.Enumerations;

namespace DTO
{
    public class UserRequest
    {
        public int Id { get; set; }

        public string UserId { get; set; }  // foreign key 
        public virtual ApplicationUser User { get; set; } // navigation 

        public string Message { get; set; } // user request message

        public RequestType Type { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
