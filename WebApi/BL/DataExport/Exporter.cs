using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WebApi.BL.DataExport
{
    public interface IDataExportable
    {
        string ExportData();
    }
}