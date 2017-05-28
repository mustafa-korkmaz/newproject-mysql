using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common
{
    public class ExportTypeText
    {
        public const string Category = "category";
        public const string Product = "product";
    }

    public class SettingKey
    {
        public const string ImagePath = "imagePath";
        public const string FullPath = "{fullPath}";
        public const string Extension = "{extension}";
    }
}