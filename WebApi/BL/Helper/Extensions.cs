using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WebApi.BL.Helper
{
    public static class Extensions
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var xmlserializer = new XmlSerializer(typeof(T));

            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8);

            xmlserializer.Serialize(streamWriter, value);

            var xml= Encoding.UTF8.GetString(memoryStream.ToArray());

            return xml;
        }
    }
}
