using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Common.Attrributes;

namespace Common.UIElements.DataGrid
{
    public class DataGrid
    {
        #region Properties
        //private properties
        private string _idColumnName;

        /// <summary>
        /// if you are using server side processing, you do not need source data in model binding process.  Only define your source class. eg. new List<Customer>()
        /// </summary>
        private IEnumerable source;
        // public properties
        public string Id { get; set; }
        public string Name { get; set; } // grid table name
        public string IdColunmName
        {
            private get
            {
                return this._idColumnName;
            }
            set
            {
                this._idColumnName = value;
                foreach (var row in this.Rows)
                {
                    row.IdColumnName = value;
                }
            }
        }
        public IEnumerable DataSource { get; private set; }
        public DataGridColumnCollection Columns { get; private set; }
        public DataGridRowCollection Rows { get; private set; }
        public List<DataGridColumn> DataSearchColumnList
        {
            get
            {
                return this.Columns.Where(c => c.DataGridSearch != null).ToList();
            }
        }
        public bool IsRowsCheckable { get; set; }
        public bool IsRowsEditable { get; set; }
        public bool IsRowsDeletable { get; set; }
        public string EditText { get; set; }
        public string DeleteText { get; set; }

        public string ActionColumnText
        {
            get
            {
                if (!string.IsNullOrEmpty(DeleteText))
                {
                    if (!string.IsNullOrEmpty(EditText))
                    {
                        return EditText;
                    }
                }

                return EditText;
            }
        }
       
        public bool ShowFooter { get; set; }
        public bool ShowSearchSection { get; set; }
        public bool IsVisible { get; set; }

        /// <summary>
        /// table session list key (used for excel exporting)
        /// </summary>
        public string SessionSourceKey { get; set; }

        #endregion Properties

        #region Constructor
        public DataGrid(IEnumerable source, string gridTableName)
        {
            this.Name = gridTableName;
            this.IsVisible = true; // visible=true by default
            this.ShowFooter = false; // do not show table footer by default
            this.ShowSearchSection = false;// do not show search section by default
            this.IsRowsCheckable = false; // do not show checkbox columns by default
            this.IsRowsEditable = true; // show edit button by default
            this.IsRowsDeletable = true; // show delete button by default
            this.EditText = "Düzenle"; //edit column default text 
            this.DeleteText = "Sil";//delete column default text 
               this.source = source;
            this.DataSource = source;// source and datatable are the same object by default
            this.SetDataGridColumnCollection();
            this.SetDataGridRowCollection();
        }
        #endregion Constructor

        private void SetDataGridColumnCollection()
        {
            //reflection sample
            //Dictionary<string, string> myDict = new Dictionary<string, string>();
            //myDict[pi.Name] = pi.GetValue(item, null).ToString();
            //List<string> propertyList = source.GetType().GetProperties().Select(prop => prop.Name).ToList();

            DataGridColumn c;
            this.Columns = new DataGridColumnCollection(this);

            int index = 0;
            foreach (PropertyInfo pi in source.GetType().GetGenericArguments()[0].GetProperties())
            {
                c = DataGridColumn.Create(pi.Name);
                var customAttributes = pi.GetCustomAttributes(true);
                var dataColumnAttribute = (customAttributes.Any() ? customAttributes[0] : null) as DataGridColumnAttribute;
                if (dataColumnAttribute != null)
                {
                    c.DisplayName = dataColumnAttribute.LocalizedDisplayName ?? dataColumnAttribute.DisplayName; // if there is a localized name, override displayName property
                    c.DataFormat = dataColumnAttribute.DataFormat;
                    c.DataType = dataColumnAttribute.DataType;
                    c.Visible = dataColumnAttribute.Visible;
                    c.Orderable = dataColumnAttribute.Orderable;
                    c.UseInSummary = dataColumnAttribute.UseInSummary;
                }
                c.ColumnIndex = c.DisplayIndex = index++;
                this.Columns.Add(c);
            }
        }

        private void SetDataGridRowCollection()
        {
            var obj = this.source;
            this.Rows = new DataGridRowCollection(this);
            DataGridCell cell;
            DataGridRow row;

            foreach (var item in obj)
            {
                row = DataGridRow.Create();

                foreach (PropertyInfo pi in item.GetType().GetProperties())
                {
                    cell = new DataGridCell();
                    cell.Row = row;
                    cell.Column = this.Columns[pi.Name];
                    cell.Value = pi.GetValue(item, null);
                    row.CellArray.Add(cell);
                }
                this.Rows.Add(row);
            }
        }
    }
}
