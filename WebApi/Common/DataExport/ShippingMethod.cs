using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common.DataExport
{
    public class ProductShippingMethod
    {
        public int FirmId { get; set; }
        public string FirmName { get; set; }
        public decimal Cost { get; set; }
    }
}