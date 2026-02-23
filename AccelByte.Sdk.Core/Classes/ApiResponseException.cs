using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public class ApiResponseException : Exception
    {
        public string Code { get; set; }

        public string FullOperationId { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string Payload { get; set; } = "";

        public ApiResponseException(ApiResponse responseObj, bool errorAvailable)
            : base(errorAvailable ?
                  $"{responseObj.FullOperationId} returns error: {responseObj.Error.Code}. {responseObj.Error.Message}" :
                  $"{responseObj.FullOperationId} returns unknown error with http status code {(int)responseObj.StatusCode}")
        {
            Code = responseObj.Error.Code;
            FullOperationId = responseObj.FullOperationId;
            StatusCode = responseObj.StatusCode;
        }

        public ApiResponseException(ApiResponse responseObj, string customMessage)
            : base(customMessage)
        {
            Code = responseObj.Error.Code;
            FullOperationId = responseObj.FullOperationId;
            StatusCode = responseObj.StatusCode;
        }

        public ApiResponseException WithPayload(string payload)
        {
            Payload = payload;
            return this;
        }

        public static ApiResponseException Create(ApiResponse responseObj, bool errorAvailable)
            => new ApiResponseException(responseObj, errorAvailable);

        public static ApiResponseException Create(ApiResponse responseObj, string customMessage)
            => new ApiResponseException(responseObj, customMessage);
    }
}
