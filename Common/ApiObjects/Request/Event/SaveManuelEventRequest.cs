
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common.Helper;

namespace Common.ApiObjects.Request.Event
{
    public class NewEventRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int BetProgramId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int LeagueId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Geçerli bir spor kategorisi seçiniz.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "En az 1 bahis girişi yapmalısınız.")]
        public IEnumerable<Odd> SelectedOdds { get; set; }

        [StringLength(4, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Bülten Kodu")]
        public string BetProgramCode { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Maç Tarih")]
        public string StartDateText { get; set; }

        [StringLength(50, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Ev Sahibi Takım")]
        public string HomeTeamName { get; set; }

        [StringLength(50, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Deplasman Takım")]
        public string AwayTeamName { get; set; }

        [Range(1, 23, ErrorMessage = "Saat, {1} ve {2} aralığında olmalıdır. ")]
        public int EventHour { get; set; }

        [Range(0, 59, ErrorMessage = "Dakika, {1} ve {2} aralığında olmalıdır. ")]
        public int EventMin { get; set; }

        public decimal Limit { get; set; }
        public decimal HalfHomeHandicap { get; set; }
        public decimal HalfAwayHandicap { get; set; }
        public decimal FinalHomeHandicap { get; set; }
        public decimal FinalAwayHandicap { get; set; }

        public DateTime EventDateTime
        {
            get
            {
                string eventHourText = EventHour.ToString();
                string eventMinText = EventMin.ToString();

                if (EventHour < 10)
                {
                    eventHourText = string.Format("0{0}", EventHour);
                }

                if (EventMin < 10)
                {
                    eventMinText = string.Format("0{0}", EventMin);
                }


                var date = string.Format("{0} {1}:{2}", StartDateText, eventHourText, eventMinText);
                return date.ToBetBloggerDateTimeFormat();
            }
        }
    }

    public class EditEventRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int EventId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int LeagueId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Geçerli bir spor kategorisi seçiniz.")]
        public int CategoryId { get; set; }

        [StringLength(4, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Bülten Kodu")]
        public string BetProgramCode { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Maç Tarih")]
        public string StartDateText { get; set; }

        [StringLength(50, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Ev Sahibi Takım")]
        public string HomeTeamName { get; set; }

        [StringLength(50, ErrorMessage = "{0} alanı max {1} karakter olmalıdır.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Deplasman Takım")]
        public string AwayTeamName { get; set; }

        [Required(ErrorMessage = "En az 1 bahis girişi yapmalısınız.")]
        public IEnumerable<Odd> SelectedOdds { get; set; }

        [Range(1, 23, ErrorMessage = "Saat, {1} ve {2} aralığında olmalıdır. ")]
        public int EventHour { get; set; }

        [Range(0, 59, ErrorMessage = "Dakika, {1} ve {2} aralığında olmalıdır. ")]
        public int EventMin { get; set; }

        public DateTime EventDateTime
        {
            get
            {
                string eventHourText = EventHour.ToString();
                string eventMinText = EventMin.ToString();

                if (EventHour < 10)
                {
                    eventHourText = string.Format("0{0}", EventHour);
                }

                if (EventMin < 10)
                {
                    eventMinText = string.Format("0{0}", EventMin);
                }


                var date = string.Format("{0} {1}:{2}", StartDateText, eventHourText, eventMinText);
                return date.ToBetBloggerDateTimeFormat();
            }
        }

        public decimal Limit { get; set; }
        public decimal HalfHomeHandicap { get; set; }
        public decimal HalfAwayHandicap { get; set; }
        public decimal FinalHomeHandicap { get; set; }
        public decimal FinalAwayHandicap { get; set; }
    }

    public class Odd
    {
        public int EventId { get; set; }
        public int OddsTypeId { get; set; }
        public int Mbs { get; set; }
        public decimal Value { get; set; }
    }

}