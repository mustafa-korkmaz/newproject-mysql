using System;

namespace DTO
{
    public class RequestLog
    {
        public int Id { get; set; }

        public string Ip { get; set; }

        public string Uri { get; set; }

        public string RequestContent { get; set; }

        public int HttpResponseCode { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
