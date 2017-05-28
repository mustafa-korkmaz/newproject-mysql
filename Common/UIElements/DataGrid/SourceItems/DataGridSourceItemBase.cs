using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enumerations;
using Common.Attrributes;

namespace Common.UIElements.DataGrid.SourceItems
{
    public class DataGridSourceItemBase
    {
        [DataGridColumn(DisplayName = "DT_RowId", Visible = false)]
        public string DT_RowId { get; set; }
    }

}
