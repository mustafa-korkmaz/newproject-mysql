using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Common
{
    /// <summary>
    /// abstract response class
    /// </summary>
    public abstract class AbsResponse
    {
        public ResponseCode ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }

    /// <summary>
    /// response class between Controllers and BL classes
    /// </summary>
    public class BLResponse<T> : AbsResponse
    {
        // to do: here goes other properties for BLResponse object

        T responseData;
        public T ResponseData
        {
            get
            {
                return this.responseData;
            }
            set
            {
                this.responseData = value;
            }
        }

    }

    public static class ResponseMessage
    {
        public const string IntegrationNotFound = "Integration not found";
        public const string ExportTypeNotFound = "Export type not found";
    }
}