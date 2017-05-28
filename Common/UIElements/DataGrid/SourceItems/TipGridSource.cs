using Common.Attrributes;
using Common.Enumerations;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class CurrentUserPredictionGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Bülten Kodu", Orderable = false)]
        public string BetProgramCode { get; set; }

        [DataGridColumn(DisplayName = "Maç", Orderable = false)]
        public string EventName { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string StartDateTime { get; set; }

        [DataGridColumn(DisplayName = "Tahmin", Orderable = false)]
        public string Prediction { get; set; }

        [DataGridColumn(DisplayName = "Stake", Orderable = false)]
        public string Stake { get; set; }

        [DataGridColumn(Visible = false)]
        public string PredictionResult { get; set; }

        [DataGridColumn(DisplayName = "Statü", Orderable = false, DataType = ColumnDataType.LinkButton, ValueColumnName = "PredictionId")]
        public string PredictionResultText { get; set; }

        [DataGridColumn(Visible = false)]
        public string AuthorId { get; set; }

        [DataGridColumn(Visible = false)]
        public string PredictionId { get; set; }

        [DataGridColumn(Visible = false)]
        public string TipId { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }
    }

    public class CurrentUserCommentGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Bülten Kodu", Orderable = false)]
        public string BetProgramCode { get; set; }

        [DataGridColumn(DisplayName = "Maç", Orderable = false)]
        public string EventName { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string StartDateTime { get; set; }

        [DataGridColumn(DisplayName = "Yorum", Orderable = false)]
        public string Comment { get; set; }

        [DataGridColumn(Visible = false)]
        public string AuthorId { get; set; }

        [DataGridColumn(Visible = false)]
        public string TipId { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }

        [DataGridColumn(Visible = false)]
        public string CommentId { get; set; }
    }

    public class CurrentBetProgramEventGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Bülten Kodu", Orderable = false, Visible = false)]
        public string BetProgramCode { get; set; }

        [DataGridColumn(DisplayName = "Maç", Orderable = false)]
        public string EventName { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string StartDateTime { get; set; }

        [DataGridColumn(DisplayName = "Lig Kodu", Orderable = false)]
        public string LeagueShortCode { get; set; }

        [DataGridColumn(DisplayName = "Kategori", Orderable = false, Visible = false)]
        public string CategoryName { get; set; }

        [DataGridColumn(DisplayName = "Kategori", Orderable = false, Visible = false)]
        public string CategoryId { get; set; }

        [DataGridColumn(Visible = false)]
        public string CategoryUrl { get; set; }

        [DataGridColumn(Visible = false)]
        public string LeagueName { get; set; }
    }

    public class AuthorEventPredictionsGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Yazar", Orderable = false)]
        public string AuthorUserName { get; set; }

        [DataGridColumn(DisplayName = "Bülten Kodu", Orderable = false)]
        public string BetProgramCode { get; set; }

        [DataGridColumn(DisplayName = "Maç", Orderable = false)]
        public string EventName { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Visible = false)]
        public string StartDateTime { get; set; }

        [DataGridColumn(DisplayName = "Tahmin", Orderable = false)]
        public string Prediction { get; set; }

        [DataGridColumn(DisplayName = "Stake", Orderable = false)]
        public string Stake { get; set; }

        [DataGridColumn(Visible = false)]
        public string PredictionResult { get; set; }

        [DataGridColumn(DisplayName = "Kazandı", Orderable = false)]
        public string QuickActionWon { get; set; }

        [DataGridColumn(DisplayName = "Kaybetti", Orderable = false)]
        public string QuickActionLost { get; set; }

        [DataGridColumn(DisplayName = "Statü", Orderable = false, DataType = ColumnDataType.LinkButton, ValueColumnName = "PredictionId")]
        public string PredictionResultText { get; set; }

        [DataGridColumn(Visible = false)]
        public string AuthorId { get; set; }

        [DataGridColumn(Visible = false)]
        public string PredictionId { get; set; }

        [DataGridColumn(Visible = false)]
        public string TipId { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }
    }

    public class OddsGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(LocalizedDisplayName = "OddsTypeId", Orderable = true, Visible = false)]
        public string OddsTypeId { get; set; }

        [DataGridColumn(DisplayName = "Tahmin", Orderable = false)]
        public string OddsName { get; set; }

        [DataGridColumn(DisplayName = "Stake", Orderable = false)]
        public string StakeOptions { get; set; }

        [DataGridColumn(DisplayName = "Oran", Orderable = false)]
        public string OddsValue { get; set; }

        [DataGridColumn(DisplayName = "Bahis Tipi", Orderable = false, Visible = false)]
        public string BetTypeName { get; set; }

        [DataGridColumn(DisplayName = "MBS", Orderable = false, Visible = false)]
        public string Mbs { get; set; }
    }

    public class OddsTypeGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(LocalizedDisplayName = "OddsTypeId", Orderable = true, Visible = false)]
        public string OddsTypeId { get; set; }

        [DataGridColumn(DisplayName = "Bahis Tipi", Orderable = false)]
        public string BetTypeName { get; set; }

        [DataGridColumn(DisplayName = "MBS", Orderable = false)]
        public string Mbs { get; set; }

        [DataGridColumn(DisplayName = "Oran", Orderable = false)]
        public string OddsValue { get; set; }

    }
}
