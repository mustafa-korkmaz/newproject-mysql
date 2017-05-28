using System.Collections.Generic;
using System.Linq;
using Common;
using Common.Enumerations;

namespace DTO
{
    public class ApplicationUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string NameSurname { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        //public decimal CoinsTotal { get; set; }

        //public string ImageName { get; set; }

        public bool ContactPermission { get; set; }

        //public string ImageUrl
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(ImageName))
        //        {
        //            return Statics.GetApiUrl() + ImagePath.User + ImageName;
        //        }
        //        return null;
        //    }
        //}

        //public DateTime CreatedAt { get; set; }

        public Status Status { get; set; }   // author status

        public IList<string> Roles { get; set; }

        public Dictionary<string, string> Claims { get; set; }

        public bool IsAdmin
        {
            get
            {
                if (Roles == null)
                {
                    return false;
                }
                return Roles.Any(r => r == ApplicationRole.Admin);
            }
        }

        public virtual ICollection<UserDevice> UserDevices { get; set; } // 1=>n relationship with dbo.UserDevices
    }
}
