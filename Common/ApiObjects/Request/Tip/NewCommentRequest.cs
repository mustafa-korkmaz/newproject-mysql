
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class NewCommentRequest
    {
        [Required]
        [Display(Name = "Maç Id")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [StringLength(1000, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 10)]
        [Display(Name = "Maç Yorumu")]
        public string Content { get; set; }
    }

    public class EditCommentRequest
    {
        [Required]
        [Display(Name = "Comment Id")]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [StringLength(1000, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 10)]
        [Display(Name = "Maç Yorumu")]
        public string Content { get; set; }
    }
}

