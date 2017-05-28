using Common.Enumerations;

namespace DTO
{
    public class UserDevice
    {
        public int Id { get; set; }

        public string UserId { get; set; }  // foreign key 
        public virtual ApplicationUser User { get; set; } // navigation 

        public DeviceType Type { get; set; }

        public string Key { get; set; } // RegistrationId for GCM, DeviceToken for APNs
    }
}
