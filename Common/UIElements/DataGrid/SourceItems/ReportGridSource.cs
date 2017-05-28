using Common.Attrributes;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class RequestBoxGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Kullanıcı", Orderable = false)]
        public string Username { get; set; }

        [DataGridColumn(DisplayName = "Email", Orderable = false)]
        public string Email { get; set; }

        [DataGridColumn(DisplayName = "Tip", Orderable = false)]
        public string RequestType { get; set; }

        [DataGridColumn(DisplayName = "Mesaj", Orderable = false)]
        public string Message { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string CreatedAt { get; set; }
    }

    public class ExceptionGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string CreatedAt { get; set; }

        [DataGridColumn(DisplayName = "Exception Message", Orderable = false)]
        public string ExceptionMessage { get; set; }

        private string _stackTrace;
        [DataGridColumn(DisplayName = "Stack Trace", Orderable = false)]
        public string StackTrace
        {
            /*
              <span class="read-more-wrap">Lorem ipsum dolor sit amet, consectetur adipisicing elit. 
              <span class="read-more-target">Libero fuga facilis vel consectetur quos sapiente deleniti eveniet dolores tempore eos deserunt officia quis ab? 
              Excepturi vero tempore minus beatae voluptatem!</span></span>
             */
            get { return _stackTrace; }
            set
            {
                var length = value.Length;
                if (length <= 200)
                {
                    _stackTrace = value;
                }
                else //add read more option
                {
                    var str1 = value.Substring(0, 200);
                    var str2 = value.Substring(200, value.Length - 200);
                    _stackTrace = string.Format("<input type=\"checkbox\" class=\"read-more-state\" id=\"post-{0}\"><span class=\"read-more-wrap\">{1}<span class=\"read-more-target\">{2}</span></span><label for=\"post-{0}\" class=\"read-more-trigger\"></label>", DT_RowId, str1, str2);
                }
            }
        }
    }

    public class UserGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Kullanıcı", Orderable = false)]
        public string UserName { get; set; }

        [DataGridColumn(DisplayName = "Ad Soyad", Orderable = false)]
        public string NameSurname { get; set; }

        [DataGridColumn(DisplayName = "Email", Orderable = false)]
        public string Email { get; set; }

        [DataGridColumn(DisplayName = "Onaylandı", Orderable = false)]
        public string EmailConfirmed { get; set; }

        [DataGridColumn(DisplayName = "Üyelik Tarihi", Orderable = false)]
        public string MemberSince { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }
    }

    public class LogGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "IP", Orderable = false)]
        public string Ip { get; set; }

        [DataGridColumn(DisplayName = "Url", Orderable = false)]
        public string Url { get; set; }

        [DataGridColumn(DisplayName = "Request", Orderable = false)]
        public string Request { get; set; }

        [DataGridColumn(DisplayName = "Response", Orderable = false)]
        public string ResponseCode { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string CreatedAt { get; set; }
    }
}
