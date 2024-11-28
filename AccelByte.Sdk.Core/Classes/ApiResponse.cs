// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public abstract class ApiResponse
    {
        public string FullOperationId { get => GetFullOperationId(); }

        public bool IsSuccess { get; set; } = false;

        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

        public string ContentType { get; set; } = "";

        public ApiError Error { get; set; } = ApiError.Empty;

        protected abstract string GetFullOperationId();

        public void ThrowExceptionIfError()
        {
            if (!IsSuccess && Error.IsAvailable)
                throw new ApiResponseException(this, true);
            else if (!IsSuccess)
                throw new ApiResponseException(this, false);
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
                throw new ApiResponseException(this, $"{FullOperationId} returns NULL");

            return Data;
        }
    }
}
