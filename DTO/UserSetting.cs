using Common.Enumerations;

namespace DTO
{
    public class UserSetting
    {
        public int Id { get; set; }

        public string UserId { get; set; }  // foreign key 
        public virtual ApplicationUser User { get; set; } // navigation 

        public UserSettingKey Key { get; set; }

        public string Value { get; set; }
    }
}
