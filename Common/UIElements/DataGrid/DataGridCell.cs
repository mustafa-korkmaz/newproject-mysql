using Common.Helper;
using Common.UIElements.DataGrid;

namespace Common.UIElements
{
    public class DataGridCell
    {
        /// <summary>
        /// DataGridColumn object which DataGridItem belongs
        /// </summary>
        public DataGridColumn Column { get; set; }
        /// <summary>
        /// DataGridRow object which DataGridItem belongs
        /// </summary>
        public DataGridRow Row { get; set; }

        /// <summary>
        /// DataGridCell item value
        /// </summary>
        public object Value { get; set; }
        public DataGridCell()
        {

        }

        public override string ToString()
        {
            return Value.ToString().SetDataFormat(this.Column.DataFormat);
        }
    }
}