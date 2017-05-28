using System;

namespace DTO
{
    public class SporComplexException
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
