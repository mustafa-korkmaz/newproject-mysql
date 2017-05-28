using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.User
{
    public class ResetPasswordRequest
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} alanı en az {2} karakter olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifreyi doğrula")]
        [Compare("NewPassword", ErrorMessage = "Girilen şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

        public string Token { get; set; }

        public string UserId { get; set; }
    }
}
