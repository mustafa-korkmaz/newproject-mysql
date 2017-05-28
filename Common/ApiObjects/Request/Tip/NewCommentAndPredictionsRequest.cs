
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class NewCommentAndPredictionsRequest
    {
        [Required]
        public int EventId { get; set; }

        [StringLength(1000, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 10)]
        [Display(Name = "Maç Yorumu")]
        public string Content { get; set; }

        [Required(ErrorMessage = "En az 1 tahmin seçimi yapmalısınız.")]
        public IEnumerable<PredictionOdd> SelectedOddIds { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string LeaugeName { get; set; }
    }

    public class PredictionOdd
    {
        public int OddId { get; set; }
        public int Stake { get; set; }
    }

}

