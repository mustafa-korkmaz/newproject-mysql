using System;
using Common.Enumerations;

namespace Common.Attrributes
{
    /// <summary>
    /// custom attribute for DataGridModel's DataGrid
    /// </summary>
    public class DataGridAttribute : Attribute
    {
        private string _idColumnName;
        private string _id;
        private string _name;
        private bool _rowsCheckable;
        private bool _rowsEditable;
        private string _editText;
        private bool _rowsDeletable;
        private string _deleteText;
        private bool _showFooter;
        private DataLoadType _edittingRowDataLoadType;

        public DataGridAttribute()
        {
            _showFooter = false; // do not show table footer by default
            _rowsCheckable = false; // do not show checkbox columns by default
            _rowsEditable = true; // show edit button by default
            _rowsDeletable = true; // show delete button by default
            _editText = "Düzenle"; //edit column default text 
            _deleteText = "Sil";//delete column default text 
            _edittingRowDataLoadType = DataLoadType.AsPage; // default row data editing event type: AsPage (redirects a new page)
        }

        public virtual string IdColumnName
        {
            get { return _idColumnName; }
            set { _idColumnName = value; }
        }

        public virtual string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual bool RowsCheckable
        {
            get { return _rowsCheckable; }
            set { _rowsCheckable = value; }
        }

        public virtual bool RowsEditable
        {
            get { return _rowsEditable; }
            set { _rowsEditable = value; }
        }

        public virtual string EditText
        {
            get { return _editText; }
            set { _editText = value; }
        }

        public virtual bool RowsDeletable
        {
            get { return _rowsDeletable; }
            set { _rowsDeletable = value; }
        }

        public virtual string DeleteText
        {
            get { return _deleteText; }
            set { _deleteText = value; }
        }

        public virtual bool ShowFooter
        {
            get { return _showFooter; }
            set { _showFooter = value; }
        }

        //public virtual bool ShowSearchSection
        //{
        //    get { return _showSearchSection; }
        //    set { _showSearchSection = value; }
        //}

        //public virtual string DataSearchText
        //{
        //    get { return _dataSearchText; }
        //    set { _dataSearchText = value; }
        //}

        public virtual DataLoadType EdittingRowDataLoadType
        {
            get { return _edittingRowDataLoadType; }
            set { _edittingRowDataLoadType = value; }
        }

    }
}
