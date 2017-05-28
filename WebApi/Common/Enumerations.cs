using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common
{
    public class Enumerations
    {
    }

    public enum IntegrationType
    {
        Opencart=0,
        Magento,
        NopCommerce
    }

    public enum ExportType
    {
        Undefined = -1,
        Product=0,
        Category=1
    }

    public enum IntegrationStatus
    {
        Initial = 0,
        Active,
        Passive,
        Suspended,
        Deleted
    }

    public enum ResponseCode
    {
        Fail = 0,
        Success,
        Warning,
        Info,
        NoEffect
    }
}