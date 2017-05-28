
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Tip
{
    public class PredictionResultRequest
    {
        [Required]
        public int EventId { get; set; }

        [Required]
        public int PredictionId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int Result { get; set; }

        [Range(0, 100, ErrorMessage = "İY Ev sahibi skoru geçerli değil.")]
        public int HalfHomeScore { get; set; }

        [Range(0, 100, ErrorMessage = "İY Deplasman skoru geçerli değil.")]
        public int HalfAwayScore { get; set; }

        [Range(0, 200, ErrorMessage = "MS Ev sahibi skoru geçerli değil.")]
        public int FinalHomeScore { get; set; }

        [Range(0, 200, ErrorMessage = "MS Deplasman skoru geçerli değil.")]
        public int FinalAwayScore { get; set; }

        public bool UpdateByScore { get; set; }

        private string _eventStartDateTime;

        [Required]
        public string EventStartDateTime
        {
            get
            {
                return _eventStartDateTime;
            }
            set
            {
                _eventStartDateTime = value.Replace('-', ':');
            }
        }
    }

}

