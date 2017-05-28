using Common;
using Common.ApiObjects.Request;
using Common.ApiObjects.Response;
using Common.Enumerations;
using Common.Response;
using DAL;

namespace Business.WebApi.Account
{
    public class AccountBusiness
    {
        private readonly UserDataAccess _dataAccess = new UserDataAccess();

        public BusinessResponse<string> CreateUser(DTO.ApplicationUser userDto, string password, bool isAuthor = false)
        {
            var resp = new BusinessResponse<string> { ResponseCode = ResponseCode.Fail };

            var dbResp = _dataAccess.CreateUser(userDto, password, isAuthor);

            if (dbResp.ResponseCode != ResponseCode.Success)
            {
                resp.ResponseMessage = dbResp.ResponseMessage;
                return resp;
            }

            resp.ResponseCode = ResponseCode.Success;
            resp.ResponseData = dbResp.ResponseData;

            return resp;
        }

        public DTO.ApplicationUser GetUserInfo(string userId)
        {
            return _dataAccess.GetUserInfo(userId);
        }

        public int Edit(DTO.ApplicationUser user)
        {
            return _dataAccess.Edit(user);
        }

        public BusinessResponse<DTO.ApplicationUser> GetUserByEmailOrUserName(string emailOrUsername)
        {
            var resp = new BusinessResponse<DTO.ApplicationUser>
            {
                ResponseCode = ResponseCode.Fail,
                ResponseData = _dataAccess.GetUserByEmailOrUserName(emailOrUsername)
            };

            if (resp.ResponseData == null)
            {
                resp.ResponseMessage = ErrorMessage.UserOrEmailNotFound;
                return resp;
            }

            resp.ResponseCode = ResponseCode.Success;
            return resp;
        }

        public BusinessResponse ResetPassword(string userId, string newPassword)
        {
            var resp = new BusinessResponse
            {
                ResponseCode = ResponseCode.Fail
            };

            var dataAccessResp = _dataAccess.ResetPassword(userId, newPassword);

            if (dataAccessResp.ResponseCode != ResponseCode.Success)
            {
                resp.ResponseMessage = ErrorMessage.UserOrEmailNotFound;
                return resp;
            }

            resp.ResponseCode = ResponseCode.Success;
            return resp;
        }

        //public int SaveUserDevice(string userId, string deviceKey, string channelType)
        //{
        //    DeviceType deviceType = DeviceType.Android;

        //    if (channelType == ChannelType.Ios)
        //    {
        //        deviceType = DeviceType.Ios;
        //    }

        //    var userDevice = new DTO.UserDevice
        //    {
        //        UserId = userId,
        //        Key = deviceKey,
        //        Type = deviceType
        //    };

        //    return _dataAccess.SaveUserDevice(userDevice);
        //}

        //public int DeleteUserDevice(string userId, string deviceKey, string channelType)
        //{
        //    DeviceType deviceType = DeviceType.Android;

        //    if (channelType == ChannelType.Ios)
        //    {
        //        deviceType = DeviceType.Ios;
        //    }

        //    var userDevice = new DTO.UserDevice
        //    {
        //        UserId = userId,
        //        Key = deviceKey,
        //        Type = deviceType
        //    };

        //    return _dataAccess.DeleteUserDevice(userDevice);
        //}

        //public int SaveUserRequest(string userId, string message, int requestType)
        //{
        //    RequestType type = (RequestType)requestType;

        //    var useRequest = new DTO.UserRequest
        //    {
        //        UserId = userId,
        //        Message = message,
        //        Type = type
        //    };

        //    return _dataAccess.SaveUserRequest(useRequest);
        //}

    }
}
