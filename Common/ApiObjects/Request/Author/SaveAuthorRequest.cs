
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Author
{
    public class NewAuthorRequest
    {
        [RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "{0}  alanına sadece alfa numerik ve alt çizgi karakteri girebilirisiniz.")]
        [StringLength(15, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 4)]
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        public string NameSurname { get; set; }

        public string Email { get; set; }

        [StringLength(25, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Desc { get; set; }

        [StringLength(15, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Display(Name = "Twitter Kullanıcı Adı")]
        public string TwitterUserName { get; set; }

        public string ImageData { get; set; }
    }

    public class EditAuthorRequest
    {
        public string UserId { get; set; }

        public int AuthorId { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "{0}  alanına sadece alfa numerik ve alt çizgi karakteri girebilirisiniz.")]
        [StringLength(15, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 4)]
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        public string NameSurname { get; set; }

        public int Status { get; set; }

        public string Email { get; set; }

        public string Desc { get; set; }

        [StringLength(15, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Display(Name = "Twitter Kullanıcı Adı")]
        public string TwitterUserName { get; set; }

        public string ImageData { get; set; }

        public string PhoneNumber { get; set; }
    }

}

