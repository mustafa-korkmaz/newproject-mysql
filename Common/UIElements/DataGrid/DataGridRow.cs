using System.Collections;
using System.Collections.Generic;

namespace Common.UIElements.DataGrid
{
    public class DataGridRow
    {
        public string IdColumnName;
        public DataGridCell this[string columnName]
        {
            get
            {
                return this.CellArray.Find(c => c.Column.FieldName == columnName);
            }
        }
        public string Id // HTML Dom element id attribute
        {
            get
            {
                return this.CellArray.Find(c => c.Column.FieldName == this.IdColumnName).Value.ToString();
            }
        }
        public bool IsVisible { get; set; }
        public string Name { get; set; } // HTML Dom element name attribute
        public List<DataGridCell> CellArray { get; private set; } // System.Data.DataTable.Rows.ItemArray logic
        public UIElements.DataGrid.DataGrid DataGrid { get; internal set; }

        private DataGridRow()
        {
            this.IsVisible = true;
            this.CellArray = new List<DataGridCell>();
            this.IdColumnName = "Id"; // id column name is "Id" by default
        }

        public static DataGridRow Create()
        {
            return new DataGridRow();
        }
    }

    public class DataGridRowCollection : IEnumerable<DataGridRow>
    {
        private UIElements.DataGrid.DataGrid _dataGrid;
        private List<DataGridRow> _rows;
        public DataGridRow this[int index]
        {
            get { return _rows[index]; }
        }

        public DataGridRowCollection(UIElements.DataGrid.DataGrid dataGrid)
        {
            _dataGrid = dataGrid;
            _rows = new List<DataGridRow>();
        }

        public void Add(DataGridRow row)
        {
            _rows.Add(row);
            row.DataGrid = this._dataGrid;
        }
        public bool Remove(DataGridRow row)
        {
            return _rows.Remove(row);
        }
        public void RemoveAt(int columnIndex)
        {
            _rows.RemoveAt(columnIndex);
        }
        IEnumerator<DataGridRow> IEnumerable<DataGridRow>.GetEnumerator()
        {
            return _rows.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _rows.GetEnumerator();
        }
    }

}