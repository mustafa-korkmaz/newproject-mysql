using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class SporComplexException : EntityBase
    {
        [MaxLength(150)]
        [Required]
        public string Message { get; set; }

        [Required]
        public string StackTrace { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
