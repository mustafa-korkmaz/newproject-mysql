using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class RequestLog : EntityBase
    {
        [MaxLength(16)]
        [Required]
        public string Ip { get; set; }

        [MaxLength(50)]
        [Required]
        public string Uri { get; set; }

        [MaxLength(500)]
        public string RequestContent { get; set; }

        [Required]
        public int HttpResponseCode { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
