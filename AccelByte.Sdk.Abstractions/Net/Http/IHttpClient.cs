// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Net.Http
{
    public interface IHttpClient
    {
        IHttpResponse SendRequest(IOperation operation, String baseUrl);

        Task<IHttpResponse> SendRequestAsync(IOperation operation, string baseURL);

        IHttpClient SetLogger(IHttpLogger logger);

        bool UploadBinaryData(string url, byte[] dataToUpload, string contentType);

        Task<bool> UploadBinaryDataAsync(string url, byte[] dataToUpload, string contentType);

        byte[] DownloadBinaryData(string url);

        Task<byte[]> DownloadBinaryDataAsync(string url);
    }
}