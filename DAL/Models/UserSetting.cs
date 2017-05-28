using System;
using System.ComponentModel.DataAnnotations;
using Common.Enumerations;

namespace DAL.Models
{
    public class UserSetting : EntityBase
    {
        public string UserId { get; set; }  // foreign key 
        public virtual ApplicationUser User { get; set; } // navigation 

        [Required]
        public UserSettingKey Key { get; set; }

        [Required]
        [MaxLength(10)]
        public string Value { get; set; }
    }
}
