using Common.Attrributes;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class AuthorGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Yazar", Orderable = false)]
        public string UserName { get; set; }

        [DataGridColumn(DisplayName = "Ad Soyad", Orderable = false)]
        public string NameSurname { get; set; }

        [DataGridColumn(DisplayName = "Toplam Tahmin", Orderable = false)]
        public string PredictionsTotal { get; set; }

        [DataGridColumn(DisplayName = "Toplam Yorum", Visible = false)]
        public string CommentsTotal { get; set; }

        [DataGridColumn(DisplayName = "Statü", Orderable = false)]
        public string StatusText { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }
    }

}
