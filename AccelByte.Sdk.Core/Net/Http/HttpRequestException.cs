// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Net;
using System.IO;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class HttpRequestException : Exception
    {
        public Stream Payload { get; init; }

        public string ResponseContentType { get; init; } = String.Empty;

        public HttpRequestException(HttpStatusCode statusCode, string respContentType, Stream payload) : base()
        {
            StatusCode = statusCode;
            Payload = payload;
            ResponseContentType = respContentType;
        }

        public HttpStatusCode StatusCode { get; }

        public string PayloadMessage
        {
            get { return Payload.ReadToString(); }
        }

        public IHttpResponse AsHttpResponse
        {
            get { return new HttpResponse(StatusCode, ResponseContentType, Payload); }
        }
    }
}