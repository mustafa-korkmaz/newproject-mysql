using Common.Attrributes;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class BetProgramGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Id", Orderable = false)]
        public string Id { get; set; }

        [DataGridColumn(DisplayName = "Başlangıç", Orderable = false)]
        public string StartDate { get; set; }

        [DataGridColumn(DisplayName = "Bitiş", Orderable = false)]
        public string EndDate { get; set; }

        [DataGridColumn(DisplayName = "Son Güncelleme", Orderable = false)]
        public string LastModifiedDate { get; set; }
    }

}
