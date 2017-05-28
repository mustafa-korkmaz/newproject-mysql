using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common.DataExport
{
    public class ProductAttribute
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public string AtrributeName { get; set; }
        public string AttributeValue { get; set; }
    }
}