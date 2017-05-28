//using System.Collections.Generic;
//using Common.Enumerations;
//using Common.Response;
//using DAL.DataAccess;

//namespace Business.WebApi.Settings
//{
//    public class SettingsBusiness
//    {
//        private readonly SettingsDataAccess _dataAccess = new SettingsDataAccess();

//        public bool IsAuthorNotificationsAllowed(string userId, int authorId)
//        {
//            return _dataAccess.IsSettingExists(userId, UserSettingKey.AuthorNotifications, authorId.ToString());
//        }

//        /// <summary>
//        /// allow author notification or not
//        /// </summary>
//        /// <param name="userId"></param>
//        /// <param name="authorId"></param>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public BusinessResponse<int> SetAuthorNotifications(string userId, int authorId, bool value)
//        {
//            var businessResp = new BusinessResponse<int>
//            {
//                ResponseCode = ResponseCode.Fail
//            };

//            if (value)
//            {
//                businessResp.ResponseData = _dataAccess.InsertSetting(userId, UserSettingKey.AuthorNotifications, authorId.ToString());
//            }
//            else
//            {
//                businessResp.ResponseData = _dataAccess.DeleteSetting(userId, UserSettingKey.AuthorNotifications, authorId.ToString());
//            }

//            businessResp.ResponseCode = ResponseCode.Success;
//            return businessResp;

//        }

//        /// <summary>
//        /// gets user id list from dbo.usersetting table which rows has related key and value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public IEnumerable<string> GetUserIdList(UserSettingKey key, string value)
//        {
//            return _dataAccess.GetUserIdList(key, value);
//        }

//    }
//}
