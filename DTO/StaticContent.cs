using System;

namespace DTO
{
    public class StaticContent : DtoBase
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
