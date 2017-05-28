using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Common.Enumerations;

namespace Common.Helper
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ToText(this Enum myEnum)
        {
            return myEnum.ToString("G");
        }

        public static string JoinToString(this List<string> items, string delimeter)
        {
            return String.Join(delimeter, items.ToArray());
        }

        public static string ToCamelCase(this string value)
        {
            //
            // Uppercase only the first letter in the string when  this extension is called on.
            //
            value = value.ToLower();
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        public static void SetTableCaptions(this DataTable dt, List<string> captionList)
        {
            for (int i = 0; i < captionList.Count; i++)
            {
                dt.Columns[i].Caption = captionList[i];
            }
        }

        public static void SetTableCaptions(this DataTable dt, int columnIndex, string caption)
        {
            dt.Columns[columnIndex].Caption = caption;
        }

        public static string ToBetBloggerDateFormat(this DateTime d)
        {
            return d.ToString("dd.MM.yyyy");
        }

        public static string ToBetBloggerDateTimeFormat(this DateTime d)
        {
            return d.ToString("dd.MM.yyyy HH:mm");
        }

        public static string ToBetBloggerDateTimeInSecondsFormat(this DateTime d)
        {
            return d.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public static DateTime ToBetBloggerDateFormat(this string s)
        {
            return s == null ? DateTime.Today : DateTime.ParseExact(s, "dd.MM.yyyy", null);
        }

        public static DateTime ToBetBloggerDateTimeFormat(this string s)
        {
            return s == null ? DateTime.Today : DateTime.ParseExact(s, "dd.MM.yyyy HH:mm", null);
        }

        public static DateTime ToBetBloggerDateCriteriaFormat(this string s)
        {
            return s == null ? DateTime.Today : DateTime.ParseExact(s, "yyyyMMdd", null);
        }

        public static string ToBetBloggerDateCriteriaFormat(this DateTime d)
        {
            return d.ToString("yyyyMMdd");
        }

        public static string ToBetBloggerMoneyFormat(this decimal val)
        {
            return $"{val:#,0.00}"; // "1.234.256,58"
        }

        public static string ToBetBloggerCounterFormat(this decimal val)
        {
            return $"{val:#,0}"; // "1.234.256"
        }

        public static string ToBetBloggerHandicapFormat(this decimal val)
        {
            return $"{val:#,0.0}"; // "1.234.256,5"
        }

        public static decimal ToBetBloggerDecimalFormat(this string val)
        {
            //"6,032.51";
            CultureInfo provider = new CultureInfo("en-GB");
            return decimal.Parse(val, provider);
        }

        public static string ToDocumentName(this string name)
        {
            name = name.ToLower();
            name = name.Replace("ı", "i");
            name = name.Replace("ö", "o");
            name = name.Replace("ü", "u");
            name = name.Replace("ç", "c");
            name = name.Replace("ş", "s");
            name = name.Replace("ğ", "g");

            string retValue = string.Empty;
            string id_long_name = name.Trim();
            string[] id_array = id_long_name.Split(' ');
            int length = id_array.Length;
            for (int i = 0; i < length; i++)
            {
                retValue += id_array[i];
                if (i < length - 1)
                    retValue += "_";
            }
            return retValue;
        }


        public static string SetDataFormat(this string value, ColumnDataFormat format)
        {
            string retValue = string.Empty;
            if (format != ColumnDataFormat.Default)
            {
                switch (format)
                {
                    case ColumnDataFormat.Date:
                        if (string.IsNullOrEmpty(value))
                            return "";
                        retValue = DateTime.Parse(value).ToBetBloggerDateFormat();
                        break;
                    case ColumnDataFormat.Money:
                        value = string.IsNullOrEmpty(value) ? "0" : value;
                        retValue = Decimal.Parse(value).ToBetBloggerMoneyFormat();
                        break;
                    default:
                        break;
                }
            }
            else
                retValue = value;

            return retValue;
        }
    }
}