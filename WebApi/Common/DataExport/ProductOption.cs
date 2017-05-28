using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common.DataExport
{
    public class ProductOption
    {
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
    }
}