using System.Collections;
using Common.ApiObjects.Request;

namespace Common.ApiObjects.Response
{
    /// <summary>
    /// response class for dataTables.js 
    /// </summary>
    public class DataGridResponse
    {
        public DataGridResponse(DataGridRequest queryString)
        {
            _queryString = queryString;
        }

        private DataGridRequest _queryString;

        public int draw
        {
            get
            {
                return _queryString.draw;
            }
        }

        public IEnumerable data { get; set; } //generated data for our dataGrid

        public int recordsTotal
        {
            get
            {
                return _queryString.recordsTotal;
            }
        }

        public int recordsFiltered
        {
            get
            {
                return recordsTotal;
            }
        }
    }
}
