// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AccelByte.Sdk.Core.Net.Logging
{
    public interface IHttpLogger
    {
        IHttpLogWriter? Writer { get; set; }

        void LogRequest(HttpRequestMessage request, long timestamp);

        void LogResponse(HttpResponseMessage response, long timestamp, long reqTimestamp);
    }
}