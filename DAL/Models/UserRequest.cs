using System;
using System.ComponentModel.DataAnnotations;
using Common.Enumerations;

namespace DAL.Models
{
    public class UserRequest : EntityBase
    {
        public string UserId { get; set; }  // foreign key 
        public virtual ApplicationUser User { get; set; } // navigation 

        [Required]
        [MaxLength(250)]
        public string Message { get; set; } // user request message

        [Required]
        public RequestType Type { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
