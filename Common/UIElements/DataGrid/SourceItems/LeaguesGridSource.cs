using Common.Attrributes;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class LeaguesGridSource : DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "Id", Orderable = false)]
        public string Id { get; set; }

        [DataGridColumn(DisplayName = "Spor Kategori", Orderable = false)]
        public string SportCategoryName { get; set; }

        [DataGridColumn(DisplayName = "Kod", Orderable = false)]
        public string Code { get; set; }

        [DataGridColumn(DisplayName = "Lig Adı", Orderable = false)]
        public string Name { get; set; }
    }
}
