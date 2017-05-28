
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class EventTipsRequest
    {
        [Required]
        [Display(Name = "Event Id")]
        public int EventId { get; set; }

        [Required]
        [Display(Name = "Author Id")]
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
    }
}

