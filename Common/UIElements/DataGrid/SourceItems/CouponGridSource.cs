using Common.Attrributes;
using Common.Enumerations;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class CouponGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Kupon Adı", Orderable = false)]
        public string Name { get; set; }

        [DataGridColumn(DisplayName = "Oluşturan", Orderable = false)]
        public string UserName { get; set; }

        [DataGridColumn(Visible = false)]
        public string UserId { get; set; }

        [DataGridColumn(DisplayName = "Kupon Tipi", Orderable = false)]
        public string TypeText { get; set; }

        [DataGridColumn(Visible = false)]
        public string Type { get; set; }

        [DataGridColumn(DisplayName = "Tahmin Sayısı", Orderable = false)]
        public string PredictionsTotal { get; set; }

        [DataGridColumn(DisplayName = "Toplam Oran", Orderable = false)]
        public string ValuesTotal { get; set; }

        [DataGridColumn(DisplayName = "Tarih", Orderable = false)]
        public string CreatedAt { get; set; }

        [DataGridColumn(DisplayName = "Statü", Orderable = false)]
        public string ApprovalText { get; set; }

        [DataGridColumn(Visible = false)]
        public bool Approved { get; set; }
    }

}
