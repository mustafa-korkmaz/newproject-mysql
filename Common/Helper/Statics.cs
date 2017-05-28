using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Drawing;
//using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Web;
using Common.Attrributes;
using Common.Enumerations;
using Common.UIElements;

namespace Common.Helper
{
    public static class Statics
    {

        #region set breadcrumbs
        //prjojeye eklenen ekranların breadcrumb  linklerini oluşturmak için o ekranların bağlantılarını aşağıdaki listeye eklemeliyiz.
        public static List<Breadcrumb> Breadcrumbs => new List<Breadcrumb>
        {
            new Breadcrumb {Id=0,ParentId=0,ControllerName="Home",ActionName="index",ViewTitle="Anasayfa", BackButtonText=""},
            new Breadcrumb {Id=2,ParentId=0,ControllerName="Author",ActionName="index",ViewTitle="Yazar Bilgileri", BackButtonText=""},
            new Breadcrumb {Id=4,ParentId=0,ControllerName="",ActionName="",ViewTitle="Yazar Tahmin Listesi", BackButtonText=""},
            new Breadcrumb {Id=7,ParentId=4,ControllerName="Event",ActionName="Tipped",ViewTitle="", BackButtonText=""},
            new Breadcrumb {Id=5,ParentId=0,ControllerName="Tip",ActionName="index",ViewTitle="Tahmin Bilgileri", BackButtonText=""},
            new Breadcrumb {Id=6,ParentId=0,ControllerName="Coin",ActionName="index",ViewTitle="Coin Para Bilgileri", BackButtonText=""},
            new Breadcrumb {Id=8,ParentId=0,ControllerName="BetProgram",ActionName="index",ViewTitle="Güncel Bülten Bilgileri", BackButtonText=""},
            new Breadcrumb {Id=23,ParentId=0,ControllerName="",ActionName="",ViewTitle="Karşılaşmalar", BackButtonText=""},
            new Breadcrumb {Id=24,ParentId=0,ControllerName="Event",ActionName="index",ViewTitle="Maç Listesi", BackButtonText=""},
            new Breadcrumb {Id=25,ParentId=0,ControllerName="Tip",ActionName="MyPredictions",ViewTitle="Tahminlerim", BackButtonText=""},
            new Breadcrumb {Id=26,ParentId=0,ControllerName="Tip",ActionName="MyComments",ViewTitle="Yorumlarım", BackButtonText=""},
            new Breadcrumb {Id=27,ParentId=0,ControllerName="Tip",ActionName="NewPrediction",ViewTitle="Yeni Tahmin Girişi", BackButtonText=""},
            new Breadcrumb {Id=28,ParentId=0,ControllerName="Tip",ActionName="NewComment",ViewTitle="Yeni Yorum Girişi", BackButtonText=""},
            new Breadcrumb {Id=29,ParentId=0,ControllerName="Tip",ActionName="EventPredictions",ViewTitle="Maç Tahmin Listesi", BackButtonText=""},
            new Breadcrumb {Id=30,ParentId=0,ControllerName="Report",ActionName="RequestBox",ViewTitle="Dilek - Şikayet Kutusu", BackButtonText=""},
            new Breadcrumb {Id=31,ParentId=0,ControllerName="Report",ActionName="Exception",ViewTitle="Sistem Hataları", BackButtonText=""},
            new Breadcrumb {Id=32,ParentId=0,ControllerName="Report",ActionName="UserList",ViewTitle="Kullanıcılar", BackButtonText=""},
            new Breadcrumb {Id=33,ParentId=0,ControllerName="Report",ActionName="Log",ViewTitle="Sistem Logları", BackButtonText=""},
            new Breadcrumb {Id=34,ParentId=0,ControllerName="",ActionName="",ViewTitle="Araçlar", BackButtonText=""},
            new Breadcrumb {Id=35,ParentId=0,ControllerName="Common",ActionName="Leagues",ViewTitle="Lig Yönetimi", BackButtonText=""},
            new Breadcrumb {Id=36,ParentId=0,ControllerName="Common",ActionName="Cache",ViewTitle="Cache Yönetimi", BackButtonText=""},
            new Breadcrumb {Id=36,ParentId=0,ControllerName="Common",ActionName="Notifications",ViewTitle="Bildirimler", BackButtonText=""},
            new Breadcrumb {Id=2,ParentId=0,ControllerName="Coupon",ActionName="index",ViewTitle="Kupon Bilgileri", BackButtonText=""}
        };

        #endregion set breadcrumbs

        public static string GetApiUrl()
        {
            AppSettingsReader configurationAppSettings = new AppSettingsReader();
            return (string)configurationAppSettings.GetValue(ConfigKeys.ApiUrl, typeof(string));
        }

        /// <summary>
        /// return from web.config [key] value
        /// </summary>
        /// <param name="key">config app key</param>
        /// <returns></returns>
        public static string GetConfigKey(string key)
        {
            AppSettingsReader configurationAppSettings = new AppSettingsReader();
            return (string)configurationAppSettings.GetValue(key, typeof(string));
        }

        public static string GetStatusText(Status status)
        {
            switch (status)
            {
                case Status.Active:
                    return "Aktif";
                case Status.Passive:
                    return "Pasif";
                case Status.Suspended:
                    return "Donduruldu";
                case Status.Deleted:
                    return "Silindi";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static string GetApprovalText(bool isApproved)
        {
            return isApproved ? "Onaylı" : "Onay Bekliyor";
        }

        public static DateTime GetTurkeyCurrentDateTime()
        {
            DateTime utcTime = DateTime.UtcNow;
            //TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi); // convert from utc to local
        }

        public static string GetPredictionResultText(PredictionResult result)
        {
            switch (result)
            {
                case PredictionResult.Pending:
                    return "Beklemede";
                case PredictionResult.Won:
                    return "Kazandı";
                case PredictionResult.Lost:
                    return "Kaybetti";
                case PredictionResult.Canceled:
                    return "İptal edildi";
                default:
                    throw new ArgumentOutOfRangeException(nameof(result), result, null);
            }
        }

        public static string GetCouponTypeText(CouponType couponType)
        {
            switch (couponType)
            {
                case CouponType.None:
                    return "";
                case CouponType.Guarantee:
                    return "Banko Kupon";
                case CouponType.Surprise:
                    return "Sürpriz Kupon";
                case CouponType.Cash:
                    return "Kasa Kuponu";
                case CouponType.BtIddaaTeam:
                    return "Btiddaa Özel Kuponu";
                case CouponType.BestTiptersTeam:
                    return "Bestipters Özel Kuponu";
                case CouponType.Weekend:
                    return "Hafta sonu Kuponu";
                case CouponType.Weekdays:
                    return "Hafta içi kuponu";
                case CouponType.MobileUser:
                    return "Kullanıcı Kuponu";
                default:
                    throw new ArgumentOutOfRangeException(nameof(couponType), couponType, null);
            }
        }

        //public static BusinessResponse<string> SaveImage(string imageData, string filePath)
        //{
        //    var businessResp = new BusinessResponse<string>
        //    {
        //        ResponseCode = ResponseCode.Fail,
        //    };

        //    Regex regex = new Regex(@"base64,(.*)");
        //    Match match = regex.Match(imageData);

        //    if (!match.Success)
        //    {
        //        return businessResp;
        //    }

        //    string imageDataBase64String = match.Value.Substring(7); // trim 'base64,'

        //    regex = new Regex(@"data[:-]image(.*);"); //data-image/png;

        //    match = regex.Match(imageData);

        //    if (!match.Success)
        //    {
        //        return businessResp;
        //    }

        //    string fileExtension = "." + match.Value.Substring(11).Replace(";", ""); // trim 'data-image/' returns: .png

        //    var guid = Guid.NewGuid().ToString();

        //    string fullPath = filePath + guid + fileExtension;

        //    var sourceBytes = Convert.FromBase64String(imageDataBase64String);

        //    var targetBytes = CropImage(sourceBytes, 144, 144);

        //    using (var imageFile = new FileStream(fullPath, FileMode.Create))
        //    {
        //        imageFile.Write(targetBytes, 0, targetBytes.Length);
        //        imageFile.Flush();
        //    }

        //    businessResp.ResponseData = guid + fileExtension; // return file name.
        //    businessResp.ResponseCode = ResponseCode.Success;
        //    return businessResp;
        //}

        //public static byte[] CropImage(byte[] imageStream, int width, int height, bool needToFill = false)
        //{
        //    Image image;

        //    using (var ms = new MemoryStream(imageStream))
        //    {
        //        image = Image.FromStream(ms);
        //    }

        //    int sourceWidth = image.Width;
        //    int sourceHeight = image.Height;

        //    int sourceX = 0;
        //    int sourceY = 0;
        //    double destX = 0;
        //    double destY = 0;

        //    double nScale = 0;
        //    double nScaleW = 0;
        //    double nScaleH = 0;

        //    nScaleW = (width / (double)sourceWidth);
        //    nScaleH = (height / (double)sourceHeight);
        //    if (!needToFill)
        //    {
        //        nScale = Math.Min(nScaleH, nScaleW);
        //    }
        //    else
        //    {
        //        nScale = Math.Max(nScaleH, nScaleW);
        //        destY = (height - sourceHeight * nScale) / 2;
        //        destX = (width - sourceWidth * nScale) / 2;
        //    }

        //    if (nScale > 1)
        //        nScale = 1;

        //    int destWidth = (int)Math.Round(sourceWidth * nScale);
        //    int destHeight = (int)Math.Round(sourceHeight * nScale);

        //    Bitmap bmPhoto = null;
        //    try
        //    {
        //        bool sizesAvailable = true;

        //        if (destWidth < width)
        //        {
        //            destWidth = width;
        //            sizesAvailable = false;
        //        }

        //        if (destHeight < height)
        //        {
        //            destHeight = height;
        //            sizesAvailable = false;
        //        }

        //        if (sizesAvailable)
        //        {
        //            bmPhoto = new Bitmap(destWidth + (int)Math.Round(2 * destX), destHeight + (int)Math.Round(2 * destY));
        //        }
        //        else
        //        {
        //            bmPhoto = new Bitmap(destWidth, destHeight);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException(string.Format("destWidth:{0}, destX:{1}, destHeight:{2}, desxtY:{3}, Width:{4}, Height:{5}", destWidth, destX, destHeight, destY, width, height), ex);
        //    }
        //    using (Graphics grPhoto = Graphics.FromImage(bmPhoto))
        //    {
        //        grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        grPhoto.CompositingQuality = CompositingQuality.HighQuality;
        //        grPhoto.SmoothingMode = SmoothingMode.HighQuality;

        //        Rectangle to = new Rectangle((int)Math.Round(destX), (int)Math.Round(destY), destWidth, destHeight);
        //        Rectangle from = new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight);
        //        //Console.WriteLine("From: " + from.ToString());
        //        //Console.WriteLine("To: " + to.ToString());
        //        grPhoto.DrawImage(image, to, from, GraphicsUnit.Pixel);
        //    }

        //    using (var ms = new MemoryStream())
        //    {
        //        bmPhoto.Save(ms, image.RawFormat);
        //        return ms.ToArray();
        //    }
        //}

        public static string GetMobileCategoryImageUrl(int categoryId)
        {
            switch (categoryId)
            {
                case DatabaseKey.FootballCategoryId:
                    return $"{GetApiUrl()}{ImagePath.Category}football-mobile.png";
                case DatabaseKey.BasketballCategoryId:
                    return $"{GetApiUrl()}{ImagePath.Category}basketball-mobile.png";
                case DatabaseKey.VolleyballCategoryId:
                    return $"{GetApiUrl()}{ImagePath.Category}volleyball-mobile.png";
                case DatabaseKey.HandballCategoryId:
                    return $"{GetApiUrl()}{ImagePath.Category}handball-mobile.png";
                case DatabaseKey.TennisCategoryId:
                    return $"{GetApiUrl()}{ImagePath.Category}tennis-mobile.png";
            }

            return "";
        }

        /// <summary>
        /// formats list element's property value as html.Dom element like anchor, button, image, etc.
        /// </summary>
        /// <typeparam name="T">list element type</typeparam>
        /// <param name="unformarttedList">list to format</param>
        /// <returns></returns>
        public static IEnumerable<T> FormatDataHtml<T>(IList<T> unformarttedList)
        {
            foreach (var item in unformarttedList)
            {
                foreach (PropertyInfo pi in unformarttedList.GetType().GetGenericArguments()[0].GetProperties())
                {
                    var customAttributes = pi.GetCustomAttributes(true);
                    var dataColumnAttribute = (customAttributes.Any() ? customAttributes[0] : null) as DataGridColumnAttribute;

                    if (dataColumnAttribute != null && pi.GetValue(item) != null)
                    {
                        var columnDataType = dataColumnAttribute.DataType; // default= text

                        switch (columnDataType)
                        {
                            case ColumnDataType.LinkButton:

                                //get actual property value
                                var propertyValue = pi.GetValue(item).ToString();

                                var linkButton = new LinkButton(propertyValue);
                                linkButton.ActionName = dataColumnAttribute.ActionName ?? "none";
                                linkButton.ControllerName = dataColumnAttribute.ControllerName ?? "none";

                                var value = dataColumnAttribute.Value ?? string.Empty;

                                if (string.IsNullOrEmpty(value))
                                {
                                    var valueColumnName = dataColumnAttribute.ValueColumnName ?? string.Empty;

                                    if (!string.IsNullOrEmpty(valueColumnName))
                                    {
                                        // get link button value from linkButton value column name
                                        PropertyInfo linkButtonColumnPropertyInfo = typeof(T).GetProperty(valueColumnName);
                                        linkButton.Value = linkButtonColumnPropertyInfo.GetValue(item, null).ToString();
                                    }
                                    else
                                    {
                                        // now set column value an html anchor string with string.empty properties
                                        linkButton.Value = "none";
                                    }
                                }
                                else
                                {
                                    linkButton.Value = value;
                                }
                                pi.SetValue(item, linkButton.GetHtml(), null);

                                break;
                            case ColumnDataType.ImageButton:
                                break;
                        }
                        var o = pi.GetValue(item);
                    }
                }
            }
            return unformarttedList;
        }

        /// <summary>
        /// returns client ip
        /// </summary>
        /// <returns></returns>
        public static string GetIp()
        {
            string ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            return ip;
        }
    }
}