using Common.Enumerations;

namespace Common.UIElements
{
    public class PCColumn
    {
        private string columnName;
        private string displayName;
        private int columnIndex;
        private ColumnDataFormat format { get; set; }

        public string ColumnName { get { return this.columnName; } }
        public string DisplayName { get { return this.displayName; } }
        public int ColumnIndex { get { return this.columnIndex; } set { this.columnIndex = value; } }
        public ColumnDataFormat Format { get { return this.format; } }

        private PCColumn(string columnName, string displayName, ColumnDataFormat format)
        {
            this.columnName = columnName;
            this.displayName = displayName;
            this.format = format;
        }

        private PCColumn(int columnIndex, string columnName, string displayName, ColumnDataFormat format)
        {
            this.columnIndex = columnIndex;
            this.columnName = columnName;
            this.displayName = displayName;
            this.format = format;
        }

        public void SetFormat(ColumnDataFormat format)
        {
            this.format = format;
        }

        public static PCColumn Create(string columnName, string displayName, ColumnDataFormat format = ColumnDataFormat.Default)
        {
            return new PCColumn(columnName, displayName, format);
        }
        public static PCColumn Create(int columnIndex, string columnName, string displayName, ColumnDataFormat format = ColumnDataFormat.Default)
        {
            return new PCColumn(columnIndex, columnName, displayName, format);
        }

    }
}
