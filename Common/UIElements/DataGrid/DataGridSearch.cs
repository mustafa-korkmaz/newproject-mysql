using Common.Enumerations;

namespace Common.UIElements
{
    public class DataGridSearch
    {
        public string Label { get; set; }
        public DataSearchType SearchType { get; set; }
        public object DataSource { get; set; }
    }
}
