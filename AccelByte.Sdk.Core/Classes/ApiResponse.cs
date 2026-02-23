// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Core
{
    public abstract class ApiResponse
    {
        public string FullOperationId { get => GetFullOperationId(); }

        public bool IsSuccess { get; set; } = false;

        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

        public string ContentType { get; set; } = "";

        public ApiError Error { get; set; } = ApiError.Empty;

        public string Payload { get; set; } = "";

        protected abstract string GetFullOperationId();

        public void ThrowExceptionIfError()
        {
            if (!IsSuccess && Error.IsAvailable)
                throw ApiResponseException.Create(this, true).WithPayload(Payload);
            else if (!IsSuccess)
                throw ApiResponseException.Create(this, false).WithPayload(Payload);
        }

        /// <summary>
        /// This method is for backward compatibility with monolithic SDK which will throws HttpResponseException.
        /// </summary>
        public void ThrowHttpExceptionIfError()
        {
            if (!IsSuccess)
                throw new HttpResponseException(StatusCode, Payload);
        }

        public void EnsureSuccess()
        {
            ThrowExceptionIfError();
        }
    }

    public abstract class ApiResponse<TData> : ApiResponse
    {
        public TData? Data { get; set; } = default;

        public new TData EnsureSuccess()
        {
            ThrowExceptionIfError();
            if (Data == null)
                throw ApiResponseException.Create(this, $"{FullOperationId} returns NULL")
                    .WithPayload(Payload);

            return Data;
        }
    }
}
