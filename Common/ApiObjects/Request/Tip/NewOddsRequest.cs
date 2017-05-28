
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class NewOddsRequest
    {
        [Required]
        [Display(Name = "Maç Id")]
        public int EventId { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Bahis Tipi")]
        public int OddsTypeId { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public byte Mbs { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Oran")]
        public decimal Value { get; set; }

    }
}

