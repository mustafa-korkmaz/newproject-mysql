using System.Collections;
using System.Collections.Generic;
using Common.Enumerations;

namespace Common.UIElements
{
    public class DataGridColumn
    {
        private string _fieldName;// non editable property name of a class

        public bool Visible { get; set; }
        public bool Orderable { get; set; }
        public DataGridSearch DataGridSearch { get; set; }
        public bool UseInSummary { get; set; } // for getting column summary totals
        public bool ShowInDataExport { get; set; } //may be we want to export data for a hidden column
        public string DisplayName { get; set; } // column display name
        public int ColumnIndex { get; internal set; }
        public int DisplayIndex { get; set; }
        public ColumnDataFormat DataFormat { get; set; }
        public ColumnDataType DataType { get; set; }
        /// <summary>
        /// DataGrid object which DataGridColumn belongs to.
        /// </summary>
        public DataGrid.DataGrid DataGrid { get; internal set; }
        public string FieldName { get { return _fieldName; } }


        private DataGridColumn(string fieldName, ColumnDataFormat dataFormat, ColumnDataType dataType)
        {
            _fieldName = fieldName;
            DisplayName = fieldName; // fieldName== displayName by default
            DataFormat = dataFormat;
            DataType = dataType;
            UseInSummary = false;
            Visible = true;
            ShowInDataExport = true;
            Orderable = false;
        }

        private DataGridColumn(int columnIndex, string fieldName, string displayName, ColumnDataFormat dataFormat, ColumnDataType dataType)
        {
            _fieldName = fieldName;

            ColumnIndex = columnIndex;
            DisplayName = displayName;
            DataFormat = dataFormat;
            DataType = dataType;
            UseInSummary = false;
            Visible = true;
            ShowInDataExport = true;
            Orderable = false;
        }

        public static DataGridColumn Create(string fieldName, ColumnDataFormat dataFormat = ColumnDataFormat.Default, ColumnDataType dataType = ColumnDataType.Text)
        {
            return new DataGridColumn(fieldName, dataFormat, dataType);
        }
        public static DataGridColumn Create(int columnIndex, string fieldName, string displayName, ColumnDataFormat dataFormat = ColumnDataFormat.Default, ColumnDataType dataType = ColumnDataType.Text)
        {
            return new DataGridColumn(columnIndex, fieldName, displayName, dataFormat, dataType);
        }
    }

    public class DataGridColumnCollection : IEnumerable<DataGridColumn>
    {
        private DataGrid.DataGrid _dataGrid;
        private List<DataGridColumn> _columns;
        public DataGridColumn this[int index]
        {
            get { return _columns[index]; }
        }
        public DataGridColumn this[string fieldName]
        {
            get { return _columns.Find(c => c.FieldName == fieldName); }
        }
        public DataGridColumnCollection(DataGrid.DataGrid dataGrid)
        {
            _dataGrid = dataGrid;
            _columns = new List<DataGridColumn>();
        }

        public void Add(DataGridColumn column)
        {
            this._columns.Add(column);
            column.DataGrid = this._dataGrid;
        }
        public bool Remove(DataGridColumn column)
        {
            return _columns.Remove(column);
        }
        public void RemoveAt(int columnIndex)
        {
            _columns.RemoveAt(columnIndex);
        }
        IEnumerator<DataGridColumn> IEnumerable<DataGridColumn>.GetEnumerator()
        {
            return _columns.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _columns.GetEnumerator();
        }
    }
}