namespace Common
{
    public class ExportTypeText
    {
        public const string Category = "category";
        public const string Product = "product";
    }

    public static class SporComplex
    {
        public const int ApiTokenValidDays = 30;
        public const string ApiKeyValue = "T.E.A.M"; // taylan.erdi.aliko.mute
        public static string ApiKeyHash = Helper.ApiKey.Instance.GetHashValue(ApiKeyValue);
        public const string EncyrptingPassword = "T.E.A.M";
        public const string IosCertificatePath = "content/certificates/";
    }

    public static class ErrorMessage
    {
        public const string IntegrationKeyError = "Application Integration key error.";
        public const string ApplicationExceptionMessage = "Uygulamada beklenmedik bir hata meydana geldi.\nLütfen data sonra tekrar deneyiniz.";
        public const string RecordNotFound = "Listelenecek kayıt bulunamadı.";
        public const string LeaguesNotFoundWithRelatedCategory = "Bu kategoriye ait lig kaydı bulunamadı.";
        public const string ApiKeyNotFound = "Api key not found.";
        public const string ChannelTypeNotFound = "Channel type key not found.";
        public const string ApiKeyIncorrect = "Given api key is incorrect.";
        public const string ChannelTypeIncorrect = "Given channel type is incorrect.";
        public const string UserNotFound = "Kullanıcı adı ya da şifre hatalı.";
        public const string UserEmailNotConfirmed = "Üyeliğiniz henüz aktifleştirilmemiş. Lütfen kayıt olduğunuz mail adresinize gönderilen doğrulama maili ile üyeliğinizi aktifleştiriniz.";
        public const string UserNotActive = "Kullanıcı durumu aktif değil.";
        public const string UserEmailNotExists = "Mail adres alanı zounludur.";
        public const string PhoneNumberNotExists = "Telefon alanı zounludur.";
        public const string DeviceKeyNotExists = "DeviceKey alanı zounludur.";
        public const string EmailOrUserNameNotFound = "Girilen değer ile eşleşen kullanıcı adı ya da email bulunamadı.";
        public const string RequestInvalid = "Invalid request.";
        public const string RequestNotFound = "Request body not found";
        public const string ClaimsNotFound = "İşlemi gerçekleştirme yetkiniz bulunmamaktadır.";
        public const string AuthorNotFound = "Yazar bulunamadı ya da kullanıcının yazar rolü mevcut değil.";
        public const string SearchTypeNotFound = "Arama kriteri tipi bulunamadı.";
        public const string AuthorNotSaved = "Yazar kaydetme işlemi başarısız oldu.";
        public const string CouponCannotBeDeleted = "Kupon silme işlemi başarısız oldu.";
        public const string CouponStatusCannotBeChanged = "Kupon onay değişiklik işlemi başarısız oldu.";
        public const string LeagueNotSaved = "Lig kaydetme işlemi başarısız oldu.";
        public const string EventNotSaved = "Maç bilgileri kaydetme işlemi başarısız oldu.";
        public const string EventNotUpdated = "Maç bilgileri güncelleme işlemi başarısız oldu.";
        public const string OddsCannotDeleted = "Maça ait eski bahisleri güncelleme işlemi başarısız oldu.";
        public const string OddsCannotCreated = "Maça ait yeni bahisleri kaydetme işlemi başarısız oldu.";
        public const string EventExists = "Bültende bu kod ile tanımlı farklı bir maç bulunmaktadır.";
        public const string AuthorImageNotSaved = "Yazar resmi kaydetme işlemi başarısız oldu.";
        public const string UserExists = "Kayıt olmak istenilen kullanıcı adı ya da email daha önce kullanılmış.";
        public const string LeagueExists = "Tanımlamaya çalıştığınız lig {0} ({1}) ile çakışıyor. Spor kategori ve lig kodunu benzersiz giriniz.";
        public const string EventExistsWithRelatedLeague = "Silmeye çalıştığınız lig, bir karşılaşma içerisinde tanımlı olduğundan işlem başarısız oldu.";
        public const string EmailSendingFailure = "Email gönderimi başarısız oldu. Lütfen daha sonra tekrar deneyiniz.";
        public const string WrongVerificationLink = "Link geçerliliğini yitirmiş.";
        public const string UserOrEmailNotFound = "Kullanıcı adı ya da email adresi bulunamadı.";
        public const string EventNotStarted = "Sonuç girmek için maç sonunu bekleyiniz.";
        public const string BetTypesNotFound = "Bahis tipi bulunamadı.";
        public const string AuthorListNotFound = "Yazar listesi bulunamadı.";
        public const string PredictionsNotSaved = "Tahmin kaydetme işlemi başarısız oldu.";
        public const string PredictionsNotFound = "Maça ait tahmin bulunamadı.";
        public const string PredictionsCannotBeUpdated = "Tahmin sonuçları güncellenemedi.";
        public const string CommentNotSaved = "Yorum kaydetme işlemi başarısız oldu.";
        public const string CommentAndPredictionsNotSaved = "Tahmin ve  yorum kaydetme işlemi başarısız oldu.";
        public const string OddsNotFound = "Bahis bulunamadı.";
        public const string ChannelTypeNotAppropriate = "Sadece mobil bir device key izni bulunmaktadır.";
        public const string NotAuthorized = "İşlemi gerçekleştirme yetkiniz bulunmamaktadır.";
        public const string RecordNotSaved = "Veri kaydetme işlemi başarısız oldu."; // generic not saved error message
        public const string RecordNotUpdated = "Veri güncelleme işlemi başarısız oldu."; // generic not saved error message
        public const string WrongSecurityCode = "Güvenlik kodu hatalı."; // generic not saved error message
        public const string EventAdditionalInfoNotFound = "Maç limit, handikap bilgileri bulunamadı. Bu bilgilerin olması gerektiğini düşünyorsanız yöneticiniz ile görüşün.";
        public const string UserDeviceNotFound = "Kayıtlı mobil device bulunamadı, bildirim gönderilemedi.";
        public const string MobileUserCouponCannotBeDeleted = "Mobil kullanıcıların oluşturduğu kuponları silme yetkiniz bulunmamaktadır.";
        public const string CouponCannotBeCreatedWithGivenCriteria = "Girilen kriterlere uygun bir kupon oluşturulamadı.";
        public const string CouponCreationHasError = "Kupon oluşturma işlemi sırasında hata alındı.\nLütfen daha sonra tekrar deneyiniz.";
    }

    public static class ApiResponseMessage
    {
        public const string IntegrationNotFound = "Integration not found";
        public const string ExportTypeNotFound = "Export type not found";
    }

    public static class HttpClientResponseMessage
    {
        public const string ContentNoFound = "Veri bulanamadi.";
        public const string ExportTypeNotFound = "Export type not found";
    }


    public static class BusinessResponseMessage
    {
        public const string BetProgramUpToDate = "Mevcut bülten daha önceden güncellenmiş.";
        public const string WeeksNotFound = "Bülten hafta kodlari bulunamadi.";
        public const string EventsNotFound = "{0} hafta kodlu bülten maclari bulunamadi.";
        public const string EventsParseError = "{0} hafta kodlu bülten maclari parse hatasi.";
        public const string EventsSaveError = "{0} hafta kodlu bülten maclari kaydetme hatasi.";
        public const string BetProgramsNotFound = "Bülten bulunamadı.";
    }

    public static class DataAccessResponseMessage
    {
        public const string RecordNotSaved = "Kayit islemi basarisiz!";
    }

    public static class ContentTpye
    {
        public const string FormUrlencoded = "application/x-www-form-urlencoded";
    }

    public static class WebMethodTypeText
    {
        public const string Get = "Get";
        public const string Post = "Post";
        public const string Put = "Put";
    }

    public static class Mail
    {
        public const string VerificationSubject = "Hesap aktivasyon işlemi";
        public const string ReminderSubject = "Kullanıcı parola resetleme isteği";
        //<a href="http://www.w3schools.com/" target="_blank">Visit W3Schools!</a>
        public const string VerificationContent = "Hesabınızı aktifleştirmek için <a href=\"{0}\" taget=\"_blank\"> linke </a> tıklayınız.<br/>";
        public const string ReminderContent = "Merhaba {0}, <br/>Parolanızı resetlemek için <a href=\"{1}\" taget=\"_blank\"> linke </a>  tıklayınız.<br/>";
        public const string Footer = "<br/>Bt iddaa destek ekibi. <br/> <a href=\"https://twitter.com/btiddaa\" taget=\"_blank\">twitter.com/btiddaa</a><br/>";
    }

    public static class ApplicationRole
    {
        public const string Owner = "Owner";
        public const string Admin = "Admin";
        public const string Author = "Author";
        public const string AdminOrAuthor = "Admin,Author";
        public const string None = "None";
    }

    public static class ApplicationUserClaimType
    {
        public const string Role = "role";
        public const string AccountType = "account";
        public const string AccountExpiresAt = "accExpires";
    }

    public static class ApplicationUserClaimValue
    {
        public const string PremiumAccount = "Premium";
        public const string StandartAccount = "Standart";
        public const string TrialAccount = "Trial";
    }

    public static class EventAdditionalInfo
    {
        public const string Limit = "Limit: {0}";
        public const string HalfHomeHandicap = "İYH-1: {0}";
        public const string HalfAwayHandicap = "İYH-2: {0}";
        public const string FinalHomeHandicap = "MSH-1: {0}";
        public const string FinalAwayHandicap = "MSH-2: {0}";
    }


    public static class DefaultAuthenticationTypes
    {
        public const string ApplicationCookie = "ApplicationCookie";
        public const string ExternalCookie = "ExternalCookie";
    }

    public static class ApiRequest
    {
        public const string ApplicationCookie = "ApplicationCookie";
        public const string ExternalCookie = "ExternalCookie";
    }

    public static class ChannelType
    {
        public const string Ios = "0";
        public const string Android = "1";
        public const string WebAdmin = "2";
        public const string WebApp = "3";
    }

    public static class DataGridTableNames
    {
        public const string BetProgramList = "Bülten Listesi";
        public const string EventList = "Maç Listesi";
        public const string MessageList = "Mesaj Listesi";
        public const string OddsList = "Bahis Listesi";
        public const string OddsTypeList = "Bahis Tipi Listesi";
        public const string TippedEventList = "Yazar  Tahmin Listesi";
        public const string MyTippedEventList = "Tahmin Verdiğim Maç Listesi";
        public const string PredictedEventList = "Tahmin Verilen Maç Listesi";
        public const string MyCommentedEventList = "Yorum Yaptığım Maç Listesi";
        public const string MyEventCommentList = "Maça Yaptığım Yorum Listesi";
        public const string AuthorList = "Yazar Listesi";
        public const string CouponList = "Kupon Listesi";
        public const string ExceptionList = "Exception Listesi";
        public const string LogList = "Log Listesi";
        public const string UserList = "Kullanıcı Listesi";
        public const string LeagueList = "Lig Listesi";
    }

    public static class DataGridTableIds
    {
        public const string BetProgramList = "bet-program-list";
        public const string EventList = "event-list";
        public const string OddsList = "odds-list";
        public const string OddsTypeList = "odds-type-list";
        public const string PredictionList = "prediction-list";
        public const string MyPredictionList = "my-prediction-list";
        public const string MyCommentList = "my-comment-list";
        public const string EventAuthorList = "event-author-list";
        public const string AuthorList = "author-list";
        public const string CouponList = "coupon-list";
        public const string MessageList = "message-list";
        public const string ExceptionList = "exception-list";
        public const string UserList = "user-list";
        public const string LogList = "log-list";
        public const string LeaguesList = "league-list";

    }

    public static class ControllerName
    {
        public const string BetProgram = "BetProgram";
        public const string Event = "Event";
        public const string Author = "Author";
        public const string Coupon = "Coupon";
        public const string Tip = "Tip";
        public const string Report = "Report";
        public const string Common = "Common";
    }

    public static class ActionName
    {
        public const string FillBetProgramList = "FillBetProgramList";
        public const string FillEventList = "FillEventList";
        public const string FillCurrentBetProgramEventList = "FillCurrentBetProgramEventList";
        public const string FillOddsList = "FillOddsList";
        public const string FillOddsTypeList = "FillOddsTypeList";
        public const string FillAuthorList = "FillAuthorList";
        public const string FillCouponList = "FillCouponList";
        public const string FillCurrentUserPredictionList = "FillCurrentUserPredictionList";
        public const string FillCurrentUserCommentList = "FillCurrentUserCommentList";
        public const string FillCurrentUserEventCommentList = "FillCurrentUserEventCommentList";
        public const string FillPredictedEventList = "FillPredictedEventList";
        public const string FillRequestBoxList = "FillRequestBoxList";
        public const string FillExceptionList = "FillExceptionList";
        public const string FillUserList = "FillUserList";
        public const string FillLogList = "FillLogList";
        public const string FillLeagueList = "FillLeagueList";
    }

    #region image paths

    public static class ImagePath
    {
        public const string Category = "content/media/category/";
        public const string User = "content/media/user/";
        public const string UserDefault = "content/media/user/avatar.png";
    }

    #endregion image path

    #region UserMessageTypes

    public static class UserMessageType
    {
        public const string None = "none";
        public const string ServerError = "server-error";
        public const string Error = "error";
        public const string Warning = "warning";
        public const string Success = "success";
        public const string Info = "info";
    }

    #endregion  UserMessageTypes

    #region api urls

    public static class ApiUrl
    {
        public const string Register = "Account/Register";
        public const string GetToken = "Token";
        public const string Login = "Account/Login";
        public const string Logout = "Account/Logout";
        public const string BetProgramUpdate = "BetProgram/Update";
        public const string BetProgramWeekCode = "BetProgram/WeekCode";
        public const string BetProgramList = "BetProgram/FillBetProgramList";
        public const string RequestBoxList = "Report/FillRequestBoxList";
        public const string ExceptionList = "Report/FillExceptionList";
        public const string UserList = "Report/FillUserList";
        public const string LogList = "Report/FillLogList";
        public const string AddLeague = "Common/League/Add";
        public const string EditLeague = "Common/League/Edit";
        public const string DeleteLeague = "Common/League/Delete/{0}";
        public const string LeagueDetail = "Common/LeagueDetail/{0}";
        public const string League = "Common/League/{0}";
        public const string BetProgramLeague = "Common/BetProgramLeague";
        public const string LeagueList = "Common/FillLeagueList";
        public const string Category = "Common/Category";
        public const string Interactions = "Common/Interactions";
        public const string BetType = "Common/BetType";
        public const string OddsType = "Common/OddsType/{0}";
        public const string Author = "Common/Author";
        public const string AuthorUser = "Common/AuthorUser";
        public const string ClearCache = "Common/ClearCache";
        public const string SendNotification = "Common/SendNotification";
        public const string EventList = "Event/FillEventList";
        public const string OddsTypeList = "Event/FillOddsTypeList";
        public const string AuthorList = "Author/FillAuthorList";
        public const string CouponDetail = "Coupon/{0}";
        public const string CouponList = "Coupon/FillCouponList";
        public const string DeleteCoupon = "Coupon/{0}/Delete";
        public const string GenerateCoupons = "Coupon/Generate";
        public const string SetCouponApprovalStatus = "Coupon/SetStatus";
        public const string AddAuthor = "Author/Add";
        public const string EditAuthor = "Author/{0}/Edit";
        public const string AuthorDetail = "Author/{0}";
        public const string CurrentUserPredictionList = "Tip/FillCurrentUserPredictionList";
        public const string PredictedEventList = "Tip/FillPredictedEventList";
        public const string CurrentUserCommentList = "Tip/FillCurrentUserCommentList";
        public const string CurrentUserEventCommentList = "Tip/FillCurrentUserEventCommentList";
        public const string SetPredictionResult = "Tip/SetPredictionResult";
        public const string DeletePrediction = "Tip/DeletePrediction";
        public const string DeleteComment = "Tip/DeleteComment";
        public const string UpdateComment = "Tip/UpdateComment";
        public const string NewCommentAndPredictions = "Tip/NewCommentAndPredictions";
        public const string NewOdds = "Tip/NewOdds";
        public const string NewComment = "Tip/NewComment";
        public const string OverrideOdds = "Tip/OverrideOdds";
        public const string EventAdditionalInfo = "Tip/EventAdditionalInfo";
        public const string EventDetails = "Event/Detail/{0}";
        public const string EventAuthorList = "Event/FillAuthorList";
        public const string AuthorTipDetails = "Event/{0}/Author/{1}/Tip";
        public const string AddEvent = "Event/Add";
        public const string EditEvent = "Event/{0}/Edit";
        public const string CurrentBetProgramEventList = "Tip/FillCurrentBetProgramEventList";
        public const string OddsList = "Tip/FillOddsList";
    }

    #endregion api urls

    #region Session

    public static class SessionVariables
    {
        public const string Breadcrumbs = "Breadcrumbs";
        public const string ApplcationUser = "ApplcationUser";
        public const string LeaguesDictionary = "LeaguesDictionary";
        public const string CaptchaCode = "CaptchaCode";
    }

    #endregion Session

    #region RequestType

    public static class RequestTypeText
    {
        public const string Complaint = "Şikayet";
        public const string Suggession = "Öneri";
        public const string Wish = "İstek";
        public const string Other = "Diğer";
    }

    #endregion RequestType


    #region cookies

    public static class Cookies
    {
        public const string AccessToken = "AccessToken";
    }

    #endregion cookies

    #region cofig keys

    public static class ConfigKeys
    {
        public const string ApiUrl = "ApiUrl";
        public const string BetProgramReferer = "BetProgramReferer";
        public const string BetProgramUrl = "BetProgramUrl";
        public const string BetProgramUrlParams = "?type=6&sortValue=DATE&week={0}&day=-1&sort=-1&sortDir=1&groupId=-1&np=1&sport=1";
        public const string BetProgramWeekIdUrl = "BetProgramWeekIdUrl";
        public const string BetProgramWeekIdUrlParams = "?sport=1&type=6&sortValue=DATE&sortDir=-1&groupId=-1&np=0";
        public const string MailFrom = "MailFrom";
        public const string MailPass = "MailPass";
        public const string MailServer = "MailServer";
        public const string MailPort = "MailPort";
        public const string MailUseSsl = "MailUseSSL";
        public const string MailDisplayName = "MailDisplayName";
        public const string SendNotifications = "SendNotifications";
        public const string IosCerFile = "IosCerFile";
        public const string IosCerFilePwd = "IosCerFilePwd";
        public const string AndroidSenderId = "AndroidSenderId";
        public const string AndroidAuthToken = "AndroidAuthToken";
        public const string MaxCouponGeneratorPredictionLimit = "MaxCouponGeneratorPredictionLimit";
    }

    #endregion cofig keys

    #region request headers

    public static class RequestHeader
    {
        public const string Authorization = "Authorization";
        public const string ApiKey = "ApiKey";
        public const string ChannelType = "ChannelType";
    }

    #endregion request headers

    #region database Ids

    public static class DatabaseKey
    {
        /// <summary>
        /// btiddaa_team account
        /// </summary>
        public const string BtIddaaTeamAccountUserId = "eb625e71-994d-46a5-a86d-b45ad1afe549";

        public const int FootballCategoryId = 1;
        public const int BasketballCategoryId = 5;
        public const int TennisCategoryId = 7;
        public const int VolleyballCategoryId = 8;
        public const int HandballCategoryId = 9;

        public const int TotalScoreBetTypeId = 10;
        public const int BasketballBetTypeId = 11;
        public const int BasketballHelperOddsTypesBetTypeId = 12;

        public const string DefaultLeagueCode = "NULL";

        /// <summary>
        /// limit and handicap values stored bet types for basket
        /// </summary>
        public static readonly int[] HelperOddsTypeIdsForBasketball =
        {
            80, //halfHomeHandicap
            81, //halfAwayHandicap
            82, //finalHomeHandicap
            83, //finalAwayHandicap
            86  //limit
        };

        public static class OddsTypeId
        {
            public const int FinalOver15 = 1;
            public const int FinalUnder15 = 2;
            public const int Over25 = 3;
            public const int Under25 = 4;
            public const int FinalOver35 = 5;
            public const int FinalUnder35 = 6;
            public const int Final12 = 7;
            public const int Final10 = 8;
            public const int Final02 = 9;
            public const int Final1 = 10;
            public const int Final0 = 11;
            public const int Final2 = 12;
            public const int SumOfGoals01 = 13;
            public const int SumOfGoals23 = 14;
            public const int SumOfGoals46 = 15;
            public const int SumOfGoals7 = 16;
            public const int Half1 = 20;
            public const int Half0 = 21;
            public const int Half2 = 22;
            public const int HalfTimeOver15 = 23;
            public const int HalfTimeUnder15 = 24;
            public const int Goal = 25;
            public const int NoGoal = 26;
            public const int Half1Final1 = 27;
            public const int Half1Final0 = 28;
            public const int Half1Final2 = 29;
            public const int Half0Final1 = 30;
            public const int Half0Final0 = 31;
            public const int Half0Final2 = 32;
            public const int Half2Final1 = 33;
            public const int Half2Final0 = 34;
            public const int Half2Final2 = 35;

            public const int Score00 = 36;
            public const int Score01 = 37;
            public const int Score02 = 38;
            public const int Score03 = 39;
            public const int Score04 = 40;
            public const int Score05 = 41;

            public const int Score10 = 42;
            public const int Score11 = 43;
            public const int Score12 = 44;
            public const int Score13 = 45;
            public const int Score14 = 46;
            public const int Score15 = 47;

            public const int Score20 = 48;
            public const int Score21 = 49;
            public const int Score22 = 50;
            public const int Score23 = 51;
            public const int Score24 = 52;
            public const int Score25 = 53;

            public const int Score30 = 54;
            public const int Score31 = 55;
            public const int Score32 = 56;
            public const int Score33 = 57;
            public const int Score34 = 58;
            public const int Score35 = 59;

            public const int Score40 = 60;
            public const int Score41 = 61;
            public const int Score42 = 62;
            public const int Score43 = 63;
            public const int Score44 = 64;
            public const int Score45 = 65;

            public const int Score50 = 66;
            public const int Score51 = 67;
            public const int Score52 = 68;
            public const int Score53 = 69;
            public const int Score54 = 70;
            public const int Score55 = 71;

            //  basket odds TypeIds
            public const int BasketHalf1Final1 = 72;
            public const int BasketHalf1Final2 = 73;
            public const int BasketHalf2Final1 = 74;
            public const int BasketHalf2Final2 = 75;
            public const int BasketFinal1 = 76;
            public const int BasketFinal2 = 77;
            public const int BasketHalf1 = 78;
            public const int BasketHalf2 = 79;
            public const int BasketHalfHandicapHome = 80;
            public const int BasketHalfHandicapAway = 81;
            public const int BasketFinalHandicapHome = 82;
            public const int BasketFinalHandicapAway = 83;
            public const int BasketUnder = 84;
            public const int BasketOver = 85;
            public const int Limit = 86;
        }

        public static class ApplicationRoleId
        {
            public const string Admin = "ede64fc4-7b30-45f7-b92d-e71f3d0027b6";
            public const string Author = "911f5c44-c2d1-43aa-9247-ec71fbc17956";
        }
    }

    #endregion database Ids
}