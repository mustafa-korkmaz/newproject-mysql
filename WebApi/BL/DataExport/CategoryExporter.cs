using WebApi.Common.DataExport;
using System.Collections.Generic;
using WebApi.BL.Helper;

namespace WebApi.BL.DataExport
{
    public class CategoryExporter : IDataExportable
    {
        private List<Category> _categories { get; set; }

        public CategoryExporter(List<Category> categories)
        {
            _categories = categories;
        }

        public string ExportData()
        {
            return _categories.Serialize();
        }
    }
}