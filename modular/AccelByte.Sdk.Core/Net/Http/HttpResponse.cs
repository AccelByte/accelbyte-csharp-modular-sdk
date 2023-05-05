// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Net;
using System.IO;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class HttpResponse : IHttpResponse, IDisposable
    {
        public HttpStatusCode Code { get; }

        public string ContentType { get; }

        public Stream Payload { get; }

        public HttpResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            Code = code;
            ContentType = contentType;
            Payload = payload;
        }

        public void Dispose()
        {
            if (Payload != null)
                Payload.Dispose();
        }
    }
}
