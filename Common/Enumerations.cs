﻿namespace Common.Enumerations
{
    public enum AuthenticationMode
    {
        Network = 0,
        Application = 1,
        Both = 2,
        None = 3,
        BothSecure = 4
    }

    public enum DataExportType
    {
        FromPage,
        FromPopUp
    }

    public enum DataLoadType
    {
        AsPage,
        AsModalBox
    }

    public enum ColumnDataFormat
    {
        Default,
        Date,
        Money
    }

    public enum ColumnDataType
    {
        Text,
        LinkButton,
        ImageButton,
    }

    public enum DataSearchType
    {
        Text,
        Dropdown,
        DatePicker,
        DateRangePicker
    }

    public enum ExportType
    {
        Undefined = -1,
        Product = 0,
        Category = 1
    }

    public enum Status : byte
    {
        Active,
        Passive,
        Suspended,
        Deleted
    }

    public enum CatalogVersion
    {
        Demo,
        Standart,
        Professional
    }

    public enum TemplateType
    {
        Default,
        Food,
        WhiteAppliances // beyaz esya
    }

    public enum Key
    {
        Tag,
        Discount,
        Image,
        Video
    }

    public enum ResponseCode
    {
        Fail = -1,
        Success = 0,
        Warning = 1,
        Info = 2,
        NoEffect = 3,
        DuplicateRecord = 4
    }

    public enum WebMethodType
    {
        Null,
        Get,
        Post,
        Put,
        Info,
        NoEffect
    }

    public enum ContentType
    {
        Null,
        FormUrlencoded
    }

    public enum BettingType
    {
        All,
        Player
    }

    public enum BetSiteId
    {
        Rivalo = 1,
        TempoBet
    }

    public enum PredictonStake : byte
    {
        Stake1 = 1,
        Stake2 = 2,
        Stake3 = 3,
        Stake4 = 4,
        Stake5 = 5,
        Stake6 = 6,
        Stake7 = 7,
        Stake8 = 8,
        Stake9 = 9,
        Stake10 = 10
    }

    public enum PredictionResult : byte
    {
        Pending = 0,
        Won = 1,
        Lost = 2,
        Canceled = 3
    }

    public enum AccountType
    {
        Trial,
        Standart,
        Premium
    }

    public enum TipType : byte
    {
        Comment = 0,
        Prediction = 1
    }

    public enum NotificationStatus : byte
    {
        Initial = 0,
        Queued = 1,
        HasError = 2
    }

    /// <summary>
    ///  dbo.UserSettings.Key 
    /// </summary>
    public enum UserSettingKey : byte
    {
        AuthorNotifications = 0
    }

    public enum SearchType
    {
        Authors = 1,
        Events = 2
    }

    public enum DeviceType : byte
    {
        Ios = 0,
        Android = 1
    }

    public enum RequestType : byte
    {
        Complaint = 0,
        Suggession = 1,
        Wish = 2,
        Other = 3,
        None = 4
    }

    public enum CouponType : byte
    {
        None = 0, // other typed coupon
        Guarantee = 1, // garantee coupon
        Surprise = 2, // surprise coupon
        Cash = 3, // cash coupon
        BtIddaaTeam = 4, // bt iddaa coupon
        BestTiptersTeam = 5, // bestipters spoecial coupon
        Weekend = 6, // weekend coupon
        Weekdays = 7, // weekdays coupon
        MobileUser = 8, // user coupon
    }
}