using System;
using Common.Enumerations;

namespace Common.Attrributes
{
    /// <summary>
    /// custom attribute for DataGridModel's DataGridColumn
    /// </summary>
    public class DataGridColumnAttribute : Attribute
    {
        private bool _visible;
        private bool _orderable;
        //private bool searchable;
        //private string searchLabel;
        private string _displayName;
        private string _localizedDisplayName;
        private bool _useInSummary;
        private ColumnDataFormat _dataFormat;
        private ColumnDataType _dataType;
        //  private DataGridSearch dataGridSearch;
        private string _controllerName;
        private string _actionName;
        private string _valueColumnName;
        private string _value;


        public DataGridColumnAttribute(string displayName)
        {
            _visible = true;
            _orderable = false;
            _displayName = displayName;
            _dataFormat = ColumnDataFormat.Default;
            _dataType = ColumnDataType.Text;
            _useInSummary = false;
        }

        public DataGridColumnAttribute()
        {
            _visible = true;
            _dataFormat = ColumnDataFormat.Default;
            _dataType = ColumnDataType.Text;
        }

        public virtual bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        public virtual bool Orderable
        {
            get { return _orderable; }
            set { _orderable = value; }
        }

        public virtual bool UseInSummary
        {
            get { return _useInSummary; }
            set { _useInSummary = value; }
        }

        public virtual string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public virtual string LocalizedDisplayName
        {
            get { return GetLocalizedDisplayName(); }
            set { _localizedDisplayName = value; }
        }

        public virtual ColumnDataFormat DataFormat
        {
            get { return _dataFormat; }
            set { _dataFormat = value; }
        }

        public virtual ColumnDataType DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        public virtual string ControllerName
        {
            get
            {
                return _controllerName;
            }
            set
            {
                _controllerName = value;
            }
        }

        public virtual string ActionName
        {
            get
            {
                return _actionName;
            }
            set
            {
                _actionName = value;
            }
        }
        public virtual string ValueColumnName
        {
            get { return _valueColumnName; }
            set { _valueColumnName = value; }
        }

        public virtual string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private string GetLocalizedDisplayName()
        {
            if (_localizedDisplayName == null)
            {
                return null;
            }
            //ResourceSet resourceSet = Resource.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            //return resourceSet.GetString(_localizedDisplayName);
            return "";
        }
    }
}