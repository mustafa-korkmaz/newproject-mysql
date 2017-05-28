
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class DeleteTipRequest
    {
        [Required]
        [Display(Name = "Tip Id")]
        public int TipId { get; set; }

        [Required]
        [Display(Name = "User Id")]
        public string UserId { get; set; }
    }
}

