
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Common
{
    public class AddLeagueRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "Geçerli bir spor kategorisi seçiniz.")]
        public int SportCategoryId { get; set; }

        [StringLength(4, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Kod")]
        public string Code { get; set; }

        [StringLength(50, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Lig Adı")]
        public string Name { get; set; }
    }

    public class EditLeagueRequest : AddLeagueRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int LeagueId { get; set; }
    }

}