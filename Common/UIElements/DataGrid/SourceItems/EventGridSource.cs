using Common.Attrributes;
using Common.Enumerations;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class EventGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Bülten Kodu", Orderable = false)]
        public string BetProgramCode { get; set; }

        [DataGridColumn(DisplayName = "Maç", Orderable = false)]
        public string EventName { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string StartDateTime { get; set; }

        [DataGridColumn(DisplayName = "Lig Kodu", Orderable = false)]
        public string LeagueShortCode { get; set; }

        [DataGridColumn(DisplayName = "Kategori", Orderable = false)]
        public string CategoryName { get; set; }

        //[DataGridColumn(DisplayName = "Bahis Ekle", Orderable = false, DataType = ColumnDataType.LinkButton, ValueColumnName = "DT_RowId")]
        //public string AddOdds { get; set; }
    }

    public class EventAuthorGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Yazar", Orderable = false)]
        public string Username { get; set; }

        [DataGridColumn(DisplayName = "Ad Soyad", Orderable = false)]
        public string NameSurname { get; set; }

        [DataGridColumn(DisplayName = "Tahmin Sayısı", Orderable = false)]
        public int PredictionsTotal { get; set; }

        [DataGridColumn(DisplayName = "Yorum Sayısı", Orderable = false)]
        public int CommentsTotal { get; set; }

    }
}
